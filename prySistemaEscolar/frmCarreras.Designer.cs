namespace prySistemaEscolar
{
    partial class frmCarreras
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            IblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            txtNombreCarrera = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources._5257117;
            pcbLogo.Location = new Point(511, 44);
            pcbLogo.Margin = new Padding(3, 2, 3, 2);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(100, 65);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // IblTitulo
            // 
            IblTitulo.AutoSize = true;
            IblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblTitulo.Location = new Point(273, 49);
            IblTitulo.Name = "IblTitulo";
            IblTitulo.Size = new Size(214, 65);
            IblTitulo.TabIndex = 1;
            IblTitulo.Text = "Carreras";
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(txtDescripcion);
            pnlAgrupaControles.Controls.Add(txtNombre);
            pnlAgrupaControles.Location = new Point(143, 114);
            pnlAgrupaControles.Margin = new Padding(3, 2, 3, 2);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(682, 176);
            pnlAgrupaControles.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(478, 103);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 64);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(284, 103);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 64);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(116, 103);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(127, 64);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(116, 58);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripción de la carrera ";
            txtDescripcion.Size = new Size(498, 36);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(116, 9);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombre.Size = new Size(498, 36);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Teal;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.Location = new Point(143, 331);
            dgvCarreras.Margin = new Padding(3, 2, 3, 2);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 35;
            dgvCarreras.Size = new Size(682, 104);
            dgvCarreras.TabIndex = 3;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(514, 294);
            txtNombreCarrera.Margin = new Padding(3, 2, 3, 2);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Buscar Carrera";
            txtNombreCarrera.Size = new Size(312, 36);
            txtNombreCarrera.TabIndex = 4;
            txtNombreCarrera.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 478);
            Controls.Add(txtNombreCarrera);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(IblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCarreras";
            Text = "Registro de carreras";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label IblTitulo;
        private Panel pnlAgrupaControles;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvCarreras;
        private TextBox txtNombreCarrera;
    }
}