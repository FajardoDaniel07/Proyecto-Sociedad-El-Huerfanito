namespace ElHUerfanitoEscritorio
{
    partial class Login
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
            this.txClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.GroupBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "LOGIN";
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(93, 85);
            this.txClave.Name = "txClave";
            this.txClave.Size = new System.Drawing.Size(100, 20);
            this.txClave.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(256, 31);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(78, 74);
            this.btLogin.TabIndex = 15;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(93, 38);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(100, 20);
            this.txUsuario.TabIndex = 16;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.txUsuario);
            this.Panel.Controls.Add(this.btLogin);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.txClave);
            this.Panel.Location = new System.Drawing.Point(83, 97);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(412, 159);
            this.Panel.TabIndex = 40;
            this.Panel.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.GroupBox Panel;

    }
}