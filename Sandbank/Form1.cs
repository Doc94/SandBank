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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ingresar_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            Cliente clCrud = new Cliente();
            Cliente cl = clCrud.Read(textBox_rut.Text);
            Ejecutivo ejCrud = new Ejecutivo();
            Ejecutivo ej = ejCrud.Read(textBox_rut.Text);
            if (cl != null)
            {
                if (cl.Password.Equals(textBox_password.Text))
                {
                    MessageBox.Show("Ingresó correctamente");
                    ventana_cliente vc = new ventana_cliente();
                    vc.Show();
                    this.Hide();
                    vc.Visible = false;
                    vc.ShowDialog();
                    this.Dispose();
                }
                
                else
                {
                    MessageBox.Show("Password incorrecta");
                }
                    
            }
            else if (ej != null)
            { 
                if (ej.Password.Equals(textBox_password.Text))
                {
                    
                    MessageBox.Show("Ingresó correctamente");
                    ventana_ejecutivo ve = new ventana_ejecutivo();
                    ve.Show();
                    this.Hide();
                    ve.Visible = false;
                    ve.ShowDialog();
                    this.Dispose();
                }

                else
                {
                    MessageBox.Show("Password incorrecta");
                }
              
            }

            else if (ej == null && cl == null)   
            {
                MessageBox.Show("El rut ingresado es incorrecto");
            }


        }
    }
}
