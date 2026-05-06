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
    public partial class Form2_Matricula : Form
    {
        public Form2_Matricula()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Matricula_Load(object sender, EventArgs e)
        {

        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
            "¿Quieres cerrar el formulario?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
             );

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
