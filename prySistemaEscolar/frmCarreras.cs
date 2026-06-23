using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmCarreras : Form
    {
        clscarreras carreras;
        int idCarreras;
        public frmCarreras()
        {
            InitializeComponent();
            CargarGrid();

        }
        public void CargarGrid()
        {
            carreras = new clscarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvCarreras.DataSource = carreras.CargarDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carreras = new clscarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                carreras.NombreCarrera = txtNombreCarrera.Text;
                dgvCarreras.DataSource = carreras.Consultar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {
            //Campo oculto que sirve de referencia para actualizar y eliminar
            idCarreras = int.Parse(dgvCarreras.CurrentRow.Cells[0].Value.ToString());
            //estas son visuales
            txtNombre.Text = dgvCarreras.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvCarreras.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                int tipoOperacion = idCarreras == 0 ? 0 : 1;
                carreras.IdCarrera = idCarreras;
                carreras.NombreCarrera = txtNombre.Text;
                carreras.Descripcion = txtDescripcion.Text;
                string msj="";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("comfirmar que se desea actualizar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {

                        msj = carreras.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msj);
                    }

                }
                else
                {
                    msj = carreras.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msj);
                }
              
                CargarGrid();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idCarreras = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                carreras.IdCarrera = idCarreras;
                var resp = MessageBox.Show("comfirmar que se desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = carreras.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
