using System;
using System.Windows.Forms;
using app_inventario.controllers;
using app_inventario.models;

namespace app_inventario.views
{
    public partial class FormEntradas : Form
    {
        private readonly ProductosController _prodCtrl;
        private readonly InventarioController _invCtrl;

        public FormEntradas(ProductosController prodCtrl,
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
            foreach (var m in _invCtrl.ObtenerEntradas())
                dgv.Rows.Add(m.Fecha.ToString("dd/MM/yyyy"),
                             m.CodigoProducto, m.Cantidad, m.Observacion);
            lblStatus.Text = $"Entradas registradas: {dgv.Rows.Count}";
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
                                    txtObs.Text.Trim(), TipoMovimiento.Entrada);
            _invCtrl.RegistrarEntrada(m);

            MessageBox.Show("Entrada registrada correctamente.",
                "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbProducto.SelectedIndex = -1;
            nudCantidad.Value = 1;
            txtObs.Clear();
            CargarHistorial();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCombo();
            CargarHistorial();
        }
    }
}