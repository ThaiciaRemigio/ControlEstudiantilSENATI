using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEstudiantilSENATI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length < 3)
            {
                txtUsuario.BackColor = Color.LightPink;
            }
            else
            {
                txtUsuario.BackColor = Color.White;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void checkBoxRecordarme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecordarme.Checked)
            {
                Properties.Settings.Default.usuario = txtUsuario.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacte al administrador para recuperar su contraseña");
        }

        private void BTNSESION_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                MessageBox.Show("Bienvenido " + usuario);

                // Abrir otro formulario (ejemplo)
                Frm_MenuPrincipal menu = new Frm_MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
