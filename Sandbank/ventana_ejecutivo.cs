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
    public partial class ventana_ejecutivo : Form
    {
        public int verificar = 0;
        public ventana_ejecutivo()
        {
            InitializeComponent();
        }

        private void button_creditoHipotecario_Click(object sender, EventArgs e)
        {
            ventana_creditoHipotecario vch = new ventana_creditoHipotecario();
            vch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clCrud = new Cliente();
            string rut = textBox_ruthipotecario.Text;
            Cliente cl = clCrud.Read(rut);

            if (cl == null)
            {
                MessageBox.Show("el cliente no posee una cuenta corriente, si cumple con los requisitos se le creará una automaticamente");
                textBox_nombrehipotecario.Text = "";
                textBox_apellidohipotecario.Text = "";
                textBox_direccionhipotecario.Text = "";
                textBox_liquidacionhipotecario.Text = "";
            }
            else
            {
                verificar = 1;
                textBox_nombrehipotecario.Text = cl.Rut;
                textBox_apellidohipotecario.Text = cl.Apellido;
                textBox_direccionhipotecario.Text = cl.Direccion;
                textBox_liquidacionhipotecario.Text = Convert.ToString(cl.Sueldo);
                string[] fecha = cl.Fecha.Split('-');
                int l = comboBox_año.Items.Count;
                for (int i = 0; i < l; i++)
                {
                    comboBox_añohipotecario.SelectedIndex = i;
                    if (comboBox_añohipotecario.SelectedItem.ToString().Equals(fecha[2]))
                    {
                        break;
                    }
                }

                for (int i = 0; i < comboBox_meshipotecario.Items.Count; i++)
                {
                    comboBox_meshipotecario.SelectedIndex = i;
                    if (i == Convert.ToInt32(fecha[1]) - 1)
                    {
                        break;
                    }
                }

                for (int i = 0; i < comboBox_diahipotecario.Items.Count; i++)
                {
                    comboBox_diahipotecario.SelectedIndex = i;
                    if (i == Convert.ToInt32(fecha[0]) - 1)
                    {
                        break;
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(comboBox_añosCredito.SelectedItem).Equals(""))
            {

            }
            else
            {
                double interes;
                double K = 70;
                double años = Convert.ToDouble(comboBox_añosCredito.SelectedItem);
                interes = K / años;
                textBox_interes.Text = interes.ToString("N2");
                double monto = Convert.ToDouble(textBox_monto.Text);
                double liquidacion = Convert.ToDouble(textBox_liquidacionhipotecario.Text);
                double cantcuotas = años * 12;
                double cuotas = (monto / cantcuotas) * interes;

                if ((liquidacion / 4) < cuotas)
                {
                    MessageBox.Show("Su sueldo no es suficiente para este monto por favor pida su credito en mas años");
                    textBox_cuota.Text = cuotas.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Su credito esta listo para ser aprobado");
                    textBox_cuota.Text = cuotas.ToString("N0");
                }

            }
        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            int l = comboBox_año.Items.Count;
            for (int i = 0; i < l; i++)
            {
                comboBox_año.SelectedIndex = i;
                if (comboBox_año.SelectedItem.ToString().Equals(textBox_rut.Text))
                {
                    i = l + 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mes = Convert.ToString(comboBox_meshipotecario.SelectedIndex+1);
            int dia = Convert.ToInt32(comboBox_diahipotecario.SelectedItem);
            string año = Convert.ToString(comboBox_añohipotecario.SelectedItem);
            string d = Convert.ToString(comboBox_diahipotecario.SelectedItem);
            Cliente clCrud = new Cliente();
            Cliente cl = new Cliente();
            cuentaCorriente ccCrud = new cuentaCorriente();
            cuentaCorriente cc = new cuentaCorriente();
            if (Convert.ToString(comboBox_añosCredito.SelectedItem).Equals(""))
            {
                MessageBox.Show("Seleccione la cantidad de años del credito");
            }
            else if ((mes.Equals("Febrero") && dia > 28) || ((mes.Equals("Abril") || mes.Equals("Junio") || mes.Equals("Septiembre") || mes.Equals("Noviembre")) && dia > 30) || (año.Equals("") || d.Equals("") || mes.Equals("")))
            {
                MessageBox.Show("Ingrese fecha válida");
            }

            else
            {
                double interes;
                double K = 70;
                double años = Convert.ToDouble(comboBox_añosCredito.SelectedItem);
                interes = K / años;
                double monto = Convert.ToDouble(textBox_monto.Text);
                double liquidacion = Convert.ToDouble(textBox_liquidacionhipotecario.Text);
                double cantcuotas = años * 12;
                double cuotas = (monto / cantcuotas) * interes;

                if ((liquidacion / 4) < cuotas)
                {
                    MessageBox.Show("Su sueldo no es suficiente para este monto por favor pida su credito en mas años");

                }
                else
                {
                    cl.Rut = textBox_ruthipotecario.Text;
                    cl.Nombre = textBox_nombrehipotecario.Text;
                    cl.Apellido = textBox_apellidohipotecario.Text;
                    cl.Direccion = textBox_direccionhipotecario.Text;
                    cl.Fecha = d + "-" + mes + "-" + año;
                    cl.Sueldo = Convert.ToInt32(liquidacion);
                    cl.Password = textBox_ruthipotecario.Text;
                    cc.Rut=textBox_ruthipotecario.Text;
                    cc.Credito=Convert.ToInt32(liquidacion)*2;
                    if (clCrud.crea_cliente(cl)&& ccCrud.crea_cuenta(cl))
                    {
                        MessageBox.Show("Su credito ha sido aprobado");
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!!");
                    }

                }
            }

        }
    }
}
