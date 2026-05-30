using System;
using System;
using System.Windows.Forms;

namespace ElHUerfanitoEscritorio
{
    public partial class Menu : Form
    {
        private int _idRol;
        private string _nombreRol;

        public Menu(int idRol, string nombreRol)
        {
            InitializeComponent();
            _idRol = idRol;
            _nombreRol = nombreRol;
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            this.Text = "Menu El Huerfanito — " + _nombreRol;

            // Empleado (id_rol = 2): ocultar Actualización
            if (_idRol == 2)
            {
                actualizacionToolStripMenuItem.Visible = false;
            }
            // Administrador (id_rol = 1): ve todo, no se oculta nada
        }

        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarMascotaCodigo frm = new ConsultarMascotaCodigo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarNombre frm = new ConsultarNombre();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ingresarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarMascota frm = new IngresarMascota();
            frm.MdiParent = this;
            frm.Show();
        }

        private void retirarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtirarMascota frm = new RtirarMascota();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cambiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarDatos frm = new CambiarDatos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void realizarAdopciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarAdopcion frm = new RealizarAdopcion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cancelarAdopciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarAdopcion frm = new CancelarAdopcion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}