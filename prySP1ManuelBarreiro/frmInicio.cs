﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1ManuelBarreiro
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
    private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmLogin VentanaLogin = new frmLogin();
            VentanaLogin.ShowDialog();
        }

        
    }
}
