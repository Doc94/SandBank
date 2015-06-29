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
            this.textBox_inicio_sueldo = new System.Windows.Forms.TextBox();
            this.textBox_inicio_fecha = new System.Windows.Forms.TextBox();
            this.textBox_inicio_direccion = new System.Windows.Forms.TextBox();
            this.textBox_inicio_apellido = new System.Windows.Forms.TextBox();
            this.textBox_inicio_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_transferencia_comentario = new System.Windows.Forms.TextBox();
            this.lblbl = new System.Windows.Forms.Label();
            this.button_transferir = new System.Windows.Forms.Button();
            this.textBox_transferencia_monto = new System.Windows.Forms.TextBox();
            this.textBox_transferencia_rutdestiono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(656, 531);
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
            this.tabPage1.Size = new System.Drawing.Size(734, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_inicio_sueldo
            // 
            this.textBox_inicio_sueldo.Location = new System.Drawing.Point(83, 265);
            this.textBox_inicio_sueldo.Name = "textBox_inicio_sueldo";
            this.textBox_inicio_sueldo.ReadOnly = true;
            this.textBox_inicio_sueldo.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_sueldo.TabIndex = 9;
            // 
            // textBox_inicio_fecha
            // 
            this.textBox_inicio_fecha.Location = new System.Drawing.Point(83, 234);
            this.textBox_inicio_fecha.Name = "textBox_inicio_fecha";
            this.textBox_inicio_fecha.ReadOnly = true;
            this.textBox_inicio_fecha.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_fecha.TabIndex = 8;
            // 
            // textBox_inicio_direccion
            // 
            this.textBox_inicio_direccion.Location = new System.Drawing.Point(83, 205);
            this.textBox_inicio_direccion.Name = "textBox_inicio_direccion";
            this.textBox_inicio_direccion.ReadOnly = true;
            this.textBox_inicio_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_direccion.TabIndex = 7;
            // 
            // textBox_inicio_apellido
            // 
            this.textBox_inicio_apellido.Location = new System.Drawing.Point(83, 173);
            this.textBox_inicio_apellido.Name = "textBox_inicio_apellido";
            this.textBox_inicio_apellido.ReadOnly = true;
            this.textBox_inicio_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_apellido.TabIndex = 6;
            // 
            // textBox_inicio_nombre
            // 
            this.textBox_inicio_nombre.Location = new System.Drawing.Point(83, 145);
            this.textBox_inicio_nombre.Name = "textBox_inicio_nombre";
            this.textBox_inicio_nombre.ReadOnly = true;
            this.textBox_inicio_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_inicio_nombre.TabIndex = 5;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cartola";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_transferencia_comentario);
            this.tabPage3.Controls.Add(this.lblbl);
            this.tabPage3.Controls.Add(this.button_transferir);
            this.tabPage3.Controls.Add(this.textBox_transferencia_monto);
            this.tabPage3.Controls.Add(this.textBox_transferencia_rutdestiono);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(734, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transferir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_transferencia_comentario
            // 
            this.textBox_transferencia_comentario.Location = new System.Drawing.Point(116, 121);
            this.textBox_transferencia_comentario.Name = "textBox_transferencia_comentario";
            this.textBox_transferencia_comentario.Size = new System.Drawing.Size(100, 20);
            this.textBox_transferencia_comentario.TabIndex = 6;
            // 
            // lblbl
            // 
            this.lblbl.AutoSize = true;
            this.lblbl.Location = new System.Drawing.Point(21, 121);
            this.lblbl.Name = "lblbl";
            this.lblbl.Size = new System.Drawing.Size(60, 13);
            this.lblbl.TabIndex = 5;
            this.lblbl.Text = "Comentario";
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
            // textBox_transferencia_monto
            // 
            this.textBox_transferencia_monto.Location = new System.Drawing.Point(116, 84);
            this.textBox_transferencia_monto.Name = "textBox_transferencia_monto";
            this.textBox_transferencia_monto.Size = new System.Drawing.Size(100, 20);
            this.textBox_transferencia_monto.TabIndex = 3;
            // 
            // textBox_transferencia_rutdestiono
            // 
            this.textBox_transferencia_rutdestiono.Location = new System.Drawing.Point(116, 51);
            this.textBox_transferencia_rutdestiono.Name = "textBox_transferencia_rutdestiono";
            this.textBox_transferencia_rutdestiono.Size = new System.Drawing.Size(100, 20);
            this.textBox_transferencia_rutdestiono.TabIndex = 2;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "RUT Destinatario";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 224);
            this.dataGridView2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Transferencias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Abonos";
            // 
            // ventana_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 529);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventana_cliente";
            this.Text = "ventana_cliente";
            this.Load += new System.EventHandler(this.ventana_cliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_transferencia_comentario;
        private System.Windows.Forms.Label lblbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;

    }
}