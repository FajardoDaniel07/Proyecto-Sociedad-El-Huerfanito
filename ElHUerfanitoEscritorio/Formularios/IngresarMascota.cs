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
    public partial class IngresarMascota : Form
    {
        public IngresarMascota()
        {
            InitializeComponent();
        }

        private void IngresarMascota_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txCodigo.Text == "" ||
                txNombre.Text == "" ||
                txIdTipo.Text == "" ||
                txRaza.Text == "" ||
                txEdad.Text == "" ||
                cbSexo.SelectedIndex == -1 ||
                cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            SqlConnection con = ConexionBD.conectar();

            if (con != null)
            {
                string sql = "INSERT INTO Mascota (id_mascota, nombre, id_tipo, raza, edad_meses, sexo, estado) VALUES ("
                             + txCodigo.Text + ", '"
                             + txNombre.Text.Replace("'", "''") + "', "
                             + txIdTipo.Text + ", '"
                             + txRaza.Text.Replace("'", "''") + "', "
                             + txEdad.Text + ", '"
                             + cbSexo.Text + "', '"
                             + cbEstado.Text + "')";

                int filas = ConexionBD.operar(sql, con);

                if (filas > 0)
                {
                    MessageBox.Show(" Mascota registrada correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(" No se pudo registrar la mascota");
                }

                ConexionBD.cerrar(con);
            }
        }

        private void Limpiar()
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