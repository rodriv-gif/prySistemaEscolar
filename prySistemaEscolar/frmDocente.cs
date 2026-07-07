using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmDocente : Form
    {
        clsDocente docentes;
        int idClave;
        int idUsuario;
        public frmDocente()
        {
            InitializeComponent();
            cargarGrid();
        }
        public void cargarGrid()
        {
            docentes = new clsDocente();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvDocentes.DataSource = docentes.CargarDataGrid();
                dgvDocentes.Columns["idUsuario"].Visible = false;
                dgvDocentes.Columns["Usuario"].Visible = false;
                dgvDocentes.Columns["Password"].Visible = false;
                dgvDocentes.Columns["Perfil"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
