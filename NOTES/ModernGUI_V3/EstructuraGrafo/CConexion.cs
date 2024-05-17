using AdministradorT.ClasesNodos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public bool InsertarAnotacion(string titulo, string cuerpo, string nombreMateria)
        {
           
            try
            {
                conexion.Open();

                string consulta = "INSERT INTO anotacion (titulo, cuerpo, NombreMat) VALUES (@titulo, @cuerpo, @nombreMateria)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@cuerpo", cuerpo);
                comando.Parameters.AddWithValue("@nombreMateria", nombreMateria);
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


        public List<Materia> ObtenerTodasLasMaterias(CGrafo grafo)
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                conexion.Open();
                //string consulta = "SELECT * FROM materia";
                string consulta = "SELECT * FROM materia INNER JOIN dia_materia on idMateria = materia_id";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
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
                        string codigo = reader.GetString("idMateria");
                        string nombre = reader.GetString("nombre");
                        TimeSpan horaClase = reader.GetDateTime("horaClase").TimeOfDay;
                        string docente = reader.GetString("docente");
                        string salon = reader.GetString("salon");
                        string dia = reader.GetString("dia");

                        if (codigo == codigoAnterior || row == 0)
                        {
                            if (materiaR)
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
                            grafo.AgregarNodo(materia);
                            grafo.nodosMaterias.Add(materia);
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
                if (!string.IsNullOrEmpty(codigoAnterior))
                {
                    // Aquí puedes crear la instancia de Materia y agregarla a la lista
                    Materia materia = new Materia(codigoAnterior, nombreAnterior, horaAnterior, dias, docenteAnterior, salonAnterior);
                    grafo.AgregarNodo(materia);
                    grafo.nodosMaterias.Add(materia);
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














































    }

}

