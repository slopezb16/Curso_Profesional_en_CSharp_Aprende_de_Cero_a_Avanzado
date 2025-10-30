using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI
{
    partial class Usuario
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCambioContrasena = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.labelUsuario2 = new System.Windows.Forms.Label();
            this.labelCodigo2 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(764, 459);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(702, 321);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(172, 44);
            this.btnCerrarSesion.TabIndex = 22;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnCambioContrasena
            // 
            this.btnCambioContrasena.AutoSize = true;
            this.btnCambioContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioContrasena.Location = new System.Drawing.Point(347, 321);
            this.btnCambioContrasena.Name = "btnCambioContrasena";
            this.btnCambioContrasena.Size = new System.Drawing.Size(236, 44);
            this.btnCambioContrasena.TabIndex = 21;
            this.btnCambioContrasena.Text = "Cambio Contrasena";
            this.btnCambioContrasena.UseVisualStyleBackColor = true;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Location = new System.Drawing.Point(56, 321);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(110, 44);
            this.btnPrincipal.TabIndex = 19;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // labelUsuario2
            // 
            this.labelUsuario2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario2.Location = new System.Drawing.Point(300, 118);
            this.labelUsuario2.Name = "labelUsuario2";
            this.labelUsuario2.Size = new System.Drawing.Size(200, 30);
            this.labelUsuario2.TabIndex = 18;
            // 
            // labelCodigo2
            // 
            this.labelCodigo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCodigo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo2.Location = new System.Drawing.Point(300, 208);
            this.labelCodigo2.Name = "labelCodigo2";
            this.labelCodigo2.Size = new System.Drawing.Size(200, 30);
            this.labelCodigo2.TabIndex = 17;
            // 
            // labelCodigo
            // 
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCodigo.Location = new System.Drawing.Point(51, 208);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(200, 30);
            this.labelCodigo.TabIndex = 16;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelUsuario
            // 
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUsuario.Location = new System.Drawing.Point(51, 118);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(200, 30);
            this.labelUsuario.TabIndex = 15;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelNombre2
            // 
            this.labelNombre2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombre2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.Location = new System.Drawing.Point(300, 37);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(200, 30);
            this.labelNombre2.TabIndex = 14;
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(51, 37);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(200, 30);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(598, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPuntoDeVenta.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCambioContrasena);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.labelUsuario2);
            this.Controls.Add(this.labelCodigo2);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelNombre2);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.labelNombre, 0);
            this.Controls.SetChildIndex(this.labelNombre2, 0);
            this.Controls.SetChildIndex(this.labelUsuario, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.labelCodigo2, 0);
            this.Controls.SetChildIndex(this.labelUsuario2, 0);
            this.Controls.SetChildIndex(this.btnPrincipal, 0);
            this.Controls.SetChildIndex(this.btnCambioContrasena, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCambioContrasena;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Label labelUsuario2;
        private System.Windows.Forms.Label labelCodigo2;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}