namespace prySistemaEscolar
{
    partial class frmPrincipal
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
            pcbMenu = new PictureBox();
            pcbTitulo = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbDocentes = new PictureBox();
            pcbUsuarios = new PictureBox();
            pnlContenedor = new Panel();
            pcbSalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.Image = Properties.Resources.Imagen1;
            pcbMenu.Location = new Point(23, 25);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(407, 1000);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbTitulo
            // 
            pcbTitulo.Image = Properties.Resources.Imagen4;
            pcbTitulo.Location = new Point(493, 12);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(1333, 163);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 1;
            pcbTitulo.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.Image = Properties.Resources.Imagen5;
            pcbAlumnos.Location = new Point(77, 171);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(305, 101);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 2;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
            pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = Properties.Resources.Imagen6;
            pcbCarreras.Location = new Point(77, 347);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(271, 101);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.Click += pcbCarreras_Click;
            pcbCarreras.MouseDown += pcbGeneral_MouseDown;
            pcbCarreras.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbDocentes
            // 
            pcbDocentes.Image = Properties.Resources.Imagen7;
            pcbDocentes.Location = new Point(77, 519);
            pcbDocentes.Name = "pcbDocentes";
            pcbDocentes.Size = new Size(305, 102);
            pcbDocentes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocentes.TabIndex = 4;
            pcbDocentes.TabStop = false;
            pcbDocentes.MouseDown += pcbGeneral_MouseDown;
            pcbDocentes.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = Properties.Resources.Imagen8;
            pcbUsuarios.Location = new Point(77, 683);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(315, 100);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 5;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.MouseDown += pcbGeneral_MouseDown;
            pcbUsuarios.MouseUp += pcbGeneral_MouseUp;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(255, 224, 192);
            pnlContenedor.Location = new Point(493, 192);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1333, 756);
            pnlContenedor.TabIndex = 6;
            // 
            // pcbSalir
            // 
            pcbSalir.Image = Properties.Resources.Imagen9;
            pcbSalir.Location = new Point(77, 848);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(305, 100);
            pcbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSalir.TabIndex = 7;
            pcbSalir.TabStop = false;
            pcbSalir.MouseDown += pcbGeneral_MouseDown;
            pcbSalir.MouseUp += pcbGeneral_MouseUp;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1920, 1051);
            Controls.Add(pcbSalir);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbUsuarios);
            Controls.Add(pcbDocentes);
            Controls.Add(pcbCarreras);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbMenu);
            Name = "frmPrincipal";
            Text = "Sistema Escolar";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbTitulo;
        private PictureBox pcbAlumnos;
        private PictureBox pcbCarreras;
        private PictureBox pcbDocentes;
        private PictureBox pcbUsuarios;
        private Panel pnlContenedor;
        private PictureBox pcbSalir;
    }
}