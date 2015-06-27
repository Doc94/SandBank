namespace Sandbank
{
    partial class ventana_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_cliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_inicio_nombre = new System.Windows.Forms.TextBox();
            this.textBox_inicio_apellido = new System.Windows.Forms.TextBox();
            this.textBox_inicio_direccion = new System.Windows.Forms.TextBox();
            this.textBox_inicio_fecha = new System.Windows.Forms.TextBox();
            this.textBox_inicio_sueldo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_transferencia_rutdestiono = new System.Windows.Forms.TextBox();
            this.textBox_transferencia_monto = new System.Windows.Forms.TextBox();
            this.button_transferir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 453);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_inicio_sueldo);
            this.tabPage1.Controls.Add(this.textBox_inicio_fecha);
            this.tabPage1.Controls.Add(this.textBox_inicio_direccion);
            this.tabPage1.Controls.Add(this.textBox_inicio_apellido);
            this.tabPage1.Controls.Add(this.textBox_inicio_nombre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cartola";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo";
            // 
            // textBox_inicio_nombre
            // 
            this.textBox_inicio_nombre.Location = new System.Drawing.Point(83, 145);
            this.textBox_inicio_nombre.Name = "textBox_inicio_nombre";
            this.textBox_inicio_nombre.ReadOnly = true;
            this.textBox_inicio_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_nombre.TabIndex = 5;
            // 
            // textBox_inicio_apellido
            // 
            this.textBox_inicio_apellido.Location = new System.Drawing.Point(83, 173);
            this.textBox_inicio_apellido.Name = "textBox_inicio_apellido";
            this.textBox_inicio_apellido.ReadOnly = true;
            this.textBox_inicio_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_apellido.TabIndex = 6;
            // 
            // textBox_inicio_direccion
            // 
            this.textBox_inicio_direccion.Location = new System.Drawing.Point(83, 205);
            this.textBox_inicio_direccion.Name = "textBox_inicio_direccion";
            this.textBox_inicio_direccion.ReadOnly = true;
            this.textBox_inicio_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_direccion.TabIndex = 7;
            // 
            // textBox_inicio_fecha
            // 
            this.textBox_inicio_fecha.Location = new System.Drawing.Point(83, 234);
            this.textBox_inicio_fecha.Name = "textBox_inicio_fecha";
            this.textBox_inicio_fecha.ReadOnly = true;
            this.textBox_inicio_fecha.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_fecha.TabIndex = 8;
            // 
            // textBox_inicio_sueldo
            // 
            this.textBox_inicio_sueldo.Location = new System.Drawing.Point(83, 265);
            this.textBox_inicio_sueldo.Name = "textBox_inicio_sueldo";
            this.textBox_inicio_sueldo.ReadOnly = true;
            this.textBox_inicio_sueldo.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_sueldo.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_transferir);
            this.tabPage3.Controls.Add(this.textBox_transferencia_monto);
            this.tabPage3.Controls.Add(this.textBox_transferencia_rutdestiono);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transferir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "RUT Destinatario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Monto a Transferir";
            // 
            // textBox_transferencia_rutdestiono
            // 
            this.textBox_transferencia_rutdestiono.Location = new System.Drawing.Point(116, 51);
            this.textBox_transferencia_rutdestiono.Name = "textBox_transferencia_rutdestiono";
            this.textBox_transferencia_rutdestiono.Size = new System.Drawing.Size(100, 20);
            this.textBox_transferencia_rutdestiono.TabIndex = 2;
            // 
            // textBox_transferencia_monto
            // 
            this.textBox_transferencia_monto.Location = new System.Drawing.Point(116, 84);
            this.textBox_transferencia_monto.Name = "textBox_transferencia_monto";
            this.textBox_transferencia_monto.Size = new System.Drawing.Size(100, 20);
            this.textBox_transferencia_monto.TabIndex = 3;
            // 
            // button_transferir
            // 
            this.button_transferir.Location = new System.Drawing.Point(287, 71);
            this.button_transferir.Name = "button_transferir";
            this.button_transferir.Size = new System.Drawing.Size(75, 23);
            this.button_transferir.TabIndex = 4;
            this.button_transferir.Text = "Transferir";
            this.button_transferir.UseVisualStyleBackColor = true;
            this.button_transferir.Click += new System.EventHandler(this.button_transferir_Click);
            // 
            // ventana_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 452);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventana_cliente";
            this.Text = "ventana_cliente";
            this.Load += new System.EventHandler(this.ventana_cliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_inicio_sueldo;
        private System.Windows.Forms.TextBox textBox_inicio_fecha;
        private System.Windows.Forms.TextBox textBox_inicio_direccion;
        private System.Windows.Forms.TextBox textBox_inicio_apellido;
        private System.Windows.Forms.TextBox textBox_inicio_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_transferencia_monto;
        private System.Windows.Forms.TextBox textBox_transferencia_rutdestiono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_transferir;

    }
}