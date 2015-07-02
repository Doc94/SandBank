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

        public bool update_cuenta(cuentaCorriente c)
        {
            bool update = false;

            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "UPDATE cuenta_corriente SET saldo="+c.Saldo+" WHERE rut='"+c.Rut+"'";
                comando.Connection = con.usaConexion();
                if (comando.ExecuteNonQuery() > 0)
                    update = true;
            }
            finally
            {
                con.cierraConexion();
            }
            return update;


        }

        public Boolean RealizarTransferencia(String rut_origen, String rut_destino, int monto_origen, int monto_destino, Transferencia log) {
            //Este metodo considera que hay saldo,
            con.abreConexion();
            //Iniciamos comando
            SqlCommand comando = new SqlCommand();
            comando.Connection = con.usaConexion();
            //Iniciamos la transaccion y la seteamos al comando
            SqlTransaction trans = con.usaConexion().BeginTransaction();
            comando.Transaction = trans;
            try {

                //Ejecutamos el comando
                comando.CommandText = "UPDATE cuenta_corriente SET saldo=" + monto_origen + " WHERE rut='" + rut_origen + "'";
                if(comando.ExecuteNonQuery() < 1) {
                    trans.Rollback();
                    return false;
                }
                comando.CommandText = "UPDATE cuenta_corriente SET saldo=" + monto_destino + " WHERE rut='" + rut_destino + "'";
                if(comando.ExecuteNonQuery() < 1) {
                    trans.Rollback();
                    return false;
                }
                comando.CommandText = "INSERT INTO transferencias VALUES('" + log.Rut + "'," + log.Monto + ",'" + log.Comentario + "','" + log.Destinatario + "','" + log.Fecha + "')";
                if(comando.ExecuteNonQuery() < 1) {
                    trans.Rollback();
                    return false;
                }
                trans.Commit();
                con.cierraConexion();
                return true;
            } catch {
                trans.Rollback();
            }
            
            con.cierraConexion();
            return false;
        }
    }
}
