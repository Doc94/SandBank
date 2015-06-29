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
        private int saldo;

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
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
                comando.CommandText = "INSERT INTO cuenta_corriente VALUES('" + c.Rut + "'," + c.Sueldo * 2 + "," + 0 + ")";
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

        public cuentaCorriente Read(string r)
        {
           cuentaCorriente cc = null;
            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "select * from cuenta_corriente where rut='" + r + "'";
                comando.Connection = con.usaConexion();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string ru = (string)reader[0];
                    int c = (int)reader[1];
                    int s = (int)reader[2];
                    cc = new cuentaCorriente();
                    cc.Rut = ru;
                    cc.Credito = c;
                    cc.Saldo = s;
                }

            }

            finally
            {
                con.cierraConexion();
            }

            return cc;
        }
    }
}
