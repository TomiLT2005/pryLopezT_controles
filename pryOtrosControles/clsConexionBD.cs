using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace pryOtrosControles
{
    class clsConexionBD
    {
        private string cadena = "Server = localhost\\SQLEXPRESS;Database=Controles;Trusted_Connection=True;"; //Casa
        private string cadena2 = "Server=localhost;Database=Comercio;Trusted_Connection=True;"; //Laboratorio


        private SqlConnection conexion;
        private SqlCommand comando;



        //Verificar Conexion
        public clsConexionBD() 
        {
            try
            {
                using(SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la conexión a la base de datos: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Guardar Coordenadas
        public void GuardarCoordenadas(string coordenadas) 
        {
            try
            {
                using(SqlConnection conexion = new SqlConnection(cadena))
                {

                    conexion.Open();

                    //Verifica si ya existe la coordenada en la base de datos
                    string consulta = "SELECT Contador FROM CoordenadasXY WHERE Coordenadas = @coords";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@coords", coordenadas);
                    var resultado = comando.ExecuteScalar();


                    //Si existe la coordenada, actualiza el contador sino la inserta
                    if (resultado != null)
                    {
                        string actualizar = "UPDATE CoordenadasXY SET Contador = Contador + 1 WHERE Coordenadas = @coords";
                        SqlCommand cmdActualizar = new SqlCommand(actualizar, conexion);
                        cmdActualizar.Parameters.AddWithValue("@coords", coordenadas);
                        cmdActualizar.ExecuteNonQuery();
                    }
                    else
                    {
                        string insertar = "INSERT INTO CoordenadasXY (Coordenadas) VALUES (@coords)";
                        SqlCommand cmdInsertar = new SqlCommand(insertar, conexion);
                        cmdInsertar.Parameters.AddWithValue("@coords", coordenadas);
                        cmdInsertar.ExecuteNonQuery();
                    }
                }
            
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar las coordenadas: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Mostrar Coordenadas
        public void MostrarCoordenadas(ListBox lista)
        {
            try
            {
                using(SqlConnection conexion = new SqlConnection(cadena)) 
                {
                    conexion.Open();

                    string consulta = @"SELECT TOP 10 Coordenadas, Contador FROM CoordenadasXY ORDER BY Contador DESC";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();

                    //Recorrido para mostrar las coordenadas
                    int i = 1;
                    while (lector.Read())
                    {
                        string coord = lector.GetString(0);
                        int contador = lector.GetInt32(1);
                        lista.Items.Add($"{i}. Coordenadas: {coord} - Veces: {contador}");
                        i++;
                    }

                    lector.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar las coordenadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}
