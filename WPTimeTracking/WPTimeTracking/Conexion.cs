using System;
using System.Data.SqlClient;

namespace WPTimeTracking
{
   internal class Conexion
   {
        public static SqlConnection abrirConexion()
        {
            //CONEXION BD
            SqlConnection con = new SqlConnection();
            String s_nombrePC = System.Windows.Forms.SystemInformation.ComputerName;
            con.ConnectionString = ("Data Source="+ s_nombrePC + ";Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            return con;
        }
    }    
}
