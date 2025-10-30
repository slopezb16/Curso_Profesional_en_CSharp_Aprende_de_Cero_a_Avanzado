using System.Windows.Forms;

namespace SistemaPuntoDeVenta.Utils
{
    public static class Validator
    {
        public static bool ValidateForm(Control container, ErrorProvider errorProvider)
        {
            bool hasError = false;
            errorProvider.Clear();

            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider.SetError(textBox, "This field cannot be empty.");
                    hasError = true;
                }
            }

            return hasError;
        }
    }
}