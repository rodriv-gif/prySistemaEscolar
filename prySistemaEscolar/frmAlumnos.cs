using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmAlumnos : Form
    {
        int idMatricula;
        int idUsuario;
        clsAlumnos alumnos;
        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
            CargarCombos();
        }
        //Metodo para cargar el datagridView
        public void CargarGrid()
        {
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                //Asignamos la tabla virtual de la clase directamente al control visual
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
                dgvAlumnos.Columns["usuario"].Visible = false;
                dgvAlumnos.Columns["vchpassword"].Visible = false;
                dgvAlumnos.Columns["Perfil"].Visible = false;
                dgvAlumnos.Columns["direccion"].Visible = false;
                dgvAlumnos.Columns["correo"].Visible = false;
                dgvAlumnos.Columns["telefono"].Visible = false;
                dgvAlumnos.Columns["promedioBachillerato"].Visible = false;
                dgvAlumnos.Columns["idTutor"].Visible = false;
                dgvAlumnos.Columns["idCarrera"].Visible = false;
                dgvAlumnos.Columns["idUsuario"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarCombos()
        {
            alumnos = new clsAlumnos();
            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();
                //Creamos la fila del placeholder para la carrera
                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["idCarrera"] = 0;
                filaPCarrera["nombreCarrera"] = "--Seleccione una carrera--";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0);  //Insertar al inicio de la lista

                //Enlazamos los datos al combobox visual de carreras
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMember = "nombreCarrera"; //El texto visible
                cmbCarrera.ValueMember = "idCarrera";       //La llave primaria real
                cmbCarrera.SelectedIndex = 0;               //Forzar a que muestre el placeHolder

                DataTable dtTutores = alumnos.ObtenerTutores();
                //Creamos la fila del placeholder para la carrera
                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutor"] = 0;
                filaPTutores["nombreTutor"] = "--Seleccione un tutor--";
                dtTutores.Rows.InsertAt(filaPTutores, 0);  //Insertar al inicio de la lista

                //Enlazamos los datos al combobox visual de tutores
                cmbTutor.DataSource = dtTutores;
                cmbTutor.DisplayMember = "nombreTutor"; //El texto visible
                cmbTutor.ValueMember = "idTutor";       //La llave primaria real
                cmbTutor.SelectedIndex = 0;               //Forzar a que muestre el placeHolder
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al rellenar los catálogos en los menús despegables: " + ex.Message);
            }
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //esto es para poder saber si es nuevo o vamos a actualizar
                idMatricula = int.Parse(dgvAlumnos.CurrentRow.Cells["Matricula"].Value.ToString());
                idUsuario = int.Parse(dgvAlumnos.CurrentRow.Cells["idUsuario"].Value.ToString());

                //esto es para la tabla alumnos
                txtMatricula.Text = idMatricula.ToString();
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Paterno"].Value.ToString();
                txtAMaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Materno"].Value.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["direccion"].Value.ToString();
                txtTelefono.Text = dgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvAlumnos.CurrentRow.Cells["correo"].Value.ToString();
                txtPromedioBachiller.Text = dgvAlumnos.CurrentRow.Cells["promedioBachillerato"].Value.ToString();

                //esto es para la tabla Usuarios
                txtUsuario.Text = dgvAlumnos.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvAlumnos.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvAlumnos.CurrentRow.Cells["Perfil"].Value.ToString();

                //usar selected value para apuntar al dato precisode cada registro
                cmbCarrera.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idCarrera"].Value.ToString());
                cmbTutor.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idTutor"].Value.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idMatricula = 0;
            idUsuario = 0;
            alumnos.LimpiarPanel(pnlAlumno);
            alumnos.LimpiarPanel(pnlUsuario);
            txtMatricula.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatriculaAlumno.Text))
            {
                CargarGrid();
                return;
            }
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                alumnos.Matricula = int.Parse(txtMatriculaAlumno.Text);
                dgvAlumnos.DataSource = alumnos.Consultar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos" + ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idMatricula == 0 ? 0 : 1;

                alumnos = new clsAlumnos();

                alumnos.Matricula = int.Parse(txtMatricula.Text);
                alumnos.NombreAlumno = string.IsNullOrEmpty(txtNombre.Text)?null:txtNombre.Text;
                alumnos.ApellidoP = string.IsNullOrEmpty(txtAPaterno.Text)?null:txtAPaterno.Text;
                alumnos.ApellidoM = string.IsNullOrEmpty(txtAMaterno.Text)?null:txtAMaterno.Text;
                alumnos.Direccion = string.IsNullOrEmpty(txtDireccion.Text)? null:txtDireccion.Text;
                alumnos.Telefono = string.IsNullOrEmpty(txtTelefono.Text) ? null:txtTelefono.Text;
                alumnos.Correo = string.IsNullOrEmpty(txtCorreo.Text) ? null:txtCorreo.Text;
                alumnos.PromedioBachillerato = string.IsNullOrEmpty(txtPromedioBachiller.Text)? 0 : decimal.Parse(txtPromedioBachiller.Text);
                alumnos.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                alumnos.IdTutor = Convert.ToInt32(cmbTutor.SelectedValue);

                //Propiedades del bloqueo de usuario
                alumnos.IdUsuario = idUsuario;
                alumnos.NombreUsuario = string.IsNullOrEmpty(txtUsuario.Text)?null:txtUsuario.Text;
                alumnos.Password = string.IsNullOrEmpty(txtPassword.Text)?null:txtPassword.Text;
                alumnos.Perfil = cmbPerfil.Text;

                string msg = "";

                //confirmacion de carrera
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que desea actualizar los datos de este alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = alumnos.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    msg = alumnos.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estas completamente seguro de eliminar permanentemente al alumno con matricula: {idMatricula}?\nEsta acción borrará tambien la cuenta de usuario.",
                "¡ADVERTENCIA!", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {

                try
                {
                    alumnos = new clsAlumnos();

                    alumnos.Matricula = idMatricula;
                    alumnos.IdUsuario = idUsuario;

                    string resultado = alumnos.Eliminar();

                    MessageBox.Show(resultado,"Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrión un error al intentar eliminar el registro: " + ex.Message,
                                    "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
