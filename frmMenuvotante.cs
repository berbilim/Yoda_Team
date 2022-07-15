using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace proyecto
{
    public partial class frmMenuvotante : Form
    {
        public frmMenuvotante()
        {
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form formularioprincipal = new frmPrincipal();
            formularioprincipal.Show();
            this.Hide();
        }

       

        
        //Validacion de controles checkbox para que solo se pueda marcar uno
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            chk2.Checked = !chk1.Checked;
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            chk1.Checked = !chk2.Checked;
        }

        private void chk3_CheckStateChanged(object sender, EventArgs e)
        {
            chk4.Checked = !chk3.Checked;
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            chk3.Checked = !chk4.Checked;
        }

        private void frmMenuvotante_Load(object sender, EventArgs e)
        {

        }      


        //Medoto para enviar los parametros a la clase validavoto
        public void enviar()
        {
            Boolean opcion1 = chk1.Checked;
            Boolean opcion2 = chk2.Checked;
            Boolean opcion3 = chk3.Checked;
            Boolean opcion4 = chk4.Checked;

            validavoto enviarDatos = new validavoto(opcion1, opcion2, opcion3, opcion4);


            MessageBox.Show(enviarDatos.conteovotos(),"Resuldado");
        }

        //Invocacion del metodo enviar con el boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            enviar();
        }

        // Insercion de Manual de Uusario
        private void btnManual_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\P-13-07-2022\proyecto\proyecto\manualusuario.pdf");
        }
    }
}
 