﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sandbank
{
    public partial class ventana_cliente : Form
    {
        Cliente elcliente = new Cliente();

        internal Cliente Elcliente
        {
        get { return elcliente; }
        set { elcliente = value; }
        } 

        public ventana_cliente()
        {
            InitializeComponent();
        }
        public void transferencias(string r)
        {
            Conexion c = Conexion.Instance();



            SqlDataAdapter daclientes = new SqlDataAdapter("SELECT * FROM transferencias where rut='"+r+"'", c.usaConexion());

            DataSet dsclientes = new DataSet();
            daclientes.Fill(dsclientes, "transferencias");

            dataGridView1.DataSource = dsclientes;
            dataGridView1.DataMember = "transferencias";
            c.cierraConexion();
        }

        public void abonos(string r)
        {
            Conexion c = Conexion.Instance();



            SqlDataAdapter daclientes = new SqlDataAdapter("SELECT * FROM transferencias where destinatario='" + r + "'", c.usaConexion());

            DataSet dsclientes = new DataSet();
            daclientes.Fill(dsclientes, "transferencias");

            dataGridView2.DataSource = dsclientes;
            dataGridView2.DataMember = "transferencias";
            c.cierraConexion();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //Al cambiar de pestaña
        {
            if(tabControl1.SelectedIndex == 0) { //En el tab de inicio
                //Colocar nuevos datos
                LoadProfile();               
            }
            if (tabControl1.SelectedIndex == 1)
            {
                transferencias(elcliente.Rut);
                abonos(elcliente.Rut);
            }
        }

        public void LoadProfile() {
            textBox_inicio_nombre.Text = elcliente.Nombre;
            textBox_inicio_apellido.Text = elcliente.Apellido;
            textBox_inicio_direccion.Text = elcliente.Direccion;
            textBox_inicio_fecha.Text = elcliente.Fecha;
            textBox_inicio_sueldo.Text = elcliente.Sueldo.ToString();
            cuentaCorriente cc = new cuentaCorriente();

            textBox__inicio_saldo.Text = cc.Read(Elcliente.Rut).Saldo.ToString();
            textBox_inicio_cupo.Text = cc.Read(Elcliente.Rut).Credito.ToString();
        }

        private void ventana_cliente_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void button_transferir_Click(object sender, EventArgs e)
        {
            cuentaCorriente ccrud = new cuentaCorriente();
            cuentaCorriente rdestinatario = ccrud.Read(textBox_transferencia_rutdestiono.Text);
            cuentaCorriente rtranfer = ccrud.Read(elcliente.Rut);
            if(textBox_transferencia_rutdestiono.Text.Trim().Equals("")||textBox_transferencia_monto.Text.Trim().Equals("")||textBox_transferencia_comentario.Text.Trim().Equals(""))
            {
                MessageBox.Show("Rellene los campos vacíos");
            }
            else if (rdestinatario == null)
            {
                MessageBox.Show("el rut ingresado no se encuentra por favor ingreselo nuevamente");
            }
            else if (Convert.ToInt32(textBox_transferencia_monto.Text)<2000)
            {
                MessageBox.Show("El monto minimo es 2000");
            }
            else if (textBox_transferencia_rutdestiono.Text == rtranfer.Rut)
            {
                MessageBox.Show("no puedes transferirte a ti mismo");
            }
            else
            {
                int saldo = rtranfer.Read(elcliente.Rut).Saldo;
                int monto = Convert.ToInt32(textBox_transferencia_monto.Text);
                DateTime Hoy = DateTime.Today;
                int saldo2 = saldo - monto;
                string fecha_actual = Hoy.ToString("dd-MM-yyyy");


                Transferencia t = new Transferencia();
                Transferencia tcrud = new Transferencia();


                if ((saldo - monto) < 0)
                {
                    MessageBox.Show("Saldo insuficiente para transferir ese monto");
                }
                else
                {


                    t.Rut = elcliente.Rut;
                    t.Monto = monto;
                    t.Comentario = textBox_transferencia_comentario.Text;
                    t.Destinatario = textBox_transferencia_rutdestiono.Text;
                    t.Fecha = fecha_actual;
                    rtranfer.Saldo = saldo2;
                    rdestinatario.Saldo = rdestinatario.Saldo + monto;
                    int saldodestino = rdestinatario.Saldo;
                    if (ccrud.RealizarTransferencia(t.Rut, t.Destinatario, saldo2, saldodestino, t))
                    {
                        MessageBox.Show("Transferencia realizada");
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!");
                    }
                    /*
                    if (ccrud.update_cuenta(rdestinatario) && ccrud.update_cuenta(rtranfer) && tcrud.crea_tranfer(t))
                    {

                        MessageBox.Show("Transferencia realizada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!");
                    }
                     */
                }

                //Iniciamos Comprobacion
            }
        }

      


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_transferencia_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main log = new Main();

            this.Hide();
            log.Show();
            log.Visible = false;
            log.ShowDialog();
            this.Dispose();
        }

    }
}
