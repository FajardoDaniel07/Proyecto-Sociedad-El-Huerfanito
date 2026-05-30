namespace ElHUerfanitoEscritorio
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarAdopciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarAdopciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCodigoToolStripMenuItem,
            this.porNombreToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // porCodigoToolStripMenuItem
            // 
            this.porCodigoToolStripMenuItem.Name = "porCodigoToolStripMenuItem";
            this.porCodigoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.porCodigoToolStripMenuItem.Text = "Por Codigo";
            this.porCodigoToolStripMenuItem.Click += new System.EventHandler(this.porCodigoToolStripMenuItem_Click);
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarMascotaToolStripMenuItem,
            this.retirarMascotaToolStripMenuItem,
            this.cambiarDatosToolStripMenuItem});
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            // 
            // ingresarMascotaToolStripMenuItem
            // 
            this.ingresarMascotaToolStripMenuItem.Name = "ingresarMascotaToolStripMenuItem";
            this.ingresarMascotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarMascotaToolStripMenuItem.Text = "Ingresar Mascota";
            this.ingresarMascotaToolStripMenuItem.Click += new System.EventHandler(this.ingresarMascotaToolStripMenuItem_Click);
            // 
            // retirarMascotaToolStripMenuItem
            // 
            this.retirarMascotaToolStripMenuItem.Name = "retirarMascotaToolStripMenuItem";
            this.retirarMascotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retirarMascotaToolStripMenuItem.Text = "Retirar Mascota";
            this.retirarMascotaToolStripMenuItem.Click += new System.EventHandler(this.retirarMascotaToolStripMenuItem_Click);
            // 
            // cambiarDatosToolStripMenuItem
            // 
            this.cambiarDatosToolStripMenuItem.Name = "cambiarDatosToolStripMenuItem";
            this.cambiarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarDatosToolStripMenuItem.Text = "Cambiar Datos";
            this.cambiarDatosToolStripMenuItem.Click += new System.EventHandler(this.cambiarDatosToolStripMenuItem_Click);
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarAdopciónToolStripMenuItem,
            this.cancelarAdopciónToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // realizarAdopciónToolStripMenuItem
            // 
            this.realizarAdopciónToolStripMenuItem.Name = "realizarAdopciónToolStripMenuItem";
            this.realizarAdopciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarAdopciónToolStripMenuItem.Text = "Realizar Adopción";
            this.realizarAdopciónToolStripMenuItem.Click += new System.EventHandler(this.realizarAdopciónToolStripMenuItem_Click);
            // 
            // cancelarAdopciónToolStripMenuItem
            // 
            this.cancelarAdopciónToolStripMenuItem.Name = "cancelarAdopciónToolStripMenuItem";
            this.cancelarAdopciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelarAdopciónToolStripMenuItem.Text = "Cancelar Adopción";
            this.cancelarAdopciónToolStripMenuItem.Click += new System.EventHandler(this.cancelarAdopciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu El Huerfanito";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarAdopciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarAdopciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

