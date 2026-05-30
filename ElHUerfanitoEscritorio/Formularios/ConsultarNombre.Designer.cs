namespace ElHUerfanitoEscritorio
{
    partial class ConsultarNombre
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
            this.label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.GroupBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txEdad = new System.Windows.Forms.TextBox();
            this.txRaza = new System.Windows.Forms.TextBox();
            this.txIdTipo = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, -33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONSULTAR MASCOTA";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.btBuscar);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.txNombre);
            this.Panel.Location = new System.Drawing.Point(46, 107);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(412, 117);
            this.Panel.TabIndex = 38;
            this.Panel.TabStop = false;
            this.Panel.Text = "Consultar Mascota";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(125, 280);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.ReadOnly = true;
            this.txCodigo.Size = new System.Drawing.Size(100, 20);
            this.txCodigo.TabIndex = 16;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(256, 31);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(78, 27);
            this.btBuscar.TabIndex = 15;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(125, 472);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 37;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(125, 433);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 36;
            // 
            // txEdad
            // 
            this.txEdad.Location = new System.Drawing.Point(125, 397);
            this.txEdad.Name = "txEdad";
            this.txEdad.ReadOnly = true;
            this.txEdad.Size = new System.Drawing.Size(100, 20);
            this.txEdad.TabIndex = 35;
            // 
            // txRaza
            // 
            this.txRaza.Location = new System.Drawing.Point(125, 361);
            this.txRaza.Name = "txRaza";
            this.txRaza.ReadOnly = true;
            this.txRaza.Size = new System.Drawing.Size(100, 20);
            this.txRaza.TabIndex = 34;
            // 
            // txIdTipo
            // 
            this.txIdTipo.Location = new System.Drawing.Point(125, 321);
            this.txIdTipo.Name = "txIdTipo";
            this.txIdTipo.ReadOnly = true;
            this.txIdTipo.Size = new System.Drawing.Size(100, 20);
            this.txIdTipo.TabIndex = 33;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(84, 41);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "DATOS DE LA MASCOTA";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(283, 534);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(78, 27);
            this.btSalir.TabIndex = 30;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(135, 535);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(78, 27);
            this.btLimpiar.TabIndex = 29;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Raza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "CONSULTAR MASCOTA";
            // 
            // ConsultarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 612);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txEdad);
            this.Controls.Add(this.txRaza);
            this.Controls.Add(this.txIdTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarNombre";
            this.Text = "ConsultarNombre";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Panel;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txEdad;
        private System.Windows.Forms.TextBox txRaza;
        private System.Windows.Forms.TextBox txIdTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}