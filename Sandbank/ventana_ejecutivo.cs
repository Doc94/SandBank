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
    public partial class ventana_ejecutivo : Form
    {
        public ventana_ejecutivo()
        {
            InitializeComponent();
        }

        private void button_creditoHipotecario_Click(object sender, EventArgs e)
        {
            ventana_creditoHipotecario vch = new ventana_creditoHipotecario();
            vch.Show();
        }

    }
}
