using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbank
{
    class Ejecutivo
    {
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
        
        }

        public Ejecutivo(string r, string p, string n, string a)
        { 
            this.rut = r;
            this.password = p;
            this.nombre = n;
            this.apellido = a;
        }

    }
}
