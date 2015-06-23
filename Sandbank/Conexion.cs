using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Sandbank
{
    
        class Conexion
    {
        private SqlConnection conexion;
        private static Conexion instance;
        private Conexion()
        {
        }
        public static Conexion Instance()
        {
            if (instance == null)
                instance = new Conexion();
            return instance;
        }
        public void abreConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=Alejandro-PC\\SQLEXPRESS; Initial Catalog=sandbank; Integrated Security=true;";
            try
            {
                conexion.Open();
            }
            catch (SqlException ex) { }
        }
        public SqlConnection usaConexion()
        {
            return conexion;
        }
        public void cierraConexion()
        {
            conexion.Close();
        }
    }
}
    

