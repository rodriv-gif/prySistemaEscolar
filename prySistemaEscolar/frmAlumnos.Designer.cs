namespace prySistemaEscolar
{
    partial class frmAlumnos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtBuscar = new TextBox();
            dgvTutor = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            pnlAlumno = new Panel();
            cmbCarrera = new ComboBox();
            cmbTutor = new ComboBox();
            txtPromedioBachiller = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtAMaterno = new TextBox();
            txtAPaterno = new TextBox();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTutor).BeginInit();
            panel2.SuspendLayout();
            pnlAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(820, 464);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(328, 34);
            txtBuscar.TabIndex = 28;
            // 
            // dgvTutor
            // 
            dgvTutor.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.PeachPuff;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTutor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTutor.Location = new Point(61, 504);
            dgvTutor.Name = "dgvTutor";
            dgvTutor.RowHeadersWidth = 51;
            dgvTutor.Size = new Size(1087, 177);
            dgvTutor.TabIndex = 27;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(852, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 73);
            btnEliminar.TabIndex = 26;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(594, 377);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 73);
            btnGuardar.TabIndex = 25;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(361, 377);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(135, 73);
            btnNuevo.TabIndex = 24;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(684, 22);
            label2.Name = "label2";
            label2.Size = new Size(97, 31);
            label2.TabIndex = 23;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(127, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 20;
            label1.Text = "Alumno";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbPerfil);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(684, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 315);
            panel2.TabIndex = 22;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(26, 125);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(401, 39);
            cmbPerfil.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(26, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(401, 38);
            txtPassword.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(26, 39);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(401, 38);
            txtUsuario.TabIndex = 1;
            // 
            // pnlAlumno
            // 
            pnlAlumno.Controls.Add(cmbCarrera);
            pnlAlumno.Controls.Add(cmbTutor);
            pnlAlumno.Controls.Add(txtPromedioBachiller);
            pnlAlumno.Controls.Add(txtCorreo);
            pnlAlumno.Controls.Add(txtTelefono);
            pnlAlumno.Controls.Add(txtDireccion);
            pnlAlumno.Controls.Add(txtAMaterno);
            pnlAlumno.Controls.Add(txtAPaterno);
            pnlAlumno.Controls.Add(txtNombre);
            pnlAlumno.Controls.Add(txtMatricula);
            pnlAlumno.Location = new Point(39, 56);
            pnlAlumno.Name = "pnlAlumno";
            pnlAlumno.Size = new Size(610, 315);
            pnlAlumno.TabIndex = 21;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(322, 216);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(277, 39);
            cmbCarrera.TabIndex = 11;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(322, 171);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(277, 39);
            cmbTutor.TabIndex = 10;
            // 
            // txtPromedioBachiller
            // 
            txtPromedioBachiller.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPromedioBachiller.ImeMode = ImeMode.Hiragana;
            txtPromedioBachiller.Location = new Point(322, 127);
            txtPromedioBachiller.Name = "txtPromedioBachiller";
            txtPromedioBachiller.Size = new Size(277, 38);
            txtPromedioBachiller.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCorreo.ImeMode = ImeMode.Hiragana;
            txtCorreo.Location = new Point(322, 83);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(277, 38);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTelefono.ImeMode = ImeMode.Hiragana;
            txtTelefono.Location = new Point(322, 39);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(277, 38);
            txtTelefono.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtDireccion.ImeMode = ImeMode.Hiragana;
            txtDireccion.Location = new Point(22, 214);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(277, 38);
            txtDireccion.TabIndex = 4;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAMaterno.ImeMode = ImeMode.Hiragana;
            txtAMaterno.Location = new Point(22, 170);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(277, 38);
            txtAMaterno.TabIndex = 3;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAPaterno.ImeMode = ImeMode.Hiragana;
            txtAPaterno.Location = new Point(22, 126);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(277, 38);
            txtAPaterno.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNombre.Location = new Point(22, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 38);
            txtNombre.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtMatricula.Location = new Point(22, 39);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(277, 38);
            txtMatricula.TabIndex = 0;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 709);
            Controls.Add(txtBuscar);
            Controls.Add(dgvTutor);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pnlAlumno);
            Name = "frmAlumnos";
            Text = "Registro de alumnos";
            ((System.ComponentModel.ISupportInitialize)dgvTutor).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private DataGridView dgvTutor;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Panel pnlAlumno;
        private ComboBox cmbCarrera;
        private ComboBox cmbTutor;
        private TextBox txtPromedioBachiller;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtAMaterno;
        private TextBox txtAPaterno;
        private TextBox txtNombre;
        private TextBox txtMatricula;
    }
}