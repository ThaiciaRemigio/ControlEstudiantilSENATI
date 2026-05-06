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
    public partial class Form_PinDeSeguridad : Form
    {
        public Form_PinDeSeguridad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void textPIN_TextChanged(object sender, EventArgs e)
        {
            textPIN.Text = new string(textPIN.Text.Where(char.IsDigit).ToArray());
            textPIN.SelectionStart = textPIN.Text.Length;
        }

        private void linkOlvidaste_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de recuperación de PIN próximamante");
        }

        private void BTNCONTINUAR_Click(object sender, EventArgs e)
        {
            string pin = textPIN.Text;

            if (pin.Length != 4)
            {
                MessageBox.Show("El PIN debe tener 4 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí puedes validar el PIN real (ejemplo simple)
            if (pin == "1234") // cambia esto por tu lógica real
            {
                Frm_Login login = new Frm_Login();
                login.Show();

                this.Hide(); // Oculta este formulario
            }
            else
            {
                MessageBox.Show("PIN incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_PinDeSeguridad_Load(object sender, EventArgs e)
        {

        }
    }
}
