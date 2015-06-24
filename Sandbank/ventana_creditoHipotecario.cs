using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sandbank
{
    public partial class ventana_creditoHipotecario : Form
    {
        public ventana_creditoHipotecario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CALCULO DE DATOS //
            string mes = Convert.ToString(comboBox_mes.SelectedItem);
            int dia = Convert.ToInt32(comboBox_dia.SelectedItem);
            string año=Convert.ToString(comboBox_año.SelectedItem);
            string d= Convert.ToString(comboBox_año.SelectedItem);
            double interes;
            double K=70;
            double años = Convert.ToDouble(comboBox_añosCredito.SelectedItem);
            interes = K/años;
            double monto = Convert.ToDouble(textBox_monto.Text);
            double liquidacion = Convert.ToDouble(textBox_liquidacion.Text);
            double cantcuotas = años * 12;
            double cuotas = (monto / cantcuotas)*interes;

            Cliente cl = new Cliente();
            Cliente clcrud = new Cliente();
            // CALCULO DE DATOS //
            if ((mes.Equals("Febrero") && dia > 28) || ((mes.Equals("Abril") || mes.Equals("Junio") || mes.Equals("Septiembre") || mes.Equals("Noviembre")) && dia > 30) || (año.Equals("") || d.Equals("") || mes.Equals("")))
            {
                MessageBox.Show("Ingrese fecha válida");
            }
            else if ((liquidacion / 4) < cuotas)
            {
                   
               MessageBox.Show("Su liquidacion no es suficiente debe aumentar los años del credito");
            }
            else
            {
                cl.Rut = textBox_rut.Text;
                cl.Nombre = textBox_nombre.Text;
                cl.Apellido = textBox_apellidop.Text;
                cl.Direccion=textBox_direccion.Text;
                cl.Fecha=d+"-"+mes+"-"+año;
                cl.Sueldo=Convert.ToInt32(liquidacion);
                cl.Password="123";
                if(clcrud.crea_cliente(cl))
                {
                    MessageBox.Show("Crédito aprobado");
                }

            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            double interes;
            double K=70;
            double años = Convert.ToDouble(comboBox_añosCredito.SelectedItem);
            interes = K/años;
            textBox_interes.Text = interes.ToString("N2");
            double monto = Convert.ToDouble(textBox_monto.Text);
            double liquidacion = Convert.ToDouble(textBox_liquidacion.Text);
            double cantcuotas = años * 12;
            double cuotas = (monto / cantcuotas)*interes;


            if ((liquidacion / 4) < cuotas)
            {


                textBox_cuota.Text = cuotas.ToString("N0");
                textBox_cuota.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Su liquidacion no es suficiente debe aumentar los años del credito");
            }

            else
            {
                textBox_cuota.Text = cuotas.ToString("N0");
                MessageBox.Show("Su credito hipotecario esta listo para ser aprobado");
            }

        }

        private void ventana_creditoHipotecario_Load(object sender, EventArgs e)
        {

        }

        private void textBox_interes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox_cuota_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_añosCredito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox_monto_TextChanged(object sender, EventArgs e)
        {

        }

        

        
        
    }
}
