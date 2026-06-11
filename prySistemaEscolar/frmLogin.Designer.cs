namespace prySistemaEscolar
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pcbLoginFondo = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).BeginInit();
            SuspendLayout();
            // 
            // pcbLoginFondo
            // 
            pcbLoginFondo.Image = Properties.Resources.loginfondo1;
            pcbLoginFondo.Location = new Point(12, 43);
            pcbLoginFondo.Margin = new Padding(3, 2, 3, 2);
            pcbLoginFondo.Name = "pcbLoginFondo";
            pcbLoginFondo.Size = new Size(233, 208);
            pcbLoginFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginFondo.TabIndex = 0;
            pcbLoginFondo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(351, 91);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre del Usuario";
            txtUsuario.Size = new Size(239, 32);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(351, 170);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña del usuario";
            txtPassword.Size = new Size(239, 32);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAcceder.Location = new Point(320, 234);
            btnAcceder.Margin = new Padding(3, 2, 3, 2);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(122, 40);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSalir.Location = new Point(479, 236);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 38);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLoginFondo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Control de acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLoginFondo;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
