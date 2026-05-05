using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ControlEstudiantilSENATI.BaseDatos

{

  public class Script

  {

    // =========================

    // ESTUDIANTE

    // =========================



    public static string ListarEstudiantes =

      "SELECT * FROM vw_Estudiantes";



    public static string ListarGeneros =

      "SELECT * FROM genero";



    public static string ListarCondiciones =

      "SELECT * FROM condicion";



    public static string ListarProcedencia =

      "SELECT * FROM procedencia";



    public static string ListarDistritos =

      "SELECT * FROM distrito";



    public static string ListarApoderados =

      "SELECT * FROM apoderado";

  }

}