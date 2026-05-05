using ControlEstudiantilSENATI.Datos;
using ControlEstudiantilSENATI.Entidades;
using System;
using System.Windows.Forms;

namespace ControlEstudiantilSENATI
{
    public partial class Form1_Estudiante : Form
    {
        EstudianteDAL dal = new EstudianteDAL();
        int idEstudiante = 0;


        public Form1_Estudiante()
        {
            InitializeComponent();
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            Estudiante e1 = new Estudiante()
            {
                Dni = textBox9.Text,
                Nombres = textBox8.Text,
                Apellidos = textBox7.Text,
                FechaNacimiento = dateTimePicker2.Value,
                Edad = Convert.ToInt32(textBox1.Text),
                Correo1 = textBox3.Text,
                Correo2 = textBox2.Text,
                Telefono1 = textBox5.Text,
                Telefono2 = textBox4.Text,

                IdGenero = Convert.ToInt32(comboBox5.SelectedValue),
                IdDistrito = Convert.ToInt32(comboBox4.SelectedValue),
                IdProcedencia = Convert.ToInt32(comboBox3.SelectedValue),
                IdCondicion = Convert.ToInt32(comboBox2.SelectedValue),
                IdApoderado = Convert.ToInt32(comboBox1.SelectedValue)
            };

            MessageBox.Show(dal.InsertarEstudiante(e1));
            dgvEstudiantes.DataSource = dal.ListarEstudiantes();
            LimpiarFormulario();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            Estudiante e1 = new Estudiante()
            {
                IdEstudiante = idEstudiante,
                Dni = textBox9.Text,
                Nombres = textBox8.Text,
                Apellidos = textBox7.Text,
                FechaNacimiento = dateTimePicker2.Value,
                Edad = Convert.ToInt32(textBox1.Text),
                Correo1 = textBox3.Text,
                Correo2 = textBox2.Text,
                Telefono1 = textBox5.Text,
                Telefono2 = textBox4.Text,

                IdGenero = Convert.ToInt32(comboBox5.SelectedValue),
                IdDistrito = Convert.ToInt32(comboBox4.SelectedValue),
                IdProcedencia = Convert.ToInt32(comboBox3.SelectedValue),
                IdCondicion = Convert.ToInt32(comboBox2.SelectedValue),
                IdApoderado = Convert.ToInt32(comboBox1.SelectedValue)
            };

            MessageBox.Show(dal.ActualizarEstudiante(e1));
            dgvEstudiantes.DataSource = dal.ListarEstudiantes();
            LimpiarFormulario();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            if (idEstudiante == 0)
            {
                MessageBox.Show("Seleccione un estudiante");
                return;
            }

            Estudiante e1 = new Estudiante()
            {
                IdEstudiante = idEstudiante
            };

            MessageBox.Show(dal.EliminarEstudiante(e1));
            dgvEstudiantes.DataSource = dal.ListarEstudiantes();
            LimpiarFormulario();
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            // DNI
            if (txtDni.Text.Length != 8 || !int.TryParse(txtDni.Text, out _))
                return false;

            // Nombres y Apellidos
            if (txtNombres.Text.Trim() == "")
                return false;

            if (txtApellidos.Text.Trim() == "")
                return false;

            // Edad
            if (txtEdad.Text == "" || !int.TryParse(txtEdad.Text, out _))
                return false;

            // Correo
            if (txtCorreo1.Text == "" || !txtCorreo1.Text.Contains("@"))
                return false;

            // Teléfono
            if (txtTelf1.Text == "" || !int.TryParse(txtTelf1.Text, out _))
                return false;

            // Combos (FK)
            if (cmbGenero.SelectedIndex == -1)
                return false;

            if (cmbDistrito.SelectedIndex == -1)
                return false;

            if (cmbProcedencia.SelectedIndex == -1)
                return false;

            if (cmbCondicion.SelectedIndex == -1)
                return false;

            if (cmbApoderado.SelectedIndex == -1)
                return false;

            return true;
        }
        private void LimpiarFormulario()
        {
            // TextBox
            textBox11.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();

            // DateTime
            dateTimePicker2.Value = DateTime.Now;

            // ComboBox
            comboBox5.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

            // Reset ID
            idEstudiante = 0;
        }

        private void Form1_Estudiante_Load(object sender, EventArgs e)
        {
            // GENERO
            comboBox5.SelectedIndex = -1;
            comboBox5.DataSource = dal.ListarGeneros();
            comboBox5.DisplayMember = "nombre_genero";
            comboBox5.ValueMember = "id_genero";

            // DISTRITO
            comboBox4.SelectedIndex = -1;
            comboBox4.DataSource = dal.ListarDistritos();
            comboBox4.DisplayMember = "nombre_distrito";
            comboBox4.ValueMember = "id_distrito";

            // PROCEDENCIA
            comboBox3.SelectedIndex = -1;
            comboBox3.DataSource = dal.ListarProcedencias();
            comboBox3.DisplayMember = "descripcion";
            comboBox3.ValueMember = "id_procedencia";

            // CONDICION
            comboBox2.SelectedIndex = -1;
            comboBox2.DataSource = dal.ListarCondiciones();
            comboBox2.DisplayMember = "nombre_condicion";
            comboBox2.ValueMember = "id_condicion";

            // APODERADO
            comboBox1.SelectedIndex = -1;
            comboBox1.DataSource = dal.ListarApoderados();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id_apoderado";

        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEstudiante = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["id_estudiante"].Value);

                textBox11.Text = dgvEstudiantes.CurrentRow.Cells["id_estudiante"].Value.ToString();
                textBox9.Text = dgvEstudiantes.CurrentRow.Cells["dni"].Value.ToString();
                textBox8.Text = dgvEstudiantes.CurrentRow.Cells["nombres"].Value.ToString();
                textBox7.Text = dgvEstudiantes.CurrentRow.Cells["apellidos"].Value.ToString();
                textBox1.Text = dgvEstudiantes.CurrentRow.Cells["edad"].Value.ToString();
                textBox3.Text = dgvEstudiantes.CurrentRow.Cells["correo1"].Value.ToString();
                textBox2.Text = dgvEstudiantes.CurrentRow.Cells["correo2"].Value.ToString();
                textBox5.Text = dgvEstudiantes.CurrentRow.Cells["telefono1"].Value.ToString();
                textBox4.Text = dgvEstudiantes.CurrentRow.Cells["telefono2"].Value.ToString();

                comboBox5.Text = dgvEstudiantes.CurrentRow.Cells["nombre_genero"].Value.ToString();
                comboBox4.Text = dgvEstudiantes.CurrentRow.Cells["nombre_distrito"].Value.ToString();
                comboBox3.Text = dgvEstudiantes.CurrentRow.Cells["procedencia"].Value.ToString();
                comboBox2.Text = dgvEstudiantes.CurrentRow.Cells["nombre_condicion"].Value.ToString();
                comboBox1.Text = dgvEstudiantes.CurrentRow.Cells["apoderado"].Value.ToString();


                dateTimePicker2.Value = Convert.ToDateTime(dgvEstudiantes.CurrentRow.Cells["fecha_nacimiento"].Value);
            }
        }

        private void BTNMOSTRAR_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = dal.ListarEstudiantes();
        }

        private void txtEstudiante_TextChanged(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = dal.BuscarEstudiante(txtBuscar.Text);
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

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}