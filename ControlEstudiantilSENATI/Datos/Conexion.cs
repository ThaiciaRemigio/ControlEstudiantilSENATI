using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ControlEstudiantilSENATI.Datos

{

    public class Conexion

    {

        

        private string cadena = @"Server=(localdb)\MSSQLLocalDB;Database=ControlEstudiantilSenati;Trusted_Connection=True;";



        public SqlConnection GetConexion()

        {

            return new SqlConnection(cadena);

        }

    }

}
