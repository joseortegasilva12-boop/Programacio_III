using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InventarioVideojuegos
{
    public partial class FormInformes : Form
    {
        private const string CSV_PRODUCTOS = "videojuegos.csv";
        private const string CSV_ENTRADAS  = "entradas.csv";
        private const string CSV_SALIDAS   = "salidas.csv";

        public FormInformes()
        {
            InitializeComponent();
            CargarFiltroProductos();
            CargarInformes();
        }

        private void CargarFiltroProductos()
        {
            cmbFiltroProducto.Items.Clear();
            cmbFiltroProducto.Items.Add("— Todos los videojuegos —");

            if (!File.Exists(CSV_PRODUCTOS)) return;

            string[] lineas = File.ReadAllLines(CSV_PRODUCTOS);
            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i].Trim();
                if (string.IsNullOrEmpty(linea)) continue;
                string[] datos = linea.Split(',');
                if (datos.Length >= 2)
                    cmbFiltroProducto.Items.Add($"{datos[0]} — {datos[1]}");
            }

            cmbFiltroProducto.SelectedIndex = 0;
        }

        private void CargarInformes()
        {
            string filtroCodigo = "";
            if (cmbFiltroProducto.SelectedIndex > 0)
                filtroCodigo = cmbFiltroProducto.SelectedItem.ToString().Split('—')[0].Trim();

            string filtroTipo = cmbFiltroTipo.SelectedItem?.ToString() ?? "Todos";

            dgvMovimientos.Rows.Clear();

            // Cargar productos
            var productos = new Dictionary<string, string[]>();
            if (File.Exists(CSV_PRODUCTOS))
            {
                foreach (string linea in File.ReadAllLines(CSV_PRODUCTOS))
                {
                    string[] d = linea.Split(',');
                    if (d.Length >= 6 && d[0] != "Codigo")
                        productos[d[0]] = d;
                }
            }

            int totalEntradas = 0;
            int totalSalidas = 0;

            // Cargar entradas
            if (File.Exists(CSV_ENTRADAS) && filtroTipo != "Solo Salidas")
            {
                foreach (string linea in File.ReadAllLines(CSV_ENTRADAS))
                {
                    string[] d = linea.Split(',');
                    if (d.Length < 4 || d[0] == "Fecha") continue;
                    if (!string.IsNullOrEmpty(filtroCodigo) && d[1] != filtroCodigo) continue;

                    string nombre = productos.ContainsKey(d[1]) ? productos[d[1]][1] : d[1];
                    int cant;
                    int.TryParse(d[2], out cant);
                    totalEntradas += cant;

                    int stockActual = CalcularStock(d[1], productos);
                    dgvMovimientos.Rows.Add(d[0], "▲ Entrada", d[1], nombre, "+" + d[2], stockActual);

                    // Color verde para entradas
                    int rowIdx = dgvMovimientos.Rows.Count - 1;
                    dgvMovimientos.Rows[rowIdx].Cells["colTipo"].Style.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
                    dgvMovimientos.Rows[rowIdx].Cells["colCantidad"].Style.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
                }
            }

            // Cargar salidas
            if (File.Exists(CSV_SALIDAS) && filtroTipo != "Solo Entradas")
            {
                foreach (string linea in File.ReadAllLines(CSV_SALIDAS))
                {
                    string[] d = linea.Split(',');
                    if (d.Length < 4 || d[0] == "Fecha") continue;
                    if (!string.IsNullOrEmpty(filtroCodigo) && d[1] != filtroCodigo) continue;

                    string nombre = productos.ContainsKey(d[1]) ? productos[d[1]][1] : d[1];
                    int cant;
                    int.TryParse(d[2], out cant);
                    totalSalidas += cant;

                    int stockActual = CalcularStock(d[1], productos);
                    dgvMovimientos.Rows.Add(d[0], "▼ Salida", d[1], nombre, "-" + d[2], stockActual);

                    int rowIdx = dgvMovimientos.Rows.Count - 1;
                    dgvMovimientos.Rows[rowIdx].Cells["colTipo"].Style.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                    dgvMovimientos.Rows[rowIdx].Cells["colCantidad"].Style.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                }
            }

            // Actualizar resumen
            lblTotalEntradas.Text = "+" + totalEntradas;
            lblTotalSalidas.Text = "-" + totalSalidas;

            // Cargar tabla de stock
            CargarStockPorProducto(productos);
        }

        private int CalcularStock(string codigo, Dictionary<string, string[]> productos)
        {
            int stockInicial = 0;
            if (productos.ContainsKey(codigo))
                int.TryParse(productos[codigo][5], out stockInicial);

            int entradas = 0, salidas = 0;

            if (File.Exists(CSV_ENTRADAS))
                foreach (string l in File.ReadAllLines(CSV_ENTRADAS))
                {
                    string[] d = l.Split(',');
                    if (d.Length >= 3 && d[1] == codigo) { int v; if (int.TryParse(d[2], out v)) entradas += v; }
                }

            if (File.Exists(CSV_SALIDAS))
                foreach (string l in File.ReadAllLines(CSV_SALIDAS))
                {
                    string[] d = l.Split(',');
                    if (d.Length >= 3 && d[1] == codigo) { int v; if (int.TryParse(d[2], out v)) salidas += v; }
                }

            return stockInicial + entradas - salidas;
        }

        private void CargarStockPorProducto(Dictionary<string, string[]> productos)
        {
            dgvStock.Rows.Clear();
            int stockBajo = 0;

            foreach (var kvp in productos)
            {
                string codigo = kvp.Key;
                string[] d = kvp.Value;
                if (d.Length < 6) continue;

                int stockInicial;
                int.TryParse(d[5], out stockInicial);

                int entradas = 0, salidas = 0;

                if (File.Exists(CSV_ENTRADAS))
                    foreach (string l in File.ReadAllLines(CSV_ENTRADAS))
                    {
                        string[] ld = l.Split(',');
                        if (ld.Length >= 3 && ld[1] == codigo) { int v; if (int.TryParse(ld[2], out v)) entradas += v; }
                    }

                if (File.Exists(CSV_SALIDAS))
                    foreach (string l in File.ReadAllLines(CSV_SALIDAS))
                    {
                        string[] ld = l.Split(',');
                        if (ld.Length >= 3 && ld[1] == codigo) { int v; if (int.TryParse(ld[2], out v)) salidas += v; }
                    }

                int stockActual = stockInicial + entradas - salidas;
                dgvStock.Rows.Add(codigo, d[1], stockInicial, "+" + entradas, "-" + salidas, stockActual);

                int rowIdx = dgvStock.Rows.Count - 1;
                if (stockActual == 0)
                {
                    dgvStock.Rows[rowIdx].Cells["colStockActual"].Style.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                    dgvStock.Rows[rowIdx].Cells["colStockActual"].Style.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                    stockBajo++;
                }
                else if (stockActual <= 5)
                {
                    dgvStock.Rows[rowIdx].Cells["colStockActual"].Style.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
                    dgvStock.Rows[rowIdx].Cells["colStockActual"].Style.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                    stockBajo++;
                }
                else
                {
                    dgvStock.Rows[rowIdx].Cells["colStockActual"].Style.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
                    dgvStock.Rows[rowIdx].Cells["colStockActual"].Style.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                }
            }

            lblStockBajo.Text = stockBajo.ToString();
            lblTotalProductos.Text = $"Productos: {productos.Count}";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarInformes();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            cmbFiltroProducto.SelectedIndex = 0;
            cmbFiltroTipo.SelectedIndex = 0;
            CargarInformes();
        }
    }
}
