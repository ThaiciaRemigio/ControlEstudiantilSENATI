using ControlEstudiantilSENATI.Datos;

using ControlEstudiantilSENATI.Entidades;

using System;

using System.Data;

using System.Linq;

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


/*
        // =========================

        // MOSTRAR

        // =========================

        private void BTNMOSTRAR_Click(object sender, EventArgs e)

        {

            dgvEstudiantes.DataSource = dal.ListarEstudiantes();

        }



        // =========================

        // GUARDAR

        // =========================
        /*
        private void BTNGUARDAR_Click(object sender, EventArgs e)

        {

            if (!Validar()) return;


            
            Estudiante e1 = new Estudiante()

            {
                
                Dni = txtDni.Text,

                Nombres = txtNombres.Text,

                Apellidos = txtApellidos.Text,

                FechaNacimiento = dtpFechaNacimiento.Value,

                Edad = string.IsNullOrEmpty(txtEdad.Text) ? 0 : Convert.ToInt32(txtEdad.Text),

                Correo1 = txtCorreo1.Text,

                Correo2 = txtCorreo2.Text,

                Telefono1 = txtTelf1.Text,

                Telefono2 = txtTelf2.Text,



                IdGenero = Convert.ToInt32(cmbGenero.SelectedValue),

                IdDistrito = Convert.ToInt32(cmbDistrito.SelectedValue),

                IdProcedencia = Convert.ToInt32(cmbProcedencia.SelectedValue),

                IdCondicion = Convert.ToInt32(cmbCondicion.SelectedValue),

                IdApoderado = Convert.ToInt32(cmbApoderado.SelectedValue),

            };
                


            MessageBox.Show(dal.InsertarEstudiante(e1));

            dgvEstudiantes.DataSource = dal.ListarEstudiantes();

            Limpiar();

        }

                */

        // =========================

        // MODIFICAR

        // =========================

        private void BTNMODIFICAR_Click(object sender, EventArgs e)

        {

            if (idEstudiante == 0)

            {

                MessageBox.Show("Selecciona un estudiante");

                return;

            }



           /* if (!Validar()) return;*/


            /*
            Estudiante e1 = new Estudiante()
            
            {

                IdEstudiante = idEstudiante,

                Dni = txtDni.Text,

                Nombres = txtNombres.Text,

                Apellidos = txtApellidos.Text,

                FechaNacimiento = dtpFechaNacimiento.Value,

                Edad = string.IsNullOrEmpty(txtEdad.Text) ? 0 : Convert.ToInt32(txtEdad.Text),

                Correo1 = txtCorreo1.Text,

                Correo2 = txtCorreo2.Text,

                Telefono1 = txtTelf1.Text,

                Telefono2 = txtTelf2.Text,



                IdGenero = Convert.ToInt32(cmbGenero.SelectedValue),

                IdDistrito = Convert.ToInt32(cmbDistrito.SelectedValue),

                IdProcedencia = Convert.ToInt32(cmbProcedencia.SelectedValue),

                IdCondicion = Convert.ToInt32(cmbCondicion.SelectedValue),

                IdApoderado = Convert.ToInt32(cmbApoderado.SelectedValue),

            };
            


            MessageBox.Show(dal.ModificarEstudiante(e1));

            dgvEstudiantes.DataSource = dal.ListarEstudiantes();

            Limpiar();

        }
        */


        // =========================

        // ELIMINAR

        // =========================

        private void BTNELIMINAR_Click(object sender, EventArgs e)

        {

            if (idEstudiante == 0)

            {

                MessageBox.Show("Selecciona un estudiante");

                return;

            }



            DialogResult r = MessageBox.Show(

              "¿Eliminar estudiante?",

              "Confirmar",

              MessageBoxButtons.YesNo,

              MessageBoxIcon.Question);



            if (r == DialogResult.Yes)

            {

                MessageBox.Show(dal.EliminarEstudiante(idEstudiante));

                dgvEstudiantes.DataSource = dal.ListarEstudiantes();

                Limpiar();

            }

        }



        // =========================

        // VALIDAR

        // =========================
        /*
        private bool Validar()

        {

            if (txtDni.Text.Length != 8 || !txtDni.Text.All(char.IsDigit))

            {

                MessageBox.Show("DNI inválido");

                return false;

            }



            if (txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "")

            {

                MessageBox.Show("Ingrese nombres y apellidos");

                return false;

            }



            if (!int.TryParse(txtEdad.Text, out _))

            {

                MessageBox.Show("Edad inválida");

                return false;

            }  
                    


            
            if (cmbGenero.SelectedValue == null ||

              cmbDistrito.SelectedValue == null ||

              cmbProcedencia.SelectedValue == null ||

              cmbCondicion.SelectedValue == null ||

              cmbApoderado.SelectedValue == null)

            {
            
                MessageBox.Show("Seleccione todos los campos obligatorios");

                return false;

            }



            return true;

        }
          */


        // =========================

        // LIMPIAR

        // =========================
        /*
        private void Limpiar()
            
        {

            txtDni.Clear();

            txtNombres.Clear();

            txtApellidos.Clear();

            txtEdad.Clear();

            txtCorreo1.Clear();

            txtCorreo2.Clear();

            txtTelf1.Clear();

            txtTelf2.Clear();



            cmbGenero.SelectedIndex = -1;

            cmbDistrito.SelectedIndex = -1;

            cmbProcedencia.SelectedIndex = -1;

            cmbCondicion.SelectedIndex = -1;

            cmbApoderado.SelectedIndex = -1;



            dtpFechaNacimiento.Value = DateTime.Now;



            idEstudiante = 0;

            dgvEstudiantes.ClearSelection();

        }

        */

        // =========================

        // CARGAR DATOS GRID

        // =========================

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
            
        {

            if (e.RowIndex < 0) return;



            DataGridViewRow fila = dgvEstudiantes.Rows[e.RowIndex];



            idEstudiante = Convert.ToInt32(fila.Cells["id_estudiante"].Value);



            txtDni.Text = fila.Cells["dni"].Value.ToString();

            txtNombres.Text = fila.Cells["nombres"].Value.ToString();

            txtApellidos.Text = fila.Cells["apellidos"].Value.ToString();

            /*txtEdad.Text = fila.Cells["edad"].Value.ToString();*/

            txtCorreo1.Text = fila.Cells["correo1"].Value.ToString();

            txtCorreo2.Text = fila.Cells["correo2"].Value.ToString();

            txtTelf1.Text = fila.Cells["telefono1"].Value.ToString();

            txtTelf2.Text = fila.Cells["telefono2"].Value.ToString();



            cmbGenero.SelectedValue = fila.Cells["id_genero"].Value;

            /*cmbDistrito.SelectedValue = fila.Cells["id_distrito"].Value;

            cmbProcedencia.SelectedValue = fila.Cells["id_procedencia"].Value;

            cmbCondicion.SelectedValue = fila.Cells["id_condicion"].Value;

            cmbApoderado.SelectedValue = fila.Cells["id_apoderado"].Value;*/



            if (fila.Cells["fecha_nacimiento"].Value != DBNull.Value)

            {

                /*dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value);*/

            }

        }

        

        // =========================

        // BOTÓN CERRAR

        // =========================

        private void BTNCERRAR_Click(object sender, EventArgs e)

        {

            Close();

        }

    }

}*/