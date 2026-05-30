using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElHUerfanitoEscritorio
{
    public class ConexionBD
    {
        public static SqlConnection conectar()
        {
            SqlConnection conectar = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=SociedadElHuerfanito;" +
                "Integrated Security=True;"
            );

            try
            {
                conectar.Open();
                MessageBox.Show(" Conexión exitosa a la base de datos");
                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Fallo la conexión: " + ex.Message);
                return null;
            }
        }

    
        public static SqlDataReader consulta(string sql, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(sql, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta: " + ex.Message);
                return null;
            }
        }

        public static int operar(string sql, SqlConnection conector)
        {
            int filas = -1;

            try
            {
                SqlCommand comando = new SqlCommand(sql, conector);
                filas = comando.ExecuteNonQuery();
                return filas;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" Error en operación: " + ex.Message);
                return filas;
            }
        }

        public static void cerrar(SqlConnection conector)
        {
            try
            {
                if (conector != null && conector.State == System.Data.ConnectionState.Open)
                {
                    conector.Close();
                }
            }
            catch (SqlException)
            {

            }
        }
    }
}