using System;
using System.IO;
using System.Windows.Forms;

namespace InventarioVideojuegos
{
    public partial class FormEntradas : Form
    {
        private const string CSV_PRODUCTOS = "videojuegos.csv";
        private const string CSV_ENTRADAS = "entradas.csv";

        public FormEntradas()
        {
            InitializeComponent();
            VerificarCSV();
            CargarProductosEnCombo();
            CargarHistorialEntradas();
        }

        private void VerificarCSV()
        {
            if (!File.Exists(CSV_ENTRADAS))
                File.WriteAllText(CSV_ENTRADAS, "Fecha,CodigoProducto,Cantidad,Observacion\n");
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

        private void CargarHistorialEntradas()
        {
            dgvEntradas.Rows.Clear();
            if (!File.Exists(CSV_ENTRADAS)) return;

            string[] lineas = File.ReadAllLines(CSV_ENTRADAS);
            int count = 0;

            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i].Trim();
                if (string.IsNullOrEmpty(linea)) continue;

                string[] datos = linea.Split(',');
                if (datos.Length >= 4)
                {
                    dgvEntradas.Rows.Add(datos[0], datos[1], datos[2], datos[3]);
                    count++;
                }
            }

            lblStatusEntradas.Text = $"Total entradas hoy: {count}";
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un videojuego.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccion = cmbProducto.SelectedItem.ToString();
            string codigo = seleccion.Split('—')[0].Trim();
            string cantidad = nudCantidad.Value.ToString();
            string observacion = txtObservacion.Text.Trim();
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Cantidad inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string registro = $"{fecha},{codigo},{cantidad},{observacion}\n";
            File.AppendAllText(CSV_ENTRADAS, registro);

            MessageBox.Show("Entrada registrada exitosamente.", "Entrada guardada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            nudCantidad.Value = 1;
            txtObservacion.Clear();
            cmbProducto.SelectedIndex = -1;
            CargarHistorialEntradas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductosEnCombo();
            CargarHistorialEntradas();
        }
    }
}
