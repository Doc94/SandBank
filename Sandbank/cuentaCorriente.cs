using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Sandbank
{
    class cuentaCorriente
    {

        Conexion con;
        private string rut;

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private int credito;

        public int Credito
        {
            get { return credito; }
            set { credito = value; }
        }
        public cuentaCorriente()
        {
            con = Conexion.Instance();
        }
        public bool crea_cuenta(Cliente c)
        {
            bool creado = false;

            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "INSERT INTO cuenta_corriente VALUES('" + c.Rut + "'," + c.Sueldo*2 + ")";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                    creado = true;
            }
            finally
            {
                con.cierraConexion();
            }
            return creado;


        }
    }
}
