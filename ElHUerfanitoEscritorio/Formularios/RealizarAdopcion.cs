using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ElHUerfanitoEscritorio
{
    public partial class RealizarAdopcion : Form
    {
        public RealizarAdopcion()
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
                cbEstado.Text = dr["estado"].ToString();
            }
            else
            {
                MessageBox.Show("Mascota no encontrada");
            }

            ConexionBD.cerrar(con);
        }

        private void btAdoptar_Click(object sender, EventArgs e)
        {
            if (cbEstado.Text != "Disponible")
            {
                MessageBox.Show("La mascota no está disponible para adopción");
                return;
            }

            SqlConnection con = ConexionBD.conectar();

            string sql = "INSERT INTO Adopcion " +
                         "(id_adopcion, id_mascota, id_adoptante, fecha, estado) " +
                         "VALUES (" +
                         txIdAdopcion.Text + ", " +
                         txCodigo.Text + ", " +
                         txIdAdop.Text + ", '" +
                         txFecha.Text + "', '" +
                         cbEstado.Text + "')";

            int filas = ConexionBD.operar(sql, con);

            if (filas > 0)
            {
                string sql2 = "UPDATE Mascota " +
                              "SET estado = 'Adoptada' " +
                              "WHERE id_mascota = " + txCodigo.Text;

                ConexionBD.operar(sql2, con);

                MessageBox.Show("Adopción registrada correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar la adopción");
            }

            ConexionBD.cerrar(con);

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txIdAdopcion.Clear();

            txCodigo.Clear();
            txNombre.Clear();
            cbEstado.Items.Clear();

            txIdAdop.Clear();
            txNombreAdop.Clear();
            txTel.Clear();

            cbEstado.SelectedIndex = 0;

            txFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConexionBD.conectar();

            string sql = "SELECT * FROM Adoptante WHERE id_adoptante = " + txIdAdop.Text;

            SqlDataReader dr = ConexionBD.consulta(sql, con);

            if (dr != null && dr.Read())
            {
                txNombreAdop.Text = dr["nombre"].ToString();
                txTel.Text = dr["telefono"].ToString(); 
                txDire.Text = dr["direccion"].ToString();
            }
            else
            {
                MessageBox.Show("Adoptante no encontrado");
            }

            ConexionBD.cerrar(con);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

