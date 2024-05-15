﻿using AdministradorT.ClasesNodos;
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
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO materia (nombre, horaClase, docente, salon) VALUES (@nombre, @horaClase, @docente, @salon)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", materia.Nombre);
                comando.Parameters.AddWithValue("@horaClase", DateTime.Today.Add(materia.HoraClase)); // Se agrega la hora seleccionada al día actual
                comando.Parameters.AddWithValue("@docente", materia.Docente);
                comando.Parameters.AddWithValue("@salon", materia.Salon);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
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









    }











}

