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
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_inicio_cupo = new System.Windows.Forms.TextBox();
            this.textBox__inicio_saldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_transferencia_comentario = new System.Windows.Forms.TextBox();
            this.lblbl = new System.Windows.Forms.Label();
            this.button_transferir = new System.Windows.Forms.Button();
            this.textBox_transferencia_monto = new System.Windows.Forms.TextBox();
            this.textBox_transferencia_rutdestiono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(656, 531);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox_inicio_cupo);
            this.tabPage1.Controls.Add(this.textBox__inicio_saldo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnCerrarSesion);
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
            this.tabPage1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Crédito";
            // 
            // textBox_inicio_cupo
            // 
            this.textBox_inicio_cupo.Location = new System.Drawing.Point(83, 331);
            this.textBox_inicio_cupo.Name = "textBox_inicio_cupo";
            this.textBox_inicio_cupo.ReadOnly = true;
            this.textBox_inicio_cupo.Size = new System.Drawing.Size(100, 23);
            this.textBox_inicio_cupo.TabIndex = 14;
            // 
            // textBox__inicio_saldo
            // 
            this.textBox__inicio_saldo.Location = new System.Drawing.Point(83, 298);
            this.textBox__inicio_saldo.Name = "textBox__inicio_saldo";
            this.textBox__inicio_saldo.ReadOnly = true;
            this.textBox__inicio_saldo.Size = new System.Drawing.Size(100, 23);
            this.textBox__inicio_saldo.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Saldo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sandbank.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(200, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrarSesion.Location = new System.Drawing.Point(310, 331);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 27);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_inicio_sueldo
            // 
            this.textBox_inicio_sueldo.Location = new System.Drawing.Point(83, 265);
            this.textBox_inicio_sueldo.Name = "textBox_inicio_sueldo";
            this.textBox_inicio_sueldo.ReadOnly = true;
            this.textBox_inicio_sueldo.Size = new System.Drawing.Size(100, 23);
            this.textBox_inicio_sueldo.TabIndex = 9;
            // 
            // textBox_inicio_fecha
            // 
            this.textBox_inicio_fecha.Location = new System.Drawing.Point(83, 234);
            this.textBox_inicio_fecha.Name = "textBox_inicio_fecha";
            this.textBox_inicio_fecha.ReadOnly = true;
            this.textBox_inicio_fecha.Size = new System.Drawing.Size(100, 23);
            this.textBox_inicio_fecha.TabIndex = 8;
            // 
            // textBox_inicio_direccion
            // 
            this.textBox_inicio_direccion.Location = new System.Drawing.Point(83, 205);
            this.textBox_inicio_direccion.Name = "textBox_inicio_direccion";
            this.textBox_inicio_direccion.ReadOnly = true;
            this.textBox_inicio_direccion.Size = new System.Drawing.Size(100, 23);
            this.textBox_inicio_direccion.TabIndex = 7;
            // 
            // textBox_inicio_apellido
            // 
            this.textBox_inicio_apellido.Location = new System.Drawing.Point(83, 173);
            this.textBox_inicio_apellido.Name = "textBox_inicio_apellido";
            this.textBox_inicio_apellido.ReadOnly = true;
            this.textBox_inicio_apellido.Size = new System.Drawing.Size(100, 23);
            this.textBox_inicio_apellido.TabIndex = 6;
            // 
            // textBox_inicio_nombre
            // 
            this.textBox_inicio_nombre.Location = new System.Drawing.Point(83, 145);
            this.textBox_inicio_nombre.Name = "textBox_inicio_nombre";
            this.textBox_inicio_nombre.ReadOnly = true;
            this.textBox_inicio_nombre.Size = new System.Drawing.Size(100, 23);
            this.textBox_inicio_nombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Abonos";
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
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(645, 224);
            this.dataGridView2.TabIndex = 1;
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
            this.tabPage3.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage3.Controls.Add(this.textBox_transferencia_comentario);
            this.tabPage3.Controls.Add(this.lblbl);
            this.tabPage3.Controls.Add(this.button_transferir);
            this.tabPage3.Controls.Add(this.textBox_transferencia_monto);
            this.tabPage3.Controls.Add(this.textBox_transferencia_rutdestiono);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(648, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transferir";
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
            this.textBox_transferencia_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_transferencia_monto_KeyPress);
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
            // ventana_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(655, 529);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventana_cliente";
            this.Text = "Cliente sandbank";
            this.Load += new System.EventHandler(this.ventana_cliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_transferencia_comentario;
        private System.Windows.Forms.Label lblbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_inicio_cupo;
        private System.Windows.Forms.TextBox textBox__inicio_saldo;
        private System.Windows.Forms.Label label10;

    }
}