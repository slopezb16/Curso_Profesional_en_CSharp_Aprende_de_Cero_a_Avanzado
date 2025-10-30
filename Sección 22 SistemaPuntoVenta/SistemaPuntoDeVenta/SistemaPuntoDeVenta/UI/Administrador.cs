using SistemaPuntoDeVenta.Library.Utils;
using SistemaPuntoDeVenta.UI.Generales;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI
{
    public partial class Administrador : FormBaseSalir
    {
        public Administrador()
        {
            InitializeComponent();
        }

        //private void Administrador_Load(object sender, EventArgs e)
        //{
        //    string consulta = "SELECT * FROM Usuarios WHERE id_usuario=" + Login.Codigo;
        //    DataSet Data = Tools.HerramientaConsulta(consulta);

        //    labelAdmin2.Text = Data.Tables[0].Rows[0]["username"].ToString();
        //    labelUsuario2.Text = Data.Tables[0].Rows[0]["account"].ToString();
        //    labelCodigo2.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

        //    string imagen = Data.Tables[0].Rows[0]["imagen"].ToString();
        //    pictureBox1.Image = Image.FromFile(imagen);
        //}

        private void Administrador_Load(object sender, EventArgs e)
        {
            try
            {
                // Consulta con parámetro seguro
                string query = "SELECT Username, Account, IdUsuario, Imagen FROM Usuarios WHERE IdUsuario = @IdUsuario";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdUsuario", Convert.ToInt32(Login.Codigo))
                };

                DataSet data = Tools.HerramientaConsulta(query, parametros);

                if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
                {
                    DataRow row = data.Tables[0].Rows[0];

                    labelAdmin2.Text = row["Username"].ToString();
                    labelUsuario2.Text = row["Account"].ToString();
                    labelCodigo2.Text = row["IdUsuario"].ToString();

                    //string rutaBase = Path.Combine(Application.StartupPath, "imagenes", "usuarios");
                    string rutaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\imagenes\usuarios");
                    rutaBase = Path.GetFullPath(rutaBase);
                    string nombreArchivo = row["Imagen"]?.ToString();

                    // Si tiene ruta completa, la usa. Si solo tiene el nombre, se concatena con la ruta base.
                    string rutaFinal = nombreArchivo;
                    if (!string.IsNullOrEmpty(nombreArchivo) && !File.Exists(nombreArchivo))
                        rutaFinal = Path.Combine(rutaBase, nombreArchivo);

                    if (!string.IsNullOrEmpty(rutaFinal) && File.Exists(rutaFinal))
                    {
                        pictureBox1.Image = Image.FromFile(rutaFinal);
                    }
                    else
                    {
                        // Imagen por defecto si no existe
                        pictureBox1.Image = Properties.Resources.icon; // o una imagen en Resources
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del administrador: " + ex.Message);
            }
        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal con_principal = new ContenedorPrincipal();
            this.Hide();
            con_principal.Show();
        }
    }
}
