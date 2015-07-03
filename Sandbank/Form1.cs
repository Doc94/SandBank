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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_ingresar_Click(object sender, EventArgs e)
        {
            if (textBox_rut.Text.Equals("") || textBox_password.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
                        vc.Elcliente = cl;
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

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
