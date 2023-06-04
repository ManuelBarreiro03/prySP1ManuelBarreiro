using System;
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
    public partial class frmLogin : Form
    {   //declaracion de variables globales
        string varModulo, varContraseña, varUsuario;
        int varErrores;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            varErrores = 0;
        }

        private void cmdCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length >= 10)
            {
                txtContraseña.Text = txtContraseña.Text.Substring(0, 10);
                txtContraseña.SelectionStart = 10;
            }
            //txtContraseña.Text = new string('#', txtContraseña.Text.Length);

        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            varModulo = lstModulo.Text;
            varContraseña = txtContraseña.Text;
            varUsuario = txtUsuario.Text;


            if (varUsuario == "Adm")
            {
                if (varContraseña == "@1a" && (varModulo == "ADM" || varModulo == "COM" || varModulo == "VTA"))
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña y/o modulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    varErrores++;

                }
            }
            if (varUsuario == "John")
            {
                if (varContraseña == "*2b" && (varModulo == "SIST"))
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    varErrores++;
                    MessageBox.Show("Contraseña y/o modulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (varUsuario == "Ceci")
            {
                if (varContraseña == "*@3c" && (varModulo == "ADM" || varModulo == "VTA"))
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    varErrores++;
                    MessageBox.Show("Contraseña y/o modulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (varUsuario == "God")
                if (varContraseña == "*@#4d" && (varModulo == "SIST" || varModulo == "ADM" || varModulo == "COM" || varModulo == "VTA"))
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    varErrores++;
                    MessageBox.Show("Contraseña y/o modulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (varErrores == 2)
            {
                MessageBox.Show("Demasiados intentos, se cerrará el Inicio de Sesion");
                this.Close();
            }



        }
    }
}
    
        
