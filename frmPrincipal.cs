using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {            
            Form formularioLoginadmin = new frmLoginadmin();
            formularioLoginadmin.Show();
            this.Hide();
        }       
        private void btnIngresarvotante_Click(object sender, EventArgs e)
        {
            enviarIngreso();
        }
        public void enviarIngreso()
        {
            string usuario = txtCedula.Text;
            string contrasena = txtcontrasena.Text;

            Validaingreso enviarDatos2 = new Validaingreso(usuario, contrasena);

           // enviarDatos2.Ingreso();
        }         
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form formularioregistro = new frmRegistro();
            formularioregistro.Show();
            this.Show();
        }
    }
}
