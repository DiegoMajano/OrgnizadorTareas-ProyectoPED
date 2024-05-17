using AdministradorT.ClasesNodos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace AdministradorT
{
    public class CConexion
    {

        public Materia nuevaMateria;
        //Nodo destino de la conexion realizada
        public CNodos nodoDestino;
        public int peso;

        public CConexion(int peso)
        {
            nodoDestino = new CNodos();
            this.peso = peso;
        }

        public CConexion(CNodos nodo)
        {
            nodoDestino = nodo;
        }

        private MySqlConnection conexion;

        public CConexion()
        {
            string servidor = "localhost";
            string baseDeDatos = "catedraped";
            string usuario = "root";
            string contraseña = "";

            string cadenaConexion = $"Server={servidor};Database={baseDeDatos};Uid={usuario};Pwd={contraseña};";

            conexion = new MySqlConnection(cadenaConexion);
        }

        // ------------------------------- METODO DE CONEXION A LA BD -------------------------------
        public bool Conexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ------------------------------- METODOS PARA HACER LOS INSERT A LA BD -------------------------------

        // METODO PARA INSERTAR LAS MATERIAS
        public bool InsertarMateria(Materia materia)
        {
            MySqlTransaction transaction = null;
            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();

                // Insertar la materia
                string consultaMateria = "INSERT INTO materia (idMateria,nombre, horaClase, docente, salon) VALUES (@idMateria,@nombre, @horaClase, @docente, @salon)";
                MySqlCommand comandoMateria = new MySqlCommand(consultaMateria, conexion, transaction);
                comandoMateria.Parameters.AddWithValue("@idMateria", materia.ID);
                comandoMateria.Parameters.AddWithValue("@nombre", materia.Nombre);
                comandoMateria.Parameters.AddWithValue("@horaClase", DateTime.Today.Add(materia.HoraClase)); // Se agrega la hora seleccionada al día actual
                comandoMateria.Parameters.AddWithValue("@docente", materia.Docente);
                comandoMateria.Parameters.AddWithValue("@salon", materia.Salon);
                comandoMateria.ExecuteNonQuery();

                // Obtener el ID de la materia insertada
                long materiaId = comandoMateria.LastInsertedId;

                // Insertar los días de la semana
                string consultaDias = "INSERT INTO dia_materia (materia_id, dia) VALUES (@materiaId, @dia)";
                foreach (var dia in materia.Dias)
                {
                    MySqlCommand comandoDias = new MySqlCommand(consultaDias, conexion, transaction);
                    comandoDias.Parameters.AddWithValue("@materiaId", materia.ID);
                    comandoDias.Parameters.AddWithValue("@dia", dia);
                    comandoDias.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show("Error al insertar la materia en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        // METODO PARA INSERTAR LAS ANOTACIONES
        public bool InsertarAnotacion(Anotacion anotacion,string materiaE)
        {           
            try
            {
                conexion.Open();

                string consulta = "INSERT INTO anotacion (idanotacion, titulo, cuerpo, NombreMat) VALUES (@idAnotacion,@titulo, @cuerpo, @nombreMateria)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@idAnotacion", anotacion.ID);
                comando.Parameters.AddWithValue("@titulo", anotacion.Titulo);
                comando.Parameters.AddWithValue("@cuerpo", anotacion.Cuerpo);
                comando.Parameters.AddWithValue("@nombreMateria", materiaE);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la anotación en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        // METODO PARA INSERTAR TAREAS
        public bool InsertarTarea(string titulo, string descripcion, DateTime fechaLimite, string materia, string anotacion, string estadoTarea)
        {
            try
            {
                conexion.Open();

                string consulta = "INSERT INTO tarea (titulo, descripcion, fechaLimite, nombre, AnotacionT, MateriaT, estadotarea) " +
                                  "VALUES (@titulo, @descripcion, @fechaLimite, @nombre, @AnotacionT, @MateriaT, @estadoTarea)";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@fechaLimite", fechaLimite);
                comando.Parameters.AddWithValue("@nombre", materia);
                comando.Parameters.AddWithValue("@AnotacionT", anotacion);
                comando.Parameters.AddWithValue("@MateriaT", materia);
                comando.Parameters.AddWithValue("@estadoTarea", estadoTarea);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la tarea en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        // ------------------------------- METODOS PARA HACER SELECTS DE LA BD -------------------------------

        // METODOS PARA OBTENER LOS ID



        private int ObtenerIdAnotacion(string nombreAnotacion)
        {
            int idAnotacion = -1;
            try
            {
                conexion.Open();
                string consulta = "SELECT idAnotacion FROM anotacion WHERE titulo = @titulo";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@titulo", nombreAnotacion);
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    idAnotacion = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el id de la anotación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return idAnotacion;
        }

        // METODOS PARA OBTENER LOS NOMBRES O TITULOS

        public List<string> ObtenerNombresMaterias()
        {
            List<string> nombresMaterias = new List<string>();
            try
            {
                conexion.Open();
                string consulta = "SELECT nombre FROM materia";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresMaterias.Add(reader.GetString("nombre"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los nombres de las materias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return nombresMaterias;
        }

        public List<string> ObtenerNombresAnotaciones()
        {
            List<string> nombresAnotaciones = new List<string>();
            try
            {
                conexion.Open();
                string consulta = "SELECT titulo FROM anotacion";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresAnotaciones.Add(reader.GetString("titulo"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los nombres de las anotaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return nombresAnotaciones;
        }

        public List<string> ObtenerTitulosTareas()
        {
            List<string> titulosTareas = new List<string>();
            try
            {
                conexion.Open();
                string consulta = "SELECT titulo FROM tarea";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        titulosTareas.Add(reader.GetString("titulo"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los títulos de las tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return titulosTareas;
        }


        // METODOS PARA OBTENER TODOS LOS CAMPOS DE LAS TABLAS

        public List<Materia> ObtenerTodasLasMaterias()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                conexion.Open();
                // inner join para obtener los dias de clase de la materia
                string consulta = "SELECT * FROM materia INNER JOIN dia_materia on idMateria = materia_id";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                // varibles necesarias para guardar temporalmente los datos
                string codigoAnterior = "";
                string nombreAnterior = "";
                TimeSpan horaAnterior = new TimeSpan(0,0,0);
                string docenteAnterior = "";
                string salonAnterior = "";
                string diaAnterior = "";
                List<string> dias = new List<string>();
                List<string> diasAnterior = new List<string>();
                int row = 0;
                bool materiaR = false;

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // asignar los datos segun las columnas del select obtenido
                        string codigo = reader.GetString("idMateria");
                        string nombre = reader.GetString("nombre");
                        TimeSpan horaClase = reader.GetDateTime("horaClase").TimeOfDay;
                        string docente = reader.GetString("docente");
                        string salon = reader.GetString("salon");
                        string dia = reader.GetString("dia");

                        if (codigo == codigoAnterior || row == 0) // verificar si es el primer registro o si el registro pertenece a una misma materia previa
                        {
                            if (materiaR) // si ya se registro una materia previamente
                            {
                                dias = null;
                                dias = new List<string>();
                                dias.Add(diaAnterior);
                                materiaR = false;
                            }
                            dias.Add(dia);
                            row++;
                        }
                        else
                        { 
                            // Aquí puedes crear la instancia de Materia y agregarla a la lista
                            Materia materia = new Materia(codigoAnterior, nombreAnterior, horaAnterior, dias, docenteAnterior, salonAnterior);                                                     
                            materias.Add(materia);                            
                            row = 0;
                            materiaR = true;
                        }
                        codigoAnterior = codigo;
                        nombreAnterior = nombre;
                        horaAnterior = horaClase;
                        docenteAnterior = docente;
                        salonAnterior = salon;
                        diaAnterior = dia;
                    }
                }
                if (!string.IsNullOrEmpty(codigoAnterior)) // el ultimo registro que obtiene de todos los datos
                {
                    // Aquí puedes crear la instancia de Materia y agregarla a la lista
                    Materia materia = new Materia(codigoAnterior, nombreAnterior, horaAnterior, dias, docenteAnterior, salonAnterior);                   
                    materias.Add(materia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las materias de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return materias;
        }

        public List<Anotacion> ObtenerTodasLasAnotaciones()
        {
            List<Anotacion> anotaciones = new List<Anotacion>();

            try
            {
                conexion.Open();
                // inner join para obtener los dias de clase de la materia
                string consulta = "SELECT * FROM anotacion";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // asignar los datos segun las columnas del select obtenido
                        string codigo = reader.GetString("idAnotacion");
                        string titulo = reader.GetString("titulo");                        
                        string cuerpo = reader.GetString("cuerpo");
                       
                        // Aquí puedes crear la instancia de Materia y agregarla a la lista
                        Anotacion anotacion = new Anotacion(codigo, titulo, cuerpo);
                        anotaciones.Add(anotacion);                        
                    }
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las anotaciones de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }

            return anotaciones;
        }

        public bool InsertarRecordatorio(string idRecordatorio, string titulo, DateTime fechaRecordatorio, string cuerpo, string materiaR, string anotacionR, string tareaR)
        {
            try
            {
                conexion.Open();

                string consulta = "INSERT INTO recordatorio (idRecordatorio, titulo, fechaRecordatorio, cuerpo, MateriaR, AnotacionR, TareaR) " +
                                  "VALUES (@idRecordatorio, @titulo, @fechaRecordatorio, @cuerpo, @materiaR, @anotacionR, @tareaR)";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@idRecordatorio", idRecordatorio);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@fechaRecordatorio", fechaRecordatorio);
                comando.Parameters.AddWithValue("@cuerpo", cuerpo);
                comando.Parameters.AddWithValue("@materiaR", materiaR);
                comando.Parameters.AddWithValue("@anotacionR", anotacionR);
                comando.Parameters.AddWithValue("@tareaR", tareaR);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el recordatorio en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Recordatorio> ObtenerRecordatorios()
        {
            List<Recordatorio> recordatorios = new List<Recordatorio>();

            try
            {
                conexion.Open();
                string consulta = "SELECT * FROM recordatorio";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string titulo = reader.GetString("idRecordatorio");
                        string cuerpo = reader.GetString("cuerpo");
                        string aRecordar = reader.GetString("arecordar");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los recordatorios de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }

            return recordatorios;
        }

        // ------------------------------- METODOS PARA HACER UPDATES A LA BD -------------------------------

        private bool ActualizarMateria(Materia materiaN)
        {
            try
            {
                conexion.Open();
                string consulta = "UPDATE materia SET nombre = @nombreN, horaClase = @horaClase, docente = @docente, salon = @salon  where idMateria = @id ";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreN", materiaN.nombre);
                comando.Parameters.AddWithValue("@horaClase", DateTime.Today.Add(materiaN.HoraClase));
                comando.Parameters.AddWithValue("@docente", materiaN.Docente);
                comando.Parameters.AddWithValue("@salon", materiaN.Salon);
                comando.Parameters.AddWithValue("@id", materiaN.ID);
                comando.ExecuteNonQuery();
                
                foreach (string dia in materiaN.Dias)
                {
                    string consulta2 = "UPDATE dia_materia SET dia = @dia where materia_id = @id";
                    MySqlCommand comando2 = new MySqlCommand(consulta2, conexion);
                    comando2.Parameters.AddWithValue("@dia", dia);
                    comando2.Parameters.AddWithValue("@id", materiaN.ID);
                    comando.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la materia de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        private bool ActualizarAnotacion(Anotacion anotacionN)
        {
            try
            {
                conexion.Open();

                string consulta = "UPDATE anotacion SET titulo = @tituloN, cuerpo = @cuerpoN where idRecordatorio = @id ";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreN", anotacionN.Titulo);
                comando.Parameters.AddWithValue("@cuerpo", anotacionN.Cuerpo);
                comando.Parameters.AddWithValue("@id", anotacionN.ID);
                comando.ExecuteNonQuery();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la anotación de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        private bool ActualizarRecordatorio(Recordatorio recordatorioN)
        {
            try
            {
                conexion.Open();

                string consulta = "UPDATE recordatorio SET titulo = @tituloN, arecordar = @aRecordar, cuerpo = @cuerpoN where idRecordatorio = @id ";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreN", recordatorioN.Titulo);
                comando.Parameters.AddWithValue("@horaClase", recordatorioN.aRecordar);
                comando.Parameters.AddWithValue("@cuerpo", recordatorioN.Cuerpo);
                comando.Parameters.AddWithValue("@id", recordatorioN.ID);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el recordatorio de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        private bool ActualizarTarea(Tarea tareaN)
        {
            try
            {
                conexion.Open();

                string consulta = "UPDATE tarea SET nombre = @tituloN, descripcion = @cuerpoN, estadotarea = @estado where id_tarea = @id ";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreN", tareaN.Titulo);
                comando.Parameters.AddWithValue("@hora", tareaN.FechaEntrega);
                comando.Parameters.AddWithValue("@cuerpo", tareaN.Cuerpo);
                comando.Parameters.AddWithValue("@estado", tareaN.EstadoTarea.ToString());                
                comando.Parameters.AddWithValue("@id", tareaN.ID);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tarea de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        // ------------------------------- METODOS PARA HACER DELETES A LA BD -------------------------------

        private bool EliminarMateria(Materia materia)
        {
            try
            {
                conexion.Open();

                string consulta = "DELETE FROM dia_materia where materia_id = @id";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", materia.ID);
                comando.ExecuteNonQuery();
               
                string consulta1 = "DELETE FROM materia where idMateria = @id";
                MySqlCommand comando1 = new MySqlCommand(consulta1, conexion);

                comando.Parameters.AddWithValue("@id", materia.ID);
                comando.ExecuteNonQuery();                

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la materia de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        private bool EliminarAnotacion(Anotacion anotacionE)
        {
            try
            {
                conexion.Open();

                string consulta = "DELETE FROM anotacion where idAnotacion = @id";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@id", anotacionE.ID);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la anotación de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        private bool EliminarRecordatorio(Recordatorio recordatorioE)
        {
            try
            {
                conexion.Open();
                string consulta = "DELETE FROM tarea where id_tarea = @id"; 
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@id", recordatorioE.ID);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el recordatorio de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        private bool EliminarTarea(Tarea tareaE)
        {
            try
            {
                conexion.Open();
                string consulta = "DELETE FROM tarea where id_tarea = @id";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@id", tareaE.ID);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la tarea de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
    }

}

