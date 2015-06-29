using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Sandbank
{
    class Transferencia
    {
        Conexion con;

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string rut;

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private int monto;

        public int Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        private string comentario;

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        private string destinatario;

        public string Destinatario
        {
            get { return destinatario; }
            set { destinatario = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Transferencia()
        {
            con = Conexion.Instance();
        }

        public bool crea_tranfer(Transferencia t)
        {
            bool creado = false;

            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "INSERT INTO transferencias VALUES(" + t.Numero + ",'" + t.Rut + "'," + t.Monto + ",'" + t.Comentario + "','" + t.Destinatario + "','" + t.Fecha + "')";
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
