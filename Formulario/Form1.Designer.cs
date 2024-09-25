namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ImprimirQR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ImprimirQR
            // 
            this.btn_ImprimirQR.Location = new System.Drawing.Point(257, 81);
            this.btn_ImprimirQR.Name = "btn_ImprimirQR";
            this.btn_ImprimirQR.Size = new System.Drawing.Size(214, 159);
            this.btn_ImprimirQR.TabIndex = 0;
            this.btn_ImprimirQR.Text = "Generar QR";
            this.btn_ImprimirQR.UseVisualStyleBackColor = true;
            this.btn_ImprimirQR.Click += new System.EventHandler(this.btn_ImprimirQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ImprimirQR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ImprimirQR;
    }
}

