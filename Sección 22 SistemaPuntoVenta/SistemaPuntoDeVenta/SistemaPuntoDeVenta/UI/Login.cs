using SistemaPuntoDeVenta.Library.Models;
using SistemaPuntoDeVenta.Library.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI
{
    public partial class Login : Form
    {

        public static String Codigo = "";

        public Login()
        {
            InitializeComponent();
        }

        // Curso
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string validar = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password ='{1}'", txtUsuario.Text.Trim(), txtPassword.Text.Trim());
        //        DataSet conectar = Tools.HerramientaConsulta(validar);

        //        Codigo = conectar.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();
        //        string cuenta = conectar.Tables[0].Rows[0]["Account"].ToString().Trim();
        //        string contrasena = conectar.Tables[0].Rows[0]["Password"].ToString().Trim();

        //        if (cuenta == txtUsuario.Text.Trim() && contrasena == txtPassword.Text.Trim())
        //        {
        //            //if (Convert.ToBoolean(conectar.Tables[0].Rows[0]["validar_admin"].ToString().Trim()) == true)
        //            //{
        //            //    Administrador Admin = new Administrador();
        //            //    this.Hide();
        //            //    Admin.Show();
        //            //}
        //            //else
        //            //{
        //            //    Usuario User = new Usuario();
        //            //    this.Hide();
        //            //    User.Show();
        //            //}
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario incorrecto o contraseña incorrectos");
        //        }

        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show("Usuario o contraseña inválidos" + error);
        //    }
        //}

        // Mejorado
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Usuarios WHERE account = @account AND password = @password";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@account", txtUsuario.Text.Trim()),
                    new SqlParameter("@password", txtPassword.Text.Trim())
                };

                DataSet resultado = Tools.HerramientaConsulta(query, parametros);

                if (resultado.Tables[0].Rows.Count > 0)
                {
                    //Codigo = conectar.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();
                    DataRow row = resultado.Tables[0].Rows[0];
                    Codigo = row["IdUsuario"].ToString().Trim();
                    var usuario = new Usuarios
                    {
                        IdUsuario = (int)row["IdUsuario"],
                        Username = row["Username"].ToString(),
                        Account = row["account"].ToString(),
                        Password = row["password"].ToString(),
                        EsAdmin = (bool)row["EsAdmin"],
                    };

                    this.Hide();
                    if (usuario.EsAdmin)
                        new Administrador().Show();
                    else
                        new Usuario().Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
