namespace SistemaPuntoDeVenta
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
            this.Consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Consulta
            // 
            this.Consulta.BackColor = System.Drawing.Color.Aquamarine;
            this.Consulta.Location = new System.Drawing.Point(302, 288);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(171, 51);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = false;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consulta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Consulta;
    }
}

