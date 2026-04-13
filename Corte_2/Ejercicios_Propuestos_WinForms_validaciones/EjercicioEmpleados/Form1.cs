using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EjercicioEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ─── BOTÓN: Registrar ────────────────────────────────────────────────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Limpiar errores previos antes de volver a validar
            errorProvider.Clear();

            bool esValido = true;

            // 1. Validar campos obligatorios de texto
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider.SetError(txtNombres, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Los apellidos son obligatorios.");
                esValido = false;
            }

            // 2. Validar formato de Email con Regex
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "El email es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                errorProvider.SetError(txtEmail, "El email debe tener un formato válido (ej: usuario@dominio.com).");
                esValido = false;
            }

            // 3. Validar Identificación: exactamente 10 dígitos numéricos
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                errorProvider.SetError(txtIdentificacion, "La identificación es obligatoria.");
                esValido = false;
            }
            else if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                errorProvider.SetError(txtIdentificacion, "La identificación debe tener exactamente 10 dígitos numéricos.");
                esValido = false;
            }

            // 4. Validar que se haya seleccionado un departamento
            if (cmbDepartamento.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbDepartamento, "Seleccione un departamento.");
                esValido = false;
            }

            // Si hay algún error, no continuar
            if (!esValido) return;

            // 5. Lógica de negocio: calcular sueldo neto con 10% de retención
            double sueldoBase = (double)numSueldoBase.Value;
            double retencion  = sueldoBase * 0.10;
            double sueldoNeto = sueldoBase - retencion;

            // Mostrar resultado en el label con formato de moneda
            lblResultadoSueldo.Text =
                $"Sueldo Base: {sueldoBase:C}  |  Retención (10%): {retencion:C}  |  Sueldo Neto: {sueldoNeto:C}";
            lblResultadoSueldo.ForeColor = System.Drawing.Color.DarkGreen;

            MessageBox.Show(
                $"Empleado registrado exitosamente.\n\n" +
                $"Nombre: {txtNombres.Text} {txtApellidos.Text}\n" +
                $"Departamento: {cmbDepartamento.SelectedItem}\n" +
                $"Sueldo Neto: {sueldoNeto:C}",
                "Registro Exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ─── BOTÓN: Limpiar ──────────────────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();
            numSueldoBase.Value = numSueldoBase.Minimum;
            cmbDepartamento.SelectedIndex = -1;
            lblResultadoSueldo.Text = "El sueldo neto se mostrará aquí tras el registro.";
            lblResultadoSueldo.ForeColor = System.Drawing.Color.Gray;

            txtNombres.Focus();
        }
    }
}
