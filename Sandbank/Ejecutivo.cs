using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Sandbank
{
    class Ejecutivo
    {
        Conexion con;
        private string rut;

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Ejecutivo()
        {
            con = Conexion.Instance();
        }

        public Ejecutivo(string r, string p, string n, string a)
        { 
            this.rut = r;
            this.password = p;
            this.nombre = n;
            this.apellido = a;
        }

        public Ejecutivo Read(string r)
        {
            Ejecutivo ej = null;
            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "select * from ejecutivos where rut='" + r + "'";
                comando.Connection = con.usaConexion();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string ru = (string)reader[0];
                    string pa = (string)reader[1];
                    string n = (string)reader[2];
                    string a = (string)reader[3];
                    
                    ej = new Ejecutivo();
                    ej.Rut = ru;
                    ej.Password = pa;
                    ej.Nombre = n;
                    ej.Apellido = a;
                    
                }

            }

            finally
            {
                con.cierraConexion();
            }

            return ej;
        }
    }
}
