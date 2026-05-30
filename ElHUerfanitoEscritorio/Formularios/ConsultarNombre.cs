using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElHUerfanitoEscritorio
{
    public partial class ConsultarNombre : Form
    {
        public ConsultarNombre()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SociedadElHuerfanito;Integrated Security=SSPI;";

            if (txNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la mascota");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();

                    string query = @"SELECT TOP 1 id_mascota, nombre, id_tipo, raza, edad_meses, sexo, estado
                             FROM Mascota
                             WHERE nombre LIKE @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "%" + txNombre.Text + "%");

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            txCodigo.Text = dr["id_mascota"].ToString();
                            txNombre.Text = dr["nombre"].ToString();
                            txIdTipo.Text = dr["id_tipo"].ToString();
                            txRaza.Text = dr["raza"].ToString();
                            txEdad.Text = dr["edad_meses"].ToString();

                            cbSexo.Text = dr["sexo"].ToString();
                            cbEstado.Text = dr["estado"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna mascota con ese nombre");
                            LimpiarCampos();
                        }

                        dr.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txNombre.Clear();
            txCodigo.Clear();
            txNombre.Clear();
            txIdTipo.Clear();
            txRaza.Clear();
            txEdad.Clear();

            cbSexo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
          
            txCodigo.Clear();
            txNombre.Clear();
            txNombre.Clear();
            txIdTipo.Clear();
            txRaza.Clear();
            txEdad.Clear();

            cbSexo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;

            txNombre.Focus();
        }
    }
    
}
