using System;
using System.Windows.Forms;
using app_inventario.controllers;
using app_inventario.models;

namespace app_inventario.views
{
    public partial class FormProductos : Form
    {
        private readonly ProductosController _ctrl;

        public FormProductos(ProductosController ctrl)
        {
            InitializeComponent();
            _ctrl = ctrl;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgv.Rows.Clear();
            foreach (var vj in _ctrl.ObtenerTodos())
                dgv.Rows.Add(vj.Codigo, vj.Nombre, vj.Genero,
                             vj.Plataforma, vj.Precio.ToString("N0"),
                             vj.StockInicial);
            lblStatus.Text = $"Total: {dgv.Rows.Count} videojuego(s)";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Código y Nombre son obligatorios.",
                    "Campos requeridos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var vj = new Videojuego(
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                cmbGenero.Text,
                cmbPlataforma.Text,
                decimal.TryParse(txtPrecio.Text.Trim(), out var p) ? p : 0,
                (int)nudStock.Value
            );

            if (!_ctrl.Agregar(vj))
            {
                MessageBox.Show("Ya existe un videojuego con ese código.",
                    "Código duplicado", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Videojuego guardado correctamente.",
                "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un videojuego para eliminar.",
                    "Sin selección", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string codigo = dgv.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show($"¿Eliminar el videojuego {codigo}?",
                    "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ctrl.Eliminar(codigo);
                CargarTabla();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbPlataforma.SelectedIndex = -1;
            nudStock.Value = 0;
            txtCodigo.Focus();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            var row = dgv.SelectedRows[0];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            cmbGenero.Text = row.Cells[2].Value.ToString();
            cmbPlataforma.Text = row.Cells[3].Value.ToString();
            txtPrecio.Text = row.Cells[4].Value.ToString();
            nudStock.Value = int.TryParse(
                row.Cells[5].Value.ToString(), out var s) ? s : 0;
        }
    }
}