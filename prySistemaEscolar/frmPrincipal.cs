using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbGeneral_MouseDown(object mipictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }

        private void pcbGeneral_MouseUp(object mipictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        
            //cambiando el parent de los picture
            pcbAlumnos.Parent = pcbMenu;
            pcbCarreras.Parent = pcbMenu;
            pcbDocentes.Parent = pcbMenu;
            pcbUsuarios.Parent = pcbMenu;
            pcbSalir.Parent = pcbMenu;

            pcbAlumnos.BackColor = Color.Transparent;
            pcbCarreras.BackColor = Color.Transparent;
            pcbDocentes.BackColor = Color.Transparent;
            pcbUsuarios.BackColor = Color.Transparent;
            pcbSalir.BackColor = Color.Transparent;

            //verificando permisos
            pcbCarreras.Enabled = clsLogin.EsAdministrador;
            pcbDocentes.Enabled = clsLogin.EsAdministrador;
            pcbUsuarios.Enabled = clsLogin.EsAdministrador;

            pcbAlumnos.Enabled = clsLogin.EsAdministrador || clsLogin.EsDocente;

        }

        private void pcbCarreras_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmCarreras(),pnlContenedor);
        }
    }
}
