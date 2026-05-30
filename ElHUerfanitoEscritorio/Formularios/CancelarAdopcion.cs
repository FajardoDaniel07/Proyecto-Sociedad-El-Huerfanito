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
    public partial class CancelarAdopcion : Form
    {
        public CancelarAdopcion()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConexionBD.conectar();

            string sql = "SELECT * FROM Adopcion WHERE id_adopcion = " + txIdAdopcion.Text;

            SqlDataReader dr = ConexionBD.consulta(sql, con);

            if (dr != null && dr.Read())
            {
                txCodigo.Text = dr["id_mascota"].ToString();
                txIdAdop.Text = dr["id_adoptante"].ToString();
                txFecha.Text = Convert.ToDateTime(dr["fecha"]).ToString("yyyy-MM-dd");

                cbEstadoAdop.Items.Clear();
                cbEstadoAdop.Items.Add(dr["estado"].ToString());
                cbEstadoAdop.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Adopción no encontrada");
            }

            ConexionBD.cerrar(con);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

            txIdAdopcion.Clear();

            txCodigo.Clear();
            txIdAdop.Clear();
            txFecha.Clear();

            cbEstadoAdop.Items.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (cbEstadoAdop.Text == "Cancelada")
            {
                MessageBox.Show("La adopción ya está cancelada");
                return;
            }

            SqlConnection con = ConexionBD.conectar();

            string sql1 = "UPDATE Adopcion " +
                          "SET estado = 'Cancelada' " +
                          "WHERE id_adopcion = " + txIdAdopcion.Text;

            int filas = ConexionBD.operar(sql1, con);

            if (filas > 0)
            {
                string sql2 = "UPDATE Mascota " +
                              "SET estado = 'Disponible' " +
                              "WHERE id_mascota = " + txCodigo.Text;

                ConexionBD.operar(sql2, con);

                MessageBox.Show("Adopción cancelada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo cancelar la adopción");
            }

            ConexionBD.cerrar(con);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
