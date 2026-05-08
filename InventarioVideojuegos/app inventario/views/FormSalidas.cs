using System;
using System.Drawing;
using System.Windows.Forms;
using app_inventario.controllers;
using app_inventario.models;

namespace app_inventario.views
{
    public partial class FormSalidas : Form
    {
        private readonly ProductosController _prodCtrl;
        private readonly InventarioController _invCtrl;

        public FormSalidas(ProductosController prodCtrl,
                           InventarioController invCtrl)
        {
            InitializeComponent();
            _prodCtrl = prodCtrl;
            _invCtrl = invCtrl;
            CargarCombo();
            CargarHistorial();
        }

        private void CargarCombo()
        {
            cmbProducto.Items.Clear();
            foreach (var vj in _prodCtrl.ObtenerTodos())
                cmbProducto.Items.Add(vj);
        }

        private void CargarHistorial()
        {
            dgv.Rows.Clear();
            foreach (var m in _invCtrl.ObtenerSalidas())
                dgv.Rows.Add(m.Fecha.ToString("dd/MM/yyyy"),
                             m.CodigoProducto, m.Cantidad, m.Observacion);
            lblStatus.Text = $"Salidas registradas: {dgv.Rows.Count}";
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null) return;
            var vj = (Videojuego)cmbProducto.SelectedItem;
            int stock = _invCtrl.CalcularStock(vj.Codigo);
            lblStockInfo.Text = $"📦  Stock disponible: {stock} unidades";
            lblStockInfo.ForeColor = stock <= 5
                ? Color.FromArgb(192, 57, 43)
                : Color.FromArgb(39, 130, 60);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un videojuego.",
                    "Campo requerido", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var vj = (Videojuego)cmbProducto.SelectedItem;
            var m = new Movimiento(vj.Codigo, (int)nudCantidad.Value,
                                    txtObs.Text.Trim(), TipoMovimiento.Salida);

            if (!_invCtrl.RegistrarSalida(m))
            {
                int stock = _invCtrl.CalcularStock(vj.Codigo);
                MessageBox.Show(
                    $"Stock insuficiente.\n\n" +
                    $"Disponible:  {stock} unidades\n" +
                    $"Solicitado:  {m.Cantidad} unidades",
                    "Stock insuficiente", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Salida registrada correctamente.",
                "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbProducto.SelectedIndex = -1;
            nudCantidad.Value = 1;
            txtObs.Clear();
            lblStockInfo.Text = "Selecciona un videojuego para ver el stock";
            lblStockInfo.ForeColor = Color.Gray;
            CargarHistorial();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCombo();
            CargarHistorial();
        }
    }
}