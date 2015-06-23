﻿using System;
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
            string mes = Convert.ToString(comboBox_mes.SelectedItem);
            int dia = Convert.ToInt32(comboBox_dia.SelectedItem);
            string año=Convert.ToString(comboBox_año.SelectedItem);
            string d= Convert.ToString(comboBox_año.SelectedItem);

            if ((mes.Equals("Febrero") && dia > 28) || ((mes.Equals("Abril") || mes.Equals("Junio") || mes.Equals("Septiembre") || mes.Equals("Noviembre")) && dia > 30) || (año.Equals("") || d.Equals("") || mes.Equals("")))
            {
                MessageBox.Show("Ingrese fecha válida");
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
                MessageBox.Show("Su credito hipotecario esta listo para ser aprobado");
            }

        }

        

        
        
    }
}
