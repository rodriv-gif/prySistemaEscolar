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
            pcbTutor = new PictureBox();
            Ibltitulo = new Label();
            panel1 = new Panel();
            btneliminar = new Button();
            btnguardar = new Button();
            btnnuevo = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dvgTutores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbTutor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbTutor
            // 
            pcbTutor.Image = Properties.Resources._10491839;
            pcbTutor.Location = new Point(727, 58);
            pcbTutor.Name = "pcbTutor";
            pcbTutor.Size = new Size(93, 79);
            pcbTutor.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTutor.TabIndex = 0;
            pcbTutor.TabStop = false;
            // 
            // Ibltitulo
            // 
            Ibltitulo.AutoSize = true;
            Ibltitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ibltitulo.Location = new Point(477, 56);
            Ibltitulo.Name = "Ibltitulo";
            Ibltitulo.Size = new Size(244, 81);
            Ibltitulo.TabIndex = 1;
            Ibltitulo.Text = "Tutores";
            // 
            // panel1
            // 
            panel1.Controls.Add(btneliminar);
            panel1.Controls.Add(btnguardar);
            panel1.Controls.Add(btnnuevo);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(112, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 325);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btneliminar
            // 
            btneliminar.BackgroundImage = Properties.Resources.Eliminar;
            btneliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btneliminar.Location = new Point(703, 246);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(132, 67);
            btneliminar.TabIndex = 7;
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackgroundImage = Properties.Resources.Guardar;
            btnguardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnguardar.Location = new Point(477, 246);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(132, 67);
            btnguardar.TabIndex = 6;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.BackgroundImage = Properties.Resources.Nuevo3;
            btnnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnnuevo.Location = new Point(242, 246);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(132, 67);
            btnnuevo.TabIndex = 5;
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(289, 202);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Escribir correo";
            textBox5.Size = new Size(500, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 154);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Escribir el número de telefono";
            textBox4.Size = new Size(500, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 109);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Escribir la direccion";
            textBox3.Size = new Size(500, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 66);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escribir el parntesco";
            textBox2.Size = new Size(500, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escribir el nombre del tutor";
            textBox1.Size = new Size(500, 27);
            textBox1.TabIndex = 0;
            // 
            // dvgTutores
            // 
            dvgTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTutores.Location = new Point(253, 470);
            dvgTutores.Name = "dvgTutores";
            dvgTutores.RowHeadersWidth = 51;
            dvgTutores.Size = new Size(853, 171);
            dvgTutores.TabIndex = 3;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cuadro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 709);
            Controls.Add(dvgTutores);
            Controls.Add(panel1);
            Controls.Add(Ibltitulo);
            Controls.Add(pcbTutor);
            DoubleBuffered = true;
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pcbTutor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbTutor;
        private Label Ibltitulo;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button btneliminar;
        private Button btnguardar;
        private Button btnnuevo;
        private TextBox textBox5;
        private DataGridView dvgTutores;
    }
}