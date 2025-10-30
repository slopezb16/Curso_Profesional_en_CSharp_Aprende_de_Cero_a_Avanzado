using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI
{
    partial class Administrador
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelAdmin2 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCodigo2 = new System.Windows.Forms.Label();
            this.labelUsuario2 = new System.Windows.Forms.Label();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnAdminUsuarios = new System.Windows.Forms.Button();
            this.btnCambioContrasena = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(804, 457);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(609, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelAdmin
            // 
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelAdmin.Location = new System.Drawing.Point(62, 43);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(200, 30);
            this.labelAdmin.TabIndex = 1;
            this.labelAdmin.Text = "Administrador:";
            // 
            // labelAdmin2
            // 
            this.labelAdmin2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdmin2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin2.Location = new System.Drawing.Point(311, 43);
            this.labelAdmin2.Name = "labelAdmin2";
            this.labelAdmin2.Size = new System.Drawing.Size(200, 30);
            this.labelAdmin2.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUsuario.Location = new System.Drawing.Point(62, 124);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(200, 30);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelCodigo
            // 
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCodigo.Location = new System.Drawing.Point(62, 214);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(200, 30);
            this.labelCodigo.TabIndex = 4;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelCodigo2
            // 
            this.labelCodigo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCodigo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo2.Location = new System.Drawing.Point(311, 214);
            this.labelCodigo2.Name = "labelCodigo2";
            this.labelCodigo2.Size = new System.Drawing.Size(200, 30);
            this.labelCodigo2.TabIndex = 5;
            // 
            // labelUsuario2
            // 
            this.labelUsuario2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario2.Location = new System.Drawing.Point(311, 124);
            this.labelUsuario2.Name = "labelUsuario2";
            this.labelUsuario2.Size = new System.Drawing.Size(200, 30);
            this.labelUsuario2.TabIndex = 6;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Location = new System.Drawing.Point(67, 327);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(110, 44);
            this.btnPrincipal.TabIndex = 7;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.AutoSize = true;
            this.btnAdminUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuarios.Location = new System.Drawing.Point(250, 327);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Size = new System.Drawing.Size(192, 44);
            this.btnAdminUsuarios.TabIndex = 8;
            this.btnAdminUsuarios.Text = "Admin Usuarios";
            this.btnAdminUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCambioContrasena
            // 
            this.btnCambioContrasena.AutoSize = true;
            this.btnCambioContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioContrasena.Location = new System.Drawing.Point(488, 327);
            this.btnCambioContrasena.Name = "btnCambioContrasena";
            this.btnCambioContrasena.Size = new System.Drawing.Size(236, 44);
            this.btnCambioContrasena.TabIndex = 9;
            this.btnCambioContrasena.Text = "Cambio Contrasena";
            this.btnCambioContrasena.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(742, 327);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(172, 44);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPuntoDeVenta.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCambioContrasena);
            this.Controls.Add(this.btnAdminUsuarios);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.labelUsuario2);
            this.Controls.Add(this.labelCodigo2);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelAdmin2);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrador_FormClosed);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.labelAdmin, 0);
            this.Controls.SetChildIndex(this.labelAdmin2, 0);
            this.Controls.SetChildIndex(this.labelUsuario, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.labelCodigo2, 0);
            this.Controls.SetChildIndex(this.labelUsuario2, 0);
            this.Controls.SetChildIndex(this.btnPrincipal, 0);
            this.Controls.SetChildIndex(this.btnAdminUsuarios, 0);
            this.Controls.SetChildIndex(this.btnCambioContrasena, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelAdmin2;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCodigo2;
        private System.Windows.Forms.Label labelUsuario2;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button btnAdminUsuarios;
        private System.Windows.Forms.Button btnCambioContrasena;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}