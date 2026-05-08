using System;
using System.IO;
using System.Windows.Forms;

namespace InventarioVideojuegos
{
    public partial class FormProductos : Form
    {
        private const string ARCHIVO_CSV = "videojuegos.csv";

        public FormProductos()
        {
            InitializeComponent();
            VerificarArchivoCSV();
            CargarVideojuegos();
        }

        private void VerificarArchivoCSV()
        {
            if (!File.Exists(ARCHIVO_CSV))
                File.WriteAllText(ARCHIVO_CSV, "Codigo,Nombre,Genero,Plataforma,Precio,StockInicial\n");
        }

        private void CargarVideojuegos()
        {
            dgvProductos.Rows.Clear();
            cmbCodigoSalida?.Items.Clear();

            if (!File.Exists(ARCHIVO_CSV)) return;

            string[] lineas = File.ReadAllLines(ARCHIVO_CSV);
            int count = 0;

            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i].Trim();
                if (string.IsNullOrEmpty(linea)) continue;

                string[] datos = linea.Split(',');
                if (datos.Length >= 6)
                {
                    dgvProductos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                    count++;
                }
            }

            lblStatusItems.Text = $"Total videojuegos: {count}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string genero = cmbGenero.Text.Trim();
            string plataforma = cmbPlataforma.Text.Trim();
            string precio = txtPrecio.Text.Trim();
            string stock = nudStock.Value.ToString();

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El código y el nombre son obligatorios.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar código duplicado
            if (File.Exists(ARCHIVO_CSV))
            {
                foreach (string linea in File.ReadAllLines(ARCHIVO_CSV))
                {
                    if (linea.StartsWith(codigo + ","))
                    {
                        MessageBox.Show("Ya existe un videojuego con ese código.", "Código duplicado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            string registro = $"{codigo},{nombre},{genero},{plataforma},{precio},{stock}\n";
            File.AppendAllText(ARCHIVO_CSV, registro);

            MessageBox.Show("Videojuego registrado exitosamente.", "Guardado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            CargarVideojuegos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un videojuego para eliminar.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoEliminar = dgvProductos.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el videojuego {codigoEliminar}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var lineas = new System.Collections.Generic.List<string>(File.ReadAllLines(ARCHIVO_CSV));
                lineas.RemoveAll(l => l.StartsWith(codigoEliminar + ","));
                File.WriteAllLines(ARCHIVO_CSV, lineas);
                CargarVideojuegos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarVideojuegos();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbPlataforma.SelectedIndex = -1;
            txtPrecio.Clear();
            nudStock.Value = 0;
        }

        // Campo público para que FormEntradas/Salidas recarguen combos
        public ComboBox cmbCodigoSalida;
    }
}
