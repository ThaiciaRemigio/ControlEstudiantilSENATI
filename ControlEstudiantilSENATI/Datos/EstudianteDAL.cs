using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEstudiantilSENATI.Datos;
using ControlEstudiantilSENATI.Entidades;



namespace ControlEstudiantilSENATI.Datos

{

    public class EstudianteDAL

    {

        Conexion cn = new Conexion();

        // =========================
        // LISTAS (combobox)
        // =========================

        public DataTable ListarDistritos()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_distrito, nombre_distrito FROM distrito",
                    con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarGeneros()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_genero, nombre_genero FROM genero",
                    con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarCondiciones()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_condicion, nombre_condicion FROM condicion",
                    con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarProcedencias()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_procedencia, descripcion FROM procedencia",
                    con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarApoderados()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_apoderado, nombres + ' ' + apellidos AS nombre FROM apoderado",
                    con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =========================
        // LISTAR / BUSCAR
        // =========================

        public DataTable ListarEstudiantes()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_Estudiantes", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable BuscarEstudiante(string texto)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TextoBusqueda", texto);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =========================
        // INSERTAR
        // =========================

        public string InsertarEstudiante(Estudiante e)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdDistrito", e.IdDistrito);
                cmd.Parameters.AddWithValue("@Dni", e.Dni);
                cmd.Parameters.AddWithValue("@Nombres", e.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@IdGenero", e.IdGenero);
                cmd.Parameters.AddWithValue("@FechaNacimiento", e.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Edad", e.Edad);
                cmd.Parameters.AddWithValue("@Correo1", e.Correo1);
                cmd.Parameters.AddWithValue("@Correo2", (object)e.Correo2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono1", e.Telefono1);
                cmd.Parameters.AddWithValue("@Telefono2", (object)e.Telefono2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdProcedencia", e.IdProcedencia);
                cmd.Parameters.AddWithValue("@IdCondicion", e.IdCondicion);
                cmd.Parameters.AddWithValue("@IdApoderado", e.IdApoderado);

                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "No se recibió respuesta del servidor";
            }
        }

        // =========================
        // ACTUALIZAR
        // =========================

        public string ActualizarEstudiante(Estudiante e)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ModificarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEstudiante", e.IdEstudiante);
                cmd.Parameters.AddWithValue("@IdDistrito", e.IdDistrito);
                cmd.Parameters.AddWithValue("@Dni", e.Dni);
                cmd.Parameters.AddWithValue("@Nombres", e.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@IdGenero", e.IdGenero);
                cmd.Parameters.AddWithValue("@FechaNacimiento", e.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Edad", e.Edad);
                cmd.Parameters.AddWithValue("@Correo1", e.Correo1);
                cmd.Parameters.AddWithValue("@Correo2", (object)e.Correo2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono1", e.Telefono1);
                cmd.Parameters.AddWithValue("@Telefono2", (object)e.Telefono2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdProcedencia", e.IdProcedencia);
                cmd.Parameters.AddWithValue("@IdCondicion", e.IdCondicion);
                cmd.Parameters.AddWithValue("@IdApoderado", e.IdApoderado);

                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "No se recibió respuesta del servidor";
            }
        }

        // =========================
        // ELIMINAR (lógico)
        // =========================

        public string EliminarEstudiante(Estudiante e)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEstudiante", e.IdEstudiante);

                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "No se recibió respuesta del servidor";
            }
        }

    }

}