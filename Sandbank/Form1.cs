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
            if(cl == null) {

               
            } else {
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
        }
    }
}
