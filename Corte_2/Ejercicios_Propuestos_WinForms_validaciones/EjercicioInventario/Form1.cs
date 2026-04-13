using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EjercicioInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Al iniciar: el DateTimePicker de vencimiento está deshabilitado
            dtpFechaVencimiento.Enabled = false;
        }

        // ─── EVENTO: CheckBox Perecedero cambia de estado ────────────────────────
        // Habilita o deshabilita el DateTimePicker según si el producto es perecedero
        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
        }

        // ─── BOTÓN: Agregar Producto ─────────────────────────────────────────────
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool esValido = true;

            // 1. Validar Código de Producto: debe comenzar con "PROD-" y tener 4 dígitos
            //    Patrón: PROD-0000 (exactamente PROD- seguido de 4 dígitos)
            if (!Regex.IsMatch(txtCodigo.Text.Trim(), @"^PROD-\d{4}$"))
            {
                errorProvider.SetError(txtCodigo, "El código debe seguir el patrón PROD-0000 (ej: PROD-0123).");
                esValido = false;
            }

            // 2. Validar Nombre del Producto
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider.SetError(txtNombreProducto, "El nombre del producto es obligatorio.");
                esValido = false;
            }

            // 3. Validar Categoría seleccionada
            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCategoria, "Seleccione una categoría.");
                esValido = false;
            }

            // 4. Validación cruzada: Stock Inicial no puede ser menor al Stock Mínimo
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                errorProvider.SetError(numStockInicial,
                    $"El stock inicial ({numStockInicial.Value}) no puede ser menor al stock mínimo ({numStockMinimo.Value}).");
                esValido = false;
            }

            // 5. Validar que al menos un RadioButton de IVA esté seleccionado
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                errorProvider.SetError(groupBoxIVA, "Seleccione un tipo de IVA.");
                esValido = false;
            }

            if (!esValido) return;

            // 6. Determinar el porcentaje de IVA seleccionado
            string tipoIVA = rbExento.Checked  ? "Exento (0%)"  :
                             rbGeneral.Checked ? "General (19%)" :
                                                 "Reducido (5%)";

            // 7. Construir mensaje de confirmación
            string perecedero = chkEsPerecedero.Checked
                ? $"Sí — Vence: {dtpFechaVencimiento.Value:dd/MM/yyyy}"
                : "No";

            MessageBox.Show(
                $"Producto agregado al inventario:\n\n" +
                $"Código:        {txtCodigo.Text.Trim().ToUpper()}\n" +
                $"Nombre:        {txtNombreProducto.Text.Trim()}\n" +
                $"Categoría:     {cmbCategoria.SelectedItem}\n" +
                $"Stock Inicial: {numStockInicial.Value}\n" +
                $"Stock Mínimo:  {numStockMinimo.Value}\n" +
                $"IVA:           {tipoIVA}\n" +
                $"Perecedero:    {perecedero}",
                "Producto Registrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        // ─── BOTÓN: Limpiar ──────────────────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            errorProvider.Clear();
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            cmbCategoria.SelectedIndex = -1;
            numStockInicial.Value = 0;
            numStockMinimo.Value  = 0;
            rbExento.Checked      = false;
            rbGeneral.Checked     = false;
            rbReducido.Checked    = false;
            chkEsPerecedero.Checked       = false;  // Esto también dispara el evento y deshabilita el DTP
            dtpFechaVencimiento.Value     = DateTime.Today;
            dtpFechaVencimiento.Enabled   = false;
            txtCodigo.Focus();
        }
    }
}
