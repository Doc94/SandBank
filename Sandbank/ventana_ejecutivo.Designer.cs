namespace Sandbank
{
    partial class ventana_ejecutivo
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
            this.button_creditoHipotecario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_creditoHipotecario
            // 
            this.button_creditoHipotecario.Location = new System.Drawing.Point(85, 82);
            this.button_creditoHipotecario.Name = "button_creditoHipotecario";
            this.button_creditoHipotecario.Size = new System.Drawing.Size(120, 23);
            this.button_creditoHipotecario.TabIndex = 0;
            this.button_creditoHipotecario.Text = "Crédito hipotecario";
            this.button_creditoHipotecario.UseVisualStyleBackColor = true;
            this.button_creditoHipotecario.Click += new System.EventHandler(this.button_creditoHipotecario_Click);
            // 
            // ventana_ejecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_creditoHipotecario);
            this.Name = "ventana_ejecutivo";
            this.Text = "ventana_ejecutivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_creditoHipotecario;
    }
}