﻿using System;
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
    public partial class frmPuesto : Form
    {
        public frmPuesto()
        {
            InitializeComponent();
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form formularioMenuadmin = new frmMenuadmin();
            formularioMenuadmin.Show();
            this.Hide();
        }
    }
}
