using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_2.Utils
{
    public static class Validaciones
    {
        public static bool ValidarRequerido(Control control, string nombreCampo)
        {
            string texto = ObtenerTexto(control);

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show($"{nombreCampo} es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarComboBoxRequerido(ComboBox comboBox, string nombreCampo)
        {
            if (comboBox.SelectedValue == null || comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"Debe seleccionar un {nombreCampo}.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarFormatoCorreo(Control control)
        {
            string texto = ObtenerTexto(control);

            if (string.IsNullOrWhiteSpace(texto))
                return true; 

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El formato del correo no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

      
        public static bool ValidarLongitudMinima(Control control, string nombreCampo, int longitudMinima)
        {
            string texto = ObtenerTexto(control);

            if (!string.IsNullOrWhiteSpace(texto) && texto.Length < longitudMinima)
            {
                MessageBox.Show($"{nombreCampo} debe tener al menos {longitudMinima} caracteres.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarLongitudMaxima(Control control, string nombreCampo, int longitudMaxima)
        {
            string texto = ObtenerTexto(control);

            if (!string.IsNullOrWhiteSpace(texto) && texto.Length > longitudMaxima)
            {
                MessageBox.Show($"{nombreCampo} no puede exceder {longitudMaxima} caracteres.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarSoloNumeros(Control control, string nombreCampo)
        {
            string texto = ObtenerTexto(control);

            if (!string.IsNullOrWhiteSpace(texto) && !Regex.IsMatch(texto, @"^\d+$"))
            {
                MessageBox.Show($"{nombreCampo} debe contener solo números.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarSoloLetras(Control control, string nombreCampo)
        {
            string texto = ObtenerTexto(control);

            if (!string.IsNullOrWhiteSpace(texto) && !Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show($"{nombreCampo} debe contener solo letras.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarRangoNumerico(Control control, string nombreCampo, decimal minimo, decimal maximo)
        {
            string texto = ObtenerTexto(control);

            if (!string.IsNullOrWhiteSpace(texto))
            {
                if (decimal.TryParse(texto, out decimal valor))
                {
                    if (valor < minimo || valor > maximo)
                    {
                        MessageBox.Show($"{nombreCampo} debe estar entre {minimo} y {maximo}.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show($"{nombreCampo} debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarFecha(DateTimePicker dateTimePicker, string nombreCampo,
            DateTime? fechaMinima = null, DateTime? fechaMaxima = null)
        {
            DateTime fecha = dateTimePicker.Value;

            if (fechaMinima.HasValue && fecha < fechaMinima.Value)
            {
                MessageBox.Show($"{nombreCampo} no puede ser anterior a {fechaMinima.Value:dd/MM/yyyy}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker.Focus();
                return false;
            }

            if (fechaMaxima.HasValue && fecha > fechaMaxima.Value)
            {
                MessageBox.Show($"{nombreCampo} no puede ser posterior a {fechaMaxima.Value:dd/MM/yyyy}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker.Focus();
                return false;
            }

            return true;
        }

        public static bool ValidarPatron(Control control, string nombreCampo, string patron, string mensajeError)
        {
            string texto = ObtenerTexto(control);

            if (!string.IsNullOrWhiteSpace(texto) && !Regex.IsMatch(texto, patron))
            {
                MessageBox.Show(mensajeError, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }

        private static string ObtenerTexto(Control control)
        {
            var propTexts = control.GetType().GetProperty("Texts");
            if (propTexts != null)
            {
                return propTexts.GetValue(control)?.ToString() ?? string.Empty;
            }

            return control.Text;
        }

        public static bool ValidarTodos(params Func<bool>[] validaciones)
        {
            foreach (var validacion in validaciones)
            {
                if (!validacion())
                    return false;
            }
            return true;
        }
    }
}
