namespace SistemaPuntoDeVenta.UI.Generales
{
    partial class MantenimientoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoClientes));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelId_Cliente = new System.Windows.Forms.Label();
            this.textId_Cliente = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textApellido = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textNombre = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(347, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 55);
            this.label4.TabIndex = 43;
            this.label4.Text = "CLIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(692, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 198);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(92, 188);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(200, 30);
            this.labelNombre.TabIndex = 56;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelApellido.Location = new System.Drawing.Point(92, 261);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(200, 30);
            this.labelApellido.TabIndex = 55;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelId_Cliente
            // 
            this.labelId_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.labelId_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId_Cliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelId_Cliente.Location = new System.Drawing.Point(92, 113);
            this.labelId_Cliente.Name = "labelId_Cliente";
            this.labelId_Cliente.Size = new System.Drawing.Size(200, 30);
            this.labelId_Cliente.TabIndex = 54;
            this.labelId_Cliente.Text = "Id_Cliente:";
            // 
            // textId_Cliente
            // 
            this.textId_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId_Cliente.Location = new System.Drawing.Point(267, 108);
            this.textId_Cliente.Name = "textId_Cliente";
            this.textId_Cliente.Size = new System.Drawing.Size(215, 35);
            this.textId_Cliente.TabIndex = 60;
            this.textId_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textId_Cliente.Validar = true;
            this.textId_Cliente.ValidarNumeros = true;
            this.textId_Cliente.TextChanged += new System.EventHandler(this.textId_Cliente_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(267, 256);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(215, 35);
            this.textApellido.TabIndex = 61;
            this.textApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textApellido.Validar = true;
            this.textApellido.ValidarNumeros = false;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(267, 183);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(215, 35);
            this.textNombre.TabIndex = 62;
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNombre.Validar = true;
            this.textNombre.ValidarNumeros = false;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textId_Cliente);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelId_Cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.labelId_Cliente, 0);
            this.Controls.SetChildIndex(this.labelApellido, 0);
            this.Controls.SetChildIndex(this.labelNombre, 0);
            this.Controls.SetChildIndex(this.textId_Cliente, 0);
            this.Controls.SetChildIndex(this.textApellido, 0);
            this.Controls.SetChildIndex(this.textNombre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelId_Cliente;
        private Library.Utils.ErrorTxtBox textId_Cliente;
        private Library.Utils.ErrorTxtBox textApellido;
        private Library.Utils.ErrorTxtBox textNombre;
    }
}