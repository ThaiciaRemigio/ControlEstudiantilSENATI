using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ControlEstudiantilSENATI.BaseDatos

{

  public static class Procedimientos

{

  public static class Estudiante

  {

    public const string Insertar = "sp_InsertarEstudiante";

    public const string Modificar = "sp_ModificarEstudiante";

    public const string Eliminar = "sp_EliminarEstudiante";

    public const string Buscar = "sp_BuscarEstudiante";

  }



  public static class Vistas

  {

    public const string Estudiantes = "vw_Estudiantes";

  }

}

}
