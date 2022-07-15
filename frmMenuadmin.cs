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
    public partial class frmMenuadmin : Form
    {
        public frmMenuadmin()
        {
            InitializeComponent();
        }


        // Incocacion de pantallas
        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioLogin = new frmPrincipal();
            formularioLogin.Show();
            this.Hide();
        }

        private void reportesPorCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formularioreportecandidatos = new frmReportecandidatos();
            formularioreportecandidatos.Show();
            this.Hide();
        }

        private void reportesPorProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioreporteporprovincia = new frmReporteprovincia();
            formularioreporteporprovincia.Show();
            this.Hide();
        }

        private void reportesPorCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariopadron = new frmPadron();
            formulariopadron.Show();
            this.Hide();
        }

        private void reportesPorPartidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariodistritos = new frmDistritos();
            formulariodistritos.Show();
            this.Hide();
        }

        private void modificarProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariocandidatos = new frmCandidatos();
            formulariocandidatos.Show();
            this.Hide();
        }

        private void modificarPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioModpartidos = new frmPartido();
            formularioModpartidos.Show();
            this.Hide();
        }

        private void modificarPuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioModpuesto = new frmPuesto();
            formularioModpuesto.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\P-13-07-2022\proyecto\proyecto\Acerca.pdf");
            
        }

        private void frmMenuadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
