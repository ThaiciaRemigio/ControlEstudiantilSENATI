using System;

using System.Data.SqlClient;



namespace ControlEstudiantilSENATI.Datos

{

    public class Conexion

    {

        // 🔴 Cambia si tu SQL Server tiene otro nombre o instancia

        private string cadena = @"Server=(localdb)\MSSQLLocalDB;Database=ControlEstudiantilSenati;Trusted_Connection=True;";



        public SqlConnection GetConexion()

        {

            return new SqlConnection(cadena);

        }

    }

}
