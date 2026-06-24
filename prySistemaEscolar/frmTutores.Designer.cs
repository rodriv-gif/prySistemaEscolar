namespace prySistemaEscolar
{
    partial class frmTutores
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
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtNombreCompleto = new TextBox();
            dgvTutor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutor).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._10491839;
            pictureBox1.Location = new Point(711, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(462, 64);
            label1.Name = "label1";
            label1.Size = new Size(244, 81);
            label1.TabIndex = 1;
            label1.Text = "Tutores";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtParentesco);
            panel1.Controls.Add(txtNombreCompleto);
            panel1.Location = new Point(96, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 304);
            panel1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(716, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 73);
            btnEliminar.TabIndex = 7;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(458, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 73);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(225, 217);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(135, 73);
            btnNuevo.TabIndex = 5;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(289, 174);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribir correo";
            txtCorreo.Size = new Size(500, 27);
            txtCorreo.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(289, 131);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribir el número de telefono";
            txtTelefono.Size = new Size(500, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(289, 89);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribir la direccion";
            txtDireccion.Size = new Size(500, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtParentesco
            // 
            txtParentesco.Location = new Point(289, 45);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribir el parentesco";
            txtParentesco.Size = new Size(500, 27);
            txtParentesco.TabIndex = 1;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(289, 3);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Escribir el nombre del tutor";
            txtNombreCompleto.Size = new Size(500, 27);
            txtNombreCompleto.TabIndex = 0;
            // 
            // dgvTutor
            // 
            dgvTutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutor.Location = new Point(269, 460);
            dgvTutor.Name = "dgvTutor";
            dgvTutor.RowHeadersWidth = 51;
            dgvTutor.Size = new Size(855, 188);
            dgvTutor.TabIndex = 3;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cuadro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 709);
            Controls.Add(dgvTutor);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox txtParentesco;
        private TextBox txtNombreCompleto;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtCorreo;
        private DataGridView dgvTutor;
    }
}