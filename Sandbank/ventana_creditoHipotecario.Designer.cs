namespace Sandbank
{
    partial class ventana_creditoHipotecario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_rut = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellidop = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.comboBox_dia = new System.Windows.Forms.ComboBox();
            this.comboBox_mes = new System.Windows.Forms.ComboBox();
            this.comboBox_año = new System.Windows.Forms.ComboBox();
            this.textBox_liquidacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_monto = new System.Windows.Forms.TextBox();
            this.comboBox_añosCredito = new System.Windows.Forms.ComboBox();
            this.textBox_interes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_cuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credito hipotecario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Liquidación";
            // 
            // textBox_rut
            // 
            this.textBox_rut.Location = new System.Drawing.Point(148, 32);
            this.textBox_rut.Name = "textBox_rut";
            this.textBox_rut.Size = new System.Drawing.Size(100, 20);
            this.textBox_rut.TabIndex = 8;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(148, 63);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 9;
            // 
            // textBox_apellidop
            // 
            this.textBox_apellidop.Location = new System.Drawing.Point(148, 92);
            this.textBox_apellidop.Name = "textBox_apellidop";
            this.textBox_apellidop.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellidop.TabIndex = 10;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(148, 119);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccion.TabIndex = 11;
            // 
            // comboBox_dia
            // 
            this.comboBox_dia.FormattingEnabled = true;
            this.comboBox_dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_dia.Location = new System.Drawing.Point(148, 150);
            this.comboBox_dia.Name = "comboBox_dia";
            this.comboBox_dia.Size = new System.Drawing.Size(46, 21);
            this.comboBox_dia.TabIndex = 12;
            this.comboBox_dia.Text = "Día";
            // 
            // comboBox_mes
            // 
            this.comboBox_mes.FormattingEnabled = true;
            this.comboBox_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox_mes.Location = new System.Drawing.Point(200, 150);
            this.comboBox_mes.Name = "comboBox_mes";
            this.comboBox_mes.Size = new System.Drawing.Size(77, 21);
            this.comboBox_mes.TabIndex = 13;
            this.comboBox_mes.Text = "Mes";
            // 
            // comboBox_año
            // 
            this.comboBox_año.FormattingEnabled = true;
            this.comboBox_año.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.comboBox_año.Location = new System.Drawing.Point(283, 150);
            this.comboBox_año.Name = "comboBox_año";
            this.comboBox_año.Size = new System.Drawing.Size(59, 21);
            this.comboBox_año.TabIndex = 14;
            this.comboBox_año.Text = "Año";
            // 
            // textBox_liquidacion
            // 
            this.textBox_liquidacion.Location = new System.Drawing.Point(148, 176);
            this.textBox_liquidacion.Name = "textBox_liquidacion";
            this.textBox_liquidacion.Size = new System.Drawing.Size(100, 20);
            this.textBox_liquidacion.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Monto crédito";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Años";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_monto
            // 
            this.textBox_monto.Location = new System.Drawing.Point(148, 202);
            this.textBox_monto.Name = "textBox_monto";
            this.textBox_monto.Size = new System.Drawing.Size(100, 20);
            this.textBox_monto.TabIndex = 18;
            this.textBox_monto.TextChanged += new System.EventHandler(this.textBox_monto_TextChanged);
            // 
            // comboBox_añosCredito
            // 
            this.comboBox_añosCredito.FormattingEnabled = true;
            this.comboBox_añosCredito.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBox_añosCredito.Location = new System.Drawing.Point(148, 229);
            this.comboBox_añosCredito.Name = "comboBox_añosCredito";
            this.comboBox_añosCredito.Size = new System.Drawing.Size(46, 21);
            this.comboBox_añosCredito.TabIndex = 19;
            this.comboBox_añosCredito.Text = "Años";
            this.comboBox_añosCredito.SelectedIndexChanged += new System.EventHandler(this.comboBox_añosCredito_SelectedIndexChanged);
            // 
            // textBox_interes
            // 
            this.textBox_interes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_interes.Location = new System.Drawing.Point(148, 256);
            this.textBox_interes.Name = "textBox_interes";
            this.textBox_interes.ReadOnly = true;
            this.textBox_interes.Size = new System.Drawing.Size(100, 20);
            this.textBox_interes.TabIndex = 20;
            this.textBox_interes.TextChanged += new System.EventHandler(this.textBox_interes_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Interés";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(12, 339);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(111, 23);
            this.calcular.TabIndex = 22;
            this.calcular.Text = "Calcular interès";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cuota";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox_cuota
            // 
            this.textBox_cuota.ForeColor = System.Drawing.Color.Black;
            this.textBox_cuota.Location = new System.Drawing.Point(148, 283);
            this.textBox_cuota.Name = "textBox_cuota";
            this.textBox_cuota.ReadOnly = true;
            this.textBox_cuota.Size = new System.Drawing.Size(100, 20);
            this.textBox_cuota.TabIndex = 24;
            this.textBox_cuota.TextChanged += new System.EventHandler(this.textBox_cuota_TextChanged);
            // 
            // ventana_creditoHipotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 413);
            this.Controls.Add(this.textBox_cuota);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_interes);
            this.Controls.Add(this.comboBox_añosCredito);
            this.Controls.Add(this.textBox_monto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_liquidacion);
            this.Controls.Add(this.comboBox_año);
            this.Controls.Add(this.comboBox_mes);
            this.Controls.Add(this.comboBox_dia);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_apellidop);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_rut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ventana_creditoHipotecario";
            this.Text = "ventana_creditoHipotecario";
            this.Load += new System.EventHandler(this.ventana_creditoHipotecario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_rut;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellidop;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.ComboBox comboBox_dia;
        private System.Windows.Forms.ComboBox comboBox_mes;
        private System.Windows.Forms.ComboBox comboBox_año;
        private System.Windows.Forms.TextBox textBox_liquidacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_monto;
        private System.Windows.Forms.ComboBox comboBox_añosCredito;
        private System.Windows.Forms.TextBox textBox_interes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_cuota;
    }
}