using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class LoginMejorado : Form
    {
        public LoginMejorado()
        {
            InitializeComponent();
        }

        private void LoginMejorado_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "admin" && contrasena == "1234")
            {
                MessageBox.Show("✅ Bienvenido, acceso permitido.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí podrías abrir otro formulario si quieres
            }
            else
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la app
        }

    }
}
