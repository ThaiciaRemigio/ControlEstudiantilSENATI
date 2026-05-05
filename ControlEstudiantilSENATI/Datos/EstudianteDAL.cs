using System;

using System.Data;

using System.Data.SqlClient;

using ControlEstudiantilSENATI.Entidades;



namespace ControlEstudiantilSENATI.Datos

{

    public class EstudianteDAL

    {

        Conexion cn = new Conexion();



        // =========================

        // LISTAR ESTUDIANTES

        // =========================

        public DataTable ListarEstudiantes()

        {

            using (SqlConnection con = cn.GetConexion())

            {

                SqlDataAdapter da = new SqlDataAdapter(

                  "SELECT * FROM vw_Estudiantes", con);



                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }

        }





        // =========================

        // BUSCAR ESTUDIANTE

        // =========================

        public DataTable BuscarEstudiante(string texto)

        {

            using (SqlConnection con = cn.GetConexion())

            {

                SqlDataAdapter da = new SqlDataAdapter(

                  @"SELECT * FROM estudiante

           WHERE nombres LIKE '%' + @texto + '%'

             OR apellidos LIKE '%' + @texto + '%'

             OR dni LIKE '%' + @texto + '%'", con);



                da.SelectCommand.Parameters.AddWithValue("@texto", texto);



                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }

        }



        // =========================

        // INSERTAR ESTUDIANTE

        // =========================

        public string InsertarEstudiante(Estudiante e)

        {

            try

            {

                using (SqlConnection con = cn.GetConexion())

                {

                    SqlCommand cmd = new SqlCommand(

                      @"INSERT INTO estudiante

            (id_distrito, dni, nombres, apellidos, id_genero,

             fecha_nacimiento, edad, correo1, correo2,

             telefono1, telefono2, id_procedencia,

             id_condicion, estado, id_apoderado)

            VALUES

            (@id_distrito, @dni, @nombres, @apellidos, @id_genero,

             @fecha_nacimiento, @edad, @correo1, @correo2,

             @telefono1, @telefono2, @id_procedencia,

             @id_condicion, 1, @id_apoderado)", con);



                    cmd.Parameters.AddWithValue("@id_distrito", e.IdDistrito);

                    cmd.Parameters.AddWithValue("@dni", e.Dni);

                    cmd.Parameters.AddWithValue("@nombres", e.Nombres);

                    cmd.Parameters.AddWithValue("@apellidos", e.Apellidos);

                    cmd.Parameters.AddWithValue("@id_genero", e.IdGenero);

                    cmd.Parameters.AddWithValue("@fecha_nacimiento", e.FechaNacimiento);

                    cmd.Parameters.AddWithValue("@edad", e.Edad);

                    cmd.Parameters.AddWithValue("@correo1", e.Correo1);

                    cmd.Parameters.AddWithValue("@correo2", (object)e.Correo2 ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@telefono1", e.Telefono1);

                    cmd.Parameters.AddWithValue("@telefono2", (object)e.Telefono2 ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@id_procedencia", e.IdProcedencia);

                    cmd.Parameters.AddWithValue("@id_condicion", e.IdCondicion);

                    cmd.Parameters.AddWithValue("@id_apoderado", e.IdApoderado);



                    con.Open();

                    cmd.ExecuteNonQuery();

                }



                return "Estudiante registrado correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }



        // =========================

        // MODIFICAR ESTUDIANTE

        // =========================

        public string ModificarEstudiante(Estudiante e)

        {

            try

            {

                using (SqlConnection con = cn.GetConexion())

                {

                    SqlCommand cmd = new SqlCommand(

                      @"UPDATE estudiante SET

              id_distrito = @id_distrito,

              dni = @dni,

              nombres = @nombres,

              apellidos = @apellidos,

              id_genero = @id_genero,

              fecha_nacimiento = @fecha_nacimiento,

              edad = @edad,

              correo1 = @correo1,

              correo2 = @correo2,

              telefono1 = @telefono1,

              telefono2 = @telefono2,

              id_procedencia = @id_procedencia,

              id_condicion = @id_condicion,

              id_apoderado = @id_apoderado

            WHERE id_estudiante = @id_estudiante", con);



                    cmd.Parameters.AddWithValue("@id_estudiante", e.IdEstudiante);

                    cmd.Parameters.AddWithValue("@id_distrito", e.IdDistrito);

                    cmd.Parameters.AddWithValue("@dni", e.Dni);

                    cmd.Parameters.AddWithValue("@nombres", e.Nombres);

                    cmd.Parameters.AddWithValue("@apellidos", e.Apellidos);

                    cmd.Parameters.AddWithValue("@id_genero", e.IdGenero);

                    cmd.Parameters.AddWithValue("@fecha_nacimiento", e.FechaNacimiento);

                    cmd.Parameters.AddWithValue("@edad", e.Edad);

                    cmd.Parameters.AddWithValue("@correo1", e.Correo1);

                    cmd.Parameters.AddWithValue("@correo2", (object)e.Correo2 ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@telefono1", e.Telefono1);

                    cmd.Parameters.AddWithValue("@telefono2", (object)e.Telefono2 ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@id_procedencia", e.IdProcedencia);

                    cmd.Parameters.AddWithValue("@id_condicion", e.IdCondicion);

                    cmd.Parameters.AddWithValue("@id_apoderado", e.IdApoderado);



                    con.Open();

                    cmd.ExecuteNonQuery();

                }



                return "Estudiante actualizado correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }



        // =========================

        // ELIMINAR (LOGICO)

        // =========================

        public string EliminarEstudiante(int id)

        {

            try

            {

                using (SqlConnection con = cn.GetConexion())

                {

                    SqlCommand cmd = new SqlCommand(

                      "UPDATE estudiante SET estado = 0 WHERE id_estudiante = @id", con);



                    cmd.Parameters.AddWithValue("@id", id);



                    con.Open();

                    cmd.ExecuteNonQuery();

                }



                return "Estudiante eliminado correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

    }

}