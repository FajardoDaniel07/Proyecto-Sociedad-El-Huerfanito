namespace ElHUerfanitoEscritorio
{
    partial class RtirarMascota
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
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRetirar = new System.Windows.Forms.Button();
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(154, 98);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(100, 20);
            this.txCodigo.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Codigo:";
            // 
            // btRetirar
            // 
            this.btRetirar.Location = new System.Drawing.Point(77, 376);
            this.btRetirar.Name = "btRetirar";
            this.btRetirar.Size = new System.Drawing.Size(78, 27);
            this.btRetirar.TabIndex = 53;
            this.btRetirar.Text = "Retirar";
            this.btRetirar.UseVisualStyleBackColor = true;
            this.btRetirar.Click += new System.EventHandler(this.btRetirar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Adoptado",
            "Disponible"});
            this.cbEstado.Location = new System.Drawing.Point(154, 323);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 52;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cbSexo.Location = new System.Drawing.Point(154, 286);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 51;
            // 
            // txEdad
            // 
            this.txEdad.Location = new System.Drawing.Point(154, 248);
            this.txEdad.Name = "txEdad";
            this.txEdad.ReadOnly = true;
            this.txEdad.Size = new System.Drawing.Size(100, 20);
            this.txEdad.TabIndex = 50;
            // 
            // txRaza
            // 
            this.txRaza.Location = new System.Drawing.Point(154, 212);
            this.txRaza.Name = "txRaza";
            this.txRaza.ReadOnly = true;
            this.txRaza.Size = new System.Drawing.Size(100, 20);
            this.txRaza.TabIndex = 49;
            // 
            // txIdTipo
            // 
            this.txIdTipo.Location = new System.Drawing.Point(154, 176);
            this.txIdTipo.Name = "txIdTipo";
            this.txIdTipo.ReadOnly = true;
            this.txIdTipo.Size = new System.Drawing.Size(100, 20);
            this.txIdTipo.TabIndex = 48;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(154, 136);
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 32);
            this.label10.TabIndex = 46;
            this.label10.Text = "RETIRAR MASCOTA";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(360, 376);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(78, 27);
            this.btSalir.TabIndex = 45;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(212, 377);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(78, 27);
            this.btLimpiar.TabIndex = 44;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Raza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipo ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nombre:";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(360, 94);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(78, 27);
            this.btBuscar.TabIndex = 56;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // RtirarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRetirar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txEdad);
            this.Controls.Add(this.txRaza);
            this.Controls.Add(this.txIdTipo);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "RtirarMascota";
            this.Text = "Retirar Mascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRetirar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txEdad;
        private System.Windows.Forms.TextBox txRaza;
        private System.Windows.Forms.TextBox txIdTipo;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBuscar;
    }
}