using System.Data;

using System.Data.SqlClient;

using ControlEstudiantilSENATI.Datos;



namespace ControlEstudiantilSENATI.BaseDatos

{

  public class Vistas

{

  Conexion cn = new Conexion();



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

}

}
