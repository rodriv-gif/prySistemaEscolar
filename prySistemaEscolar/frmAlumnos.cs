using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmAlumnos : Form
    {
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarCombos()
        {
            alumnos= new clsAlumnos();
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

                MessageBox.Show("Error al rellenar los catálogos en los menús despegables: "+ex.Message);
            }
        }
    }
}
