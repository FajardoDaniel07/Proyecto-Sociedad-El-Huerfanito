namespace ElHUerfanitoEscritorio
{
    partial class CancelarAdopcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.txIdAdopcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEstadoAdop = new System.Windows.Forms.ComboBox();
            this.txFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txIdAdop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 32);
            this.label10.TabIndex = 84;
            this.label10.Text = "CANCELAR ADOPCION";
            // 
            // txIdAdopcion
            // 
            this.txIdAdopcion.Location = new System.Drawing.Point(111, 107);
            this.txIdAdopcion.Name = "txIdAdopcion";
            this.txIdAdopcion.Size = new System.Drawing.Size(100, 20);
            this.txIdAdopcion.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Id Adopcion:";
            // 
            // cbEstadoAdop
            // 
            this.cbEstadoAdop.FormattingEnabled = true;
            this.cbEstadoAdop.Items.AddRange(new object[] {
            "Activa",
            "Cancelada",
            "Fibalizada"});
            this.cbEstadoAdop.Location = new System.Drawing.Point(133, 157);
            this.cbEstadoAdop.Name = "cbEstadoAdop";
            this.cbEstadoAdop.Size = new System.Drawing.Size(100, 21);
            this.cbEstadoAdop.TabIndex = 89;
            // 
            // txFecha
            // 
            this.txFecha.Location = new System.Drawing.Point(133, 119);
            this.txFecha.Name = "txFecha";
            this.txFecha.Size = new System.Drawing.Size(100, 20);
            this.txFecha.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Fecha:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 85;
            this.label14.Text = "Estado: ";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(324, 107);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(78, 27);
            this.btBuscar.TabIndex = 92;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.btLimpiar);
            this.Panel.Controls.Add(this.btSalir);
            this.Panel.Controls.Add(this.txIdAdop);
            this.Panel.Controls.Add(this.label9);
            this.Panel.Controls.Add(this.txCodigo);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.btCancelar);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.label14);
            this.Panel.Controls.Add(this.txFecha);
            this.Panel.Controls.Add(this.cbEstadoAdop);
            this.Panel.Location = new System.Drawing.Point(18, 174);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(412, 211);
            this.Panel.TabIndex = 93;
            this.Panel.TabStop = false;
            this.Panel.Text = "Datos Adopcion";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(306, 35);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(78, 27);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(133, 42);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(100, 20);
            this.txCodigo.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Codigo Mascota:";
            // 
            // txIdAdop
            // 
            this.txIdAdop.Location = new System.Drawing.Point(133, 81);
            this.txIdAdop.Name = "txIdAdop";
            this.txIdAdop.Size = new System.Drawing.Size(100, 20);
            this.txIdAdop.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Id Adoptante: ";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(306, 97);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(78, 27);
            this.btLimpiar.TabIndex = 95;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(306, 160);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(78, 27);
            this.btSalir.TabIndex = 94;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // CancelarAdopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txIdAdopcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Name = "CancelarAdopcion";
            this.Text = "Cancelar Adopcion";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txIdAdopcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEstadoAdop;
        private System.Windows.Forms.TextBox txFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox Panel;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txIdAdop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
    }
}