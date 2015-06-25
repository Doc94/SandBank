using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Sandbank
{
    class creditoHipotecario
    {

        Conexion con;
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
        private double interes;

        public double Interes
        {
            get { return interes; }
            set { interes = value; }
        }
<<<<<<< HEAD

        
=======
>>>>>>> origin/master
        private int plazo;

        public int Plazo
        {
            get { return plazo; }
            set { plazo = value; }
        }
        private int cantCuotas;

        public int CantCuotas
        {
            get { return cantCuotas; }
            set { cantCuotas = value; }
        }
        private int valorCuota;

        public int ValorCuota
        {
            get { return valorCuota; }
            set { valorCuota = value; }
        }
        private int saldo;

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        private int cuotasRestantes;

        public int CuotasRestantes
        {
            get { return cuotasRestantes; }
            set { cuotasRestantes = value; }
        }
        private int cuotasCanceladas;

        public int CuotasCanceladas
        {
            get { return cuotasCanceladas; }
            set { cuotasCanceladas = value; }
        }
        public creditoHipotecario()
        {
            con = Conexion.Instance();
        }
        public bool crea_credito(creditoHipotecario c)
        {
            bool creado = false;

            try
            {
                con.abreConexion();
                SqlCommand comando = new SqlCommand();
<<<<<<< HEAD
                comando.CommandText = "INSERT INTO credito_hipotecario VALUES('" + c.Rut + "'," + c.Monto + ",'" + c.Interes + "'," + c.Plazo + "," + c.CantCuotas + "," + c.ValorCuota + "," + c.Saldo + "," + c.CuotasRestantes + "," + c.CuotasCanceladas + ")";
=======
                comando.CommandText = "INSERT INTO credito_hipotecario VALUES('" + c.Rut + "'," + c.Monto + "," + c.Interes + "," + c.Plazo + "," + c.CantCuotas + "," + c.ValorCuota + "," + c.Saldo + "," + c.CuotasRestantes + "," + c.CuotasCanceladas + ")";
>>>>>>> origin/master
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
