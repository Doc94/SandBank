using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Sandbank
{
    class Cliente
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
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int sueldo;

        public int Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public Cliente()
        {
            con = Conexion.Instance();
        }

        public Cliente(string r, string p, string n, string a, string d, string f)
        {
            this.rut = r;
            this.password = p;
            this.nombre = n;
            this.apellido = a;
            this.direccion = d;
            this.fecha = f;
        }

        public Cliente Read(string r)
        {
            Cliente cl = null;
            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "select * from clientes where rut="+r+"";
                comando.Connection = con.usaConexion();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string ru = (string)reader[0];
                    string pa = (string)reader[1];
                    string n = (string)reader[2];
                    string a = (string)reader[3];
                    string d = (string)reader[4];
                    string f = (string)reader[5];
                    int s = (int)reader[6];
                    cl = new Cliente();
                    cl.Rut = ru;
                    cl.Password = pa;
                    cl.Nombre = n;
                    cl.Apellido = a;
                    cl.Direccion = d;
                    cl.Fecha = f;
                    cl.Sueldo = s;
                }
                
            }

            finally
            {
                con.cierraConexion();
            }

            return cl;
        }

    }
}
