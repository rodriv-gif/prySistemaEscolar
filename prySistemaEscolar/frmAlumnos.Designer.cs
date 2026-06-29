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
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(422, 107);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(300, 27);
            txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(422, 166);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.ImeMode = ImeMode.Hiragana;
            textBox3.Location = new Point(406, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(345, 27);
            textBox3.TabIndex = 2;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 709);
            Controls.Add(textBox3);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Name = "frmAlumnos";
            Text = "Registro de alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox textBox3;
    }
}