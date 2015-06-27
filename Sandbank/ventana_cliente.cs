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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //Al cambiar de pestaña
        {
            if(tabControl1.SelectedIndex == 0) { //En el tab de inicio
                //Colocar nuevos datos
                LoadProfile();               
            }
        }

        public void LoadProfile() {
            textBox_inicio_nombre.Text = elcliente.Nombre;
            textBox_inicio_apellido.Text = elcliente.Apellido;
            textBox_inicio_direccion.Text = elcliente.Direccion;
            textBox_inicio_fecha.Text = elcliente.Fecha;
            textBox_inicio_sueldo.Text = elcliente.Sueldo.ToString();
        }

        private void ventana_cliente_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void button_transferir_Click(object sender, EventArgs e)
        {
            //Iniciamos Comprobacion
        }

    }
}
