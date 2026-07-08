namespace prySistemaEscolar
{
    partial class frmDocente
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvDocentes = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            pnlDocente = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtPuesto = new TextBox();
            txtNombreDocente = new TextBox();
            txtClave = new TextBox();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtClaveDocente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            pnlDocente.SuspendLayout();
            pnlUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Docente;
            pictureBox1.Location = new Point(635, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 18);
            label1.Name = "label1";
            label1.Size = new Size(268, 81);
            label1.TabIndex = 1;
            label1.Text = "Docente";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(124, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(220, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(500, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(220, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(500, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(500, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 27);
            textBox1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(361, 462);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(135, 73);
            btnNuevo.TabIndex = 3;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(591, 460);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 73);
            btnGuardar.TabIndex = 4;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(814, 460);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 73);
            btnEliminar.TabIndex = 5;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvDocentes
            // 
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(48, 575);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.Size = new Size(1091, 162);
            dgvDocentes.TabIndex = 6;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 121);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 7;
            label2.Text = "Docente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(681, 121);
            label3.Name = "label3";
            label3.Size = new Size(97, 31);
            label3.TabIndex = 8;
            label3.Text = "Usuario";
            // 
            // pnlDocente
            // 
            pnlDocente.BackColor = Color.FromArgb(192, 192, 255);
            pnlDocente.Controls.Add(txtCorreo);
            pnlDocente.Controls.Add(txtTelefono);
            pnlDocente.Controls.Add(txtPuesto);
            pnlDocente.Controls.Add(txtNombreDocente);
            pnlDocente.Controls.Add(txtClave);
            pnlDocente.Location = new Point(176, 155);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(428, 301);
            pnlDocente.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(72, 239);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(277, 38);
            txtCorreo.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(72, 182);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(277, 38);
            txtTelefono.TabIndex = 3;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPuesto.Location = new Point(72, 130);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(277, 38);
            txtPuesto.TabIndex = 2;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreDocente.Location = new Point(72, 81);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del docente";
            txtNombreDocente.Size = new Size(277, 38);
            txtNombreDocente.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(72, 29);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(277, 38);
            txtClave.TabIndex = 0;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.FromArgb(192, 192, 255);
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(682, 155);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(457, 301);
            pnlUsuario.TabIndex = 10;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(34, 130);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(401, 39);
            cmbPerfil.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(34, 79);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(401, 38);
            txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(34, 29);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(401, 38);
            txtUsuario.TabIndex = 0;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(810, 535);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar por clave";
            txtClaveDocente.Size = new Size(329, 34);
            txtClaveDocente.TabIndex = 11;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 749);
            Controls.Add(txtClaveDocente);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlDocente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDocentes);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmDocente";
            Text = "frmDocente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            pnlDocente.ResumeLayout(false);
            pnlDocente.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dgvDocentes;
        private Label label2;
        private Label label3;
        private Panel pnlDocente;
        private Panel pnlUsuario;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtPuesto;
        private TextBox txtNombreDocente;
        private TextBox txtClave;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private ComboBox cmbPerfil;
        private TextBox txtClaveDocente;
    }
}