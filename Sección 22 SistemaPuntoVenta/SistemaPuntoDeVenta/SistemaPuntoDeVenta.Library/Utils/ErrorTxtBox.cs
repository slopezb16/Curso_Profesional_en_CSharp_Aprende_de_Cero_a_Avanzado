using System;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.Library.Utils
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }

        public Boolean Validar
        {
            set;
            get;
        }
        public Boolean ValidarNumeros
        {
            set;
            get;
        }
    }
}
