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
    public partial class frmDistritos : Form
    {
        public frmDistritos()
        {
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form formularioMenuadmin = new frmMenuadmin();
            formularioMenuadmin.Show();
            this.Hide();
        }
    }
}
