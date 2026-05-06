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
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
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

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Form1_Estudiante ESTUDIANTE = new Form1_Estudiante();
            ESTUDIANTE.Show();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            Form2_Matricula MATRICULA = new Form2_Matricula();
            MATRICULA.Show();
        }

        private void btnApoderados_Click(object sender, EventArgs e)
        {
            Form3_Apoderados APODERADOS = new Form3_Apoderados();
            APODERADOS.Show();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            Form4_Horario HORARIO = new Form4_Horario();
            HORARIO.Show();
        }

        private void btnPlandeEstudios_Click(object sender, EventArgs e)
        {
            Form5_Plan_de_Estudios PAGOS = new Form5_Plan_de_Estudios();
            PAGOS.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Form6_Pagos PAGOS = new Form6_Pagos();
            PAGOS.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form7_Usuarios USUARIOS = new Form7_Usuarios();
            USUARIOS.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Form8_Reportes REPORTES = new Form8_Reportes();
            REPORTES.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Form9_Configuración CONFIG = new Form9_Configuración();
            CONFIG.Show();
        }
    }
}
