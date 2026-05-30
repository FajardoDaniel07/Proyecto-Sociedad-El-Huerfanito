namespace ElHUerfanitoEscritorio
{
    partial class RealizarAdopcion
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
            this.Panel = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txTel = new System.Windows.Forms.TextBox();
            this.txNombreAdop = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAdoptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDire = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.txIdAdop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbEstadoAdop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txIdAdopcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.cbEstado);
            this.Panel.Controls.Add(this.txCodigo);
            this.Panel.Controls.Add(this.btBuscar);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.txNombre);
            this.Panel.Location = new System.Drawing.Point(40, 99);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(412, 159);
            this.Panel.TabIndex = 37;
            this.Panel.TabStop = false;
            this.Panel.Text = "Consultar Mascota";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(93, 123);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 32;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(93, 38);
            this.txCodigo.Name = "txCodigo";
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
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Estado:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(93, 85);
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 31;
            // 
            // txTel
            // 
            this.txTel.Location = new System.Drawing.Point(119, 389);
            this.txTel.Name = "txTel";
            this.txTel.Size = new System.Drawing.Size(100, 20);
            this.txTel.TabIndex = 34;
            // 
            // txNombreAdop
            // 
            this.txNombreAdop.Location = new System.Drawing.Point(119, 353);
            this.txNombreAdop.Name = "txNombreAdop";
            this.txNombreAdop.Size = new System.Drawing.Size(100, 20);
            this.txNombreAdop.TabIndex = 33;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(312, 684);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(78, 27);
            this.btSalir.TabIndex = 29;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAdoptar
            // 
            this.btAdoptar.Location = new System.Drawing.Point(61, 684);
            this.btAdoptar.Name = "btAdoptar";
            this.btAdoptar.Size = new System.Drawing.Size(78, 27);
            this.btAdoptar.TabIndex = 28;
            this.btAdoptar.Text = "Adoptar";
            this.btAdoptar.UseVisualStyleBackColor = true;
            this.btAdoptar.Click += new System.EventHandler(this.btAdoptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONSULTAR MASCOTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "DATOS ADOPTANTE";
            // 
            // txDire
            // 
            this.txDire.Location = new System.Drawing.Point(119, 428);
            this.txDire.Name = "txDire";
            this.txDire.Size = new System.Drawing.Size(100, 20);
            this.txDire.TabIndex = 39;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(188, 684);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(78, 27);
            this.btLimpiar.TabIndex = 64;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // txIdAdop
            // 
            this.txIdAdop.Location = new System.Drawing.Point(119, 315);
            this.txIdAdop.Name = "txIdAdop";
            this.txIdAdop.Size = new System.Drawing.Size(100, 20);
            this.txIdAdop.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Id Adoptante: ";
            // 
            // txFecha
            // 
            this.txFecha.Location = new System.Drawing.Point(119, 557);
            this.txFecha.Name = "txFecha";
            this.txFecha.Size = new System.Drawing.Size(100, 20);
            this.txFecha.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Fecha:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(127, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 32);
            this.label11.TabIndex = 72;
            this.label11.Text = "ADOPCION";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 598);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Estado: ";
            // 
            // cbEstadoAdop
            // 
            this.cbEstadoAdop.FormattingEnabled = true;
            this.cbEstadoAdop.Items.AddRange(new object[] {
            "Activa",
            "Cancelada",
            "Fibalizada"});
            this.cbEstadoAdop.Location = new System.Drawing.Point(119, 598);
            this.cbEstadoAdop.Name = "cbEstadoAdop";
            this.cbEstadoAdop.Size = new System.Drawing.Size(105, 21);
            this.cbEstadoAdop.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 77;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txIdAdopcion
            // 
            this.txIdAdopcion.Location = new System.Drawing.Point(119, 521);
            this.txIdAdopcion.Name = "txIdAdopcion";
            this.txIdAdopcion.Size = new System.Drawing.Size(100, 20);
            this.txIdAdopcion.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Id Adopcion:";
            // 
            // RealizarAdopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 774);
            this.Controls.Add(this.txIdAdopcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEstadoAdop);
            this.Controls.Add(this.txFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txIdAdop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.txDire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.txTel);
            this.Controls.Add(this.txNombreAdop);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAdoptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "RealizarAdopcion";
            this.Text = "Realizar Adopcion";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Panel;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txTel;
        private System.Windows.Forms.TextBox txNombreAdop;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAdoptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDire;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txIdAdop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbEstadoAdop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txIdAdopcion;
        private System.Windows.Forms.Label label12;
    }
}