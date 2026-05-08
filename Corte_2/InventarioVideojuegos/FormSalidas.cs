using System;
using System.IO;
using System.Windows.Forms;

namespace InventarioVideojuegos
{
    public partial class FormSalidas : Form
    {
        private const string CSV_PRODUCTOS = "videojuegos.csv";
        private const string CSV_ENTRADAS  = "entradas.csv";
        private const string CSV_SALIDAS   = "salidas.csv";

        public FormSalidas()
        {
            InitializeComponent();
            VerificarCSV();
            CargarProductosEnCombo();
            CargarHistorialSalidas();
        }

        private void VerificarCSV()
        {
            if (!File.Exists(CSV_SALIDAS))
                File.WriteAllText(CSV_SALIDAS, "Fecha,CodigoProducto,Cantidad,Observacion\n");
        }

        private void CargarProductosEnCombo()
        {
            cmbProducto.Items.Clear();
            if (!File.Exists(CSV_PRODUCTOS)) return;

            string[] lineas = File.ReadAllLines(CSV_PRODUCTOS);
            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i].Trim();
                if (string.IsNullOrEmpty(linea)) continue;
                string[] datos = linea.Split(',');
                if (datos.Length >= 2)
                    cmbProducto.Items.Add($"{datos[0]} — {datos[1]}");
            }
        }

        private int CalcularStockActual(string codigo)
        {
            int stockInicial = 0;
            int totalEntradas = 0;
            int totalSalidas = 0;

            // Stock inicial desde videojuegos.csv
            if (File.Exists(CSV_PRODUCTOS))
            {
                foreach (string linea in File.ReadAllLines(CSV_PRODUCTOS))
                {
                    string[] d = linea.Split(',');
                    if (d.Length >= 6 && d[0] == codigo)
                    {
                        int.TryParse(d[5], out stockInicial);
                        break;
                    }
                }
            }

            // Sumar entradas
            if (File.Exists(CSV_ENTRADAS))
            {
                foreach (string linea in File.ReadAllLines(CSV_ENTRADAS))
                {
                    string[] d = linea.Split(',');
                    if (d.Length >= 3 && d[1] == codigo)
                    {
                        int cant;
                        if (int.TryParse(d[2], out cant)) totalEntradas += cant;
                    }
                }
            }

            // Restar salidas
            if (File.Exists(CSV_SALIDAS))
            {
                foreach (string linea in File.ReadAllLines(CSV_SALIDAS))
                {
                    string[] d = linea.Split(',');
                    if (d.Length >= 3 && d[1] == codigo)
                    {
                        int cant;
                        if (int.TryParse(d[2], out cant)) totalSalidas += cant;
                    }
                }
            }

            return stockInicial + totalEntradas - totalSalidas;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex < 0) return;

            string seleccion = cmbProducto.SelectedItem.ToString();
            string codigo = seleccion.Split('—')[0].Trim();
            int stock = CalcularStockActual(codigo);

            lblStockDisponible.Text = $"📦 Stock disponible: {stock} unidades";

            if (stock <= 5)
                lblStockDisponible.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            else
                lblStockDisponible.ForeColor = System.Drawing.Color.FromArgb(39, 130, 60);
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un videojuego.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccion = cmbProducto.SelectedItem.ToString();
            string codigo = seleccion.Split('—')[0].Trim();
            int cantidadSolicitada = (int)nudCantidad.Value;
            int stockActual = CalcularStockActual(codigo);

            // Validación de stock
            if (cantidadSolicitada > stockActual)
            {
                MessageBox.Show(
                    $"Stock insuficiente.\nDisponible: {stockActual} unidades\nSolicitado: {cantidadSolicitada} unidades",
                    "Stock insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string observacion = txtObservacion.Text.Trim();
            string registro = $"{fecha},{codigo},{cantidadSolicitada},{observacion}\n";

            File.AppendAllText(CSV_SALIDAS, registro);

            MessageBox.Show("Salida registrada exitosamente.", "Salida guardada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            nudCantidad.Value = 1;
            txtObservacion.Clear();
            cmbProducto.SelectedIndex = -1;
            lblStockDisponible.Text = "Selecciona un videojuego para ver el stock disponible";
            lblStockDisponible.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            CargarHistorialSalidas();
        }

        private void CargarHistorialSalidas()
        {
            dgvSalidas.Rows.Clear();
            if (!File.Exists(CSV_SALIDAS)) return;

            string[] lineas = File.ReadAllLines(CSV_SALIDAS);
            int count = 0;

            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i].Trim();
                if (string.IsNullOrEmpty(linea)) continue;
                string[] datos = linea.Split(',');
                if (datos.Length >= 4)
                {
                    dgvSalidas.Rows.Add(datos[0], datos[1], datos[2], datos[3]);
                    count++;
                }
            }

            lblStatusSalidas.Text = $"Total salidas hoy: {count}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductosEnCombo();
            CargarHistorialSalidas();
        }
    }
}
