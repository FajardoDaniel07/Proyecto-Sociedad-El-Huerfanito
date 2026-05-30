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
    public partial class CambiarDatos : Form
    {
        public CambiarDatos()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConexionBD.conectar();

            string sql = "SELECT * FROM Mascota WHERE id_mascota = " + txCodigo.Text;

            SqlDataReader dr = ConexionBD.consulta(sql, con);

            if (dr != null && dr.Read())
            {
                txNombre.Text = dr["nombre"].ToString();
                txIdTipo.Text = dr["id_tipo"].ToString();
                txRaza.Text = dr["raza"].ToString();
                txEdad.Text = dr["edad_meses"].ToString();
                cbSexo.Text = dr["sexo"].ToString();
                cbEstado.Text = dr["estado"].ToString();
            }
            else
            {
                MessageBox.Show("Mascota no encontrada");
            }

            ConexionBD.cerrar(con);
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (txCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el ID de la mascota");
                return;
            }

            SqlConnection con = ConexionBD.conectar();

            string sql = "UPDATE Mascota SET " +
                         "nombre = '" + txNombre.Text + "', " +
                         "id_tipo = " + txIdTipo.Text + ", " +
                         "raza = '" + txRaza.Text + "', " +
                         "edad_meses = " + txEdad.Text + ", " +
                         "sexo = '" + cbSexo.Text + "', " +
                         "estado = '" + cbEstado.Text + "' " +
                         "WHERE id_mascota = " + txCodigo.Text;

            int filas = ConexionBD.operar(sql, con);

            if (filas > 0)
            {
                MessageBox.Show("Mascota actualizada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la mascota");
            }

            ConexionBD.cerrar(con);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txCodigo.Clear();
            txNombre.Clear();
            txIdTipo.Clear();
            txRaza.Clear();
            txEdad.Clear();

            cbSexo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;

            txCodigo.Focus();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    
}
