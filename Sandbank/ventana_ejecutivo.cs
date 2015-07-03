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
            if (textBox_ruthipotecario.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar Un Rut para verificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                    verificar = 0;
                }
                else
                {


                    verificar = 1;

                    //Se bloquean los campos
                    textBox_nombrehipotecario.ReadOnly = true;
                    textBox_apellidohipotecario.ReadOnly = true;
                    textBox_direccionhipotecario.ReadOnly = true;
                    textBox_liquidacionhipotecario.ReadOnly = true;
                    comboBox_añohipotecario.Enabled = false;
                    comboBox_diahipotecario.Enabled = false;
                    comboBox_meshipotecario.Enabled = false;

                    //Se setean los nuevos valores
                    textBox_nombrehipotecario.Text = cl.Nombre;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(comboBox_añosCredito.SelectedItem).Equals("") || textBox_ruthipotecario.Text.Equals("")
                || textBox_nombrehipotecario.Text.Equals("") || textBox_apellidohipotecario.Text.Equals("") || textBox_direccionhipotecario.Text.Equals("")
                || comboBox_diahipotecario.SelectedItem.Equals("") || comboBox_meshipotecario.SelectedItem.Equals("") || comboBox_añohipotecario.SelectedItem.Equals(""))
            {
                MessageBox.Show("Debe Completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                button_hipotecario_aprobarcredito.Enabled = true;
                double interes;
                double K = 70;
                double años = Convert.ToSingle(comboBox_añosCredito.SelectedItem);
                interes = K / años;
                textBox_interes.Text = interes.ToString("N2");
                double monto = Convert.ToSingle(textBox_montohipotecario.Text);
                double liquidacion = Convert.ToSingle(textBox_liquidacionhipotecario.Text);
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
            if (comboBox_mes.SelectedItem.Equals("Mes") || comboBox_dia.SelectedItem.Equals("Día") ||
                comboBox_año.SelectedItem.Equals("Año") || textBox_rut.Text.Equals("") || textBox_nombre.Text.Equals("")
                || textBox_apellidop.Text.Equals("") || textBox_direccion.Text.Equals("") || textBox_liquidacion.Text.Equals(""))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            string mes = Convert.ToString(comboBox_mes.SelectedIndex );
            string mess = Convert.ToString(comboBox_mes.SelectedItem);
            int dia = Convert.ToInt32(comboBox_dia.SelectedItem);
            string año = Convert.ToString(comboBox_año.SelectedItem);
            string d = Convert.ToString(comboBox_dia.SelectedItem);
            Cliente clCrud = new Cliente();
            Cliente cl = new Cliente();
            cuentaCorriente ccCrud = new cuentaCorriente();
            cuentaCorriente cc = new cuentaCorriente();
            if ((mess.Equals("Febrero") && dia > 28) || ((mess.Equals("Abril") || mess.Equals("Junio") || mess.Equals("Septiembre") || mess.Equals("Noviembre")) && dia > 30) || (año.Equals("") || d.Equals("") || mes.Equals("")))
            {
                MessageBox.Show("Ingrese fecha válida");
            }
            else if (Convert.ToInt32(textBox_liquidacion.Text) < 400000)
            {
                MessageBox.Show("Su sueldo debe ser mayor a 400.000 lo sentimos");
            }
            else 
            {
                
                    cl.Rut = textBox_rut.Text;
                    cl.Nombre = textBox_nombre.Text;
                    cl.Apellido = textBox_apellidop.Text;
                    cl.Direccion = textBox_direccion.Text;
                    cl.Fecha = d + "-" + mes + "-" + año;
                    cl.Sueldo = Convert.ToInt32(textBox_liquidacion.Text);
                    cl.Password = cl.Rut;
                    textBox_password.Text = textBox_rut.Text;

                    if (clCrud.crea_cliente(cl) && ccCrud.crea_cuenta(cl))
                    {
                        MessageBox.Show("Cuenta corriente creada");
                    }
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_hipotecario_aprobarcredito.Enabled = false;
            if (Convert.ToString(comboBox_añosCredito.SelectedItem).Equals("") || textBox_ruthipotecario.Text.Equals("")
                || textBox_nombrehipotecario.Text.Equals("") || textBox_apellidohipotecario.Text.Equals("") || textBox_direccionhipotecario.Text.Equals("")
                || comboBox_diahipotecario.SelectedItem.Equals("") || comboBox_meshipotecario.SelectedItem.Equals("") || comboBox_añohipotecario.SelectedItem.Equals(""))
            {
                MessageBox.Show("Debe Completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mes = Convert.ToString(comboBox_meshipotecario.SelectedIndex);
                string mess = Convert.ToString(comboBox_meshipotecario.SelectedItem);
                int dia = Convert.ToInt32(comboBox_diahipotecario.SelectedItem);
                string año = Convert.ToString(comboBox_añohipotecario.SelectedItem);
                string d = Convert.ToString(comboBox_diahipotecario.SelectedItem);
                Cliente clCrud = new Cliente();
                Cliente cl = new Cliente();
                cuentaCorriente ccCrud = new cuentaCorriente();
                cuentaCorriente cc = new cuentaCorriente();
                creditoHipotecario chCrud = new creditoHipotecario();
                creditoHipotecario ch = new creditoHipotecario();
                if (Convert.ToString(comboBox_añosCredito.SelectedItem).Equals(""))
                {
                    MessageBox.Show("Seleccione la cantidad de años del credito");
                }
                else if ((mess.Equals("Febrero") && dia > 28) || ((mess.Equals("Abril") || mess.Equals("Junio") || mess.Equals("Septiembre") || mess.Equals("Noviembre")) && dia > 30) || (año.Equals("") || d.Equals("") || mes.Equals("")))
                {
                    MessageBox.Show("Ingrese fecha válida");
                }
                else if (Convert.ToInt32(textBox_liquidacionhipotecario.Text) < 400000)
                {
                    MessageBox.Show("Su sueldo debe ser mayor a 400.000 lo sentimos");
                }
                else
                {
                    double interes;
                    double K = 70;
                    double años = Convert.ToSingle(comboBox_añosCredito.SelectedItem);
                    interes = K / años;
                    double monto = Convert.ToSingle(textBox_montohipotecario.Text);
                    double liquidacion = Convert.ToSingle(textBox_liquidacionhipotecario.Text);
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

                        ch.Rut = textBox_ruthipotecario.Text;
                        ch.Monto = Convert.ToInt32(textBox_montohipotecario.Text);
                        ch.Interes = interes;
                        ch.Plazo = Convert.ToInt32(comboBox_añosCredito.SelectedItem);
                        ch.CantCuotas = ch.Plazo * 12;
                        ch.ValorCuota = (int)((Convert.ToInt32(textBox_montohipotecario.Text) / ch.CantCuotas) * interes);
                        ch.Saldo = Convert.ToInt32(textBox_montohipotecario.Text);
                        ch.CuotasRestantes = ch.CantCuotas;
                        ch.CuotasCanceladas = 0;
                        if (verificar == 0)
                        {
                            cc.Rut = textBox_ruthipotecario.Text;
                            cc.Credito = Convert.ToInt32(liquidacion) * 2;
                            if (clCrud.crea_cliente(cl) && ccCrud.crea_cuenta(cl) && chCrud.crea_credito(ch))
                            {
                                MessageBox.Show("Su credito ha sido aprobado");

                                textBox_ruthipotecario.Text = "";
                                textBox_apellidohipotecario.Text = "";
                                textBox_nombrehipotecario.Text = "";
                                textBox_direccionhipotecario.Text = "";
                                textBox_montohipotecario.Text = "";
                                textBox_liquidacionhipotecario.Text = "";
                                textBox_interes.Text = "";
                                textBox_cuota.Text = "";
                                comboBox_añohipotecario.SelectedIndex = 0;
                                comboBox_añohipotecario.Enabled = true;
                            }
                        }
                        else if (verificar == 1)
                        {
                            if (chCrud.crea_credito(ch))
                            {
                                MessageBox.Show("Su credito ha sido aprobado");
                                textBox_ruthipotecario.Text = "";
                                textBox_apellidohipotecario.Text = "";
                                textBox_nombrehipotecario.Text = "";
                                textBox_direccionhipotecario.Text = "";
                                textBox_montohipotecario.Text = "";
                                textBox_liquidacionhipotecario.Text = "";
                                textBox_interes.Text = "";
                                textBox_cuota.Text = "";
                                comboBox_añohipotecario.SelectedIndex = 0;
                                comboBox_añohipotecario.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR!!!");
                        }

                    }
                }
            }

        }

        private void tab_CreditoHipotecario_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_meshipotecario.SelectedIndex = 0;
            comboBox_diahipotecario.SelectedIndex = 0;
            comboBox_añohipotecario.SelectedIndex = 0;

            comboBox_mes.SelectedIndex = 0;
            comboBox_dia.SelectedIndex = 0;
            comboBox_año.SelectedIndex = 0;
            
        }

        private void btnCerrarSession_Click(object sender, EventArgs e)
        {
            Main log = new Main();

            this.Hide();
            log.Show();
            log.Visible = false;
            log.ShowDialog();
            this.Dispose();
        }

        private void textBox_liquidacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_montohipotecario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
