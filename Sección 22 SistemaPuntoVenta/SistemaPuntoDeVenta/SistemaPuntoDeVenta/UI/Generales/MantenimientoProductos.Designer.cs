namespace SistemaPuntoDeVenta.UI.Generales
{
    partial class MantenimientoProductos
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
            this.label4 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textId_Articulo = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textNombre = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textCodigo = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textPrecio = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textStock = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            this.textDescripcion = new SistemaPuntoDeVenta.Library.Utils.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            //this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(297, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 55);
            this.label4.TabIndex = 43;
            this.label4.Text = "PRODUCTOS";
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(48, 284);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(200, 30);
            this.labelNombre.TabIndex = 47;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCodigo.Location = new System.Drawing.Point(48, 194);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(200, 30);
            this.labelCodigo.TabIndex = 46;
            this.labelCodigo.Text = "Codigo:";
            // 
            // labelAdmin
            // 
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelAdmin.Location = new System.Drawing.Point(48, 113);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(200, 30);
            this.labelAdmin.TabIndex = 44;
            this.labelAdmin.Text = "Id_Articulo:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDescripcion.Location = new System.Drawing.Point(479, 115);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(200, 30);
            this.labelDescripcion.TabIndex = 54;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelStock
            // 
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStock.Location = new System.Drawing.Point(479, 286);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(200, 30);
            this.labelStock.TabIndex = 56;
            this.labelStock.Text = "Stock:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecio.Location = new System.Drawing.Point(479, 199);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(200, 30);
            this.labelPrecio.TabIndex = 58;
            this.labelPrecio.Text = "Precio:";
            // 
            // textId_Articulo
            // 
            this.textId_Articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId_Articulo.Location = new System.Drawing.Point(223, 108);
            this.textId_Articulo.Name = "textId_Articulo";
            this.textId_Articulo.Size = new System.Drawing.Size(215, 35);
            this.textId_Articulo.TabIndex = 61;
            this.textId_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textId_Articulo.Validar = true;
            this.textId_Articulo.ValidarNumeros = true;
            this.textId_Articulo.TextChanged += new System.EventHandler(this.textId_Articulo_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(223, 279);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(215, 35);
            this.textNombre.TabIndex = 63;
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNombre.Validar = true;
            this.textNombre.ValidarNumeros = false;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(223, 189);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(215, 35);
            this.textCodigo.TabIndex = 64;
            this.textCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCodigo.Validar = true;
            this.textCodigo.ValidarNumeros = false;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(654, 194);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(215, 35);
            this.textPrecio.TabIndex = 65;
            this.textPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPrecio.Validar = true;
            this.textPrecio.ValidarNumeros = false;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // textStock
            // 
            this.textStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStock.Location = new System.Drawing.Point(654, 281);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(215, 35);
            this.textStock.TabIndex = 66;
            this.textStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textStock.Validar = true;
            this.textStock.ValidarNumeros = false;
            this.textStock.TextChanged += new System.EventHandler(this.textStock_TextChanged);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(654, 85);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(215, 60);
            this.textDescripcion.TabIndex = 67;
            this.textDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDescripcion.Validar = true;
            this.textDescripcion.ValidarNumeros = false;
            this.textDescripcion.TextChanged += new System.EventHandler(this.textDescripcion_TextChanged);
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId_Articulo);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.label4);
            this.Name = "MantenimientoProductos";
            this.Text = "MantenimientoProductos";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.labelAdmin, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.labelNombre, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.labelDescripcion, 0);
            this.Controls.SetChildIndex(this.labelStock, 0);
            this.Controls.SetChildIndex(this.labelPrecio, 0);
            this.Controls.SetChildIndex(this.textId_Articulo, 0);
            this.Controls.SetChildIndex(this.textNombre, 0);
            this.Controls.SetChildIndex(this.textCodigo, 0);
            this.Controls.SetChildIndex(this.textPrecio, 0);
            this.Controls.SetChildIndex(this.textStock, 0);
            this.Controls.SetChildIndex(this.textDescripcion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private Library.Utils.ErrorTxtBox textId_Articulo;
        private Library.Utils.ErrorTxtBox textNombre;
        private Library.Utils.ErrorTxtBox textCodigo;
        private Library.Utils.ErrorTxtBox textPrecio;
        private Library.Utils.ErrorTxtBox textStock;
        private Library.Utils.ErrorTxtBox textDescripcion;
    }
}