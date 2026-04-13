using System;
using System.IO;
using System.Windows.Forms;

namespace EjercicioVentas
{
    public partial class Form1 : Form
    {
        private readonly string rutaArchivo = "ventas.csv";

        public Form1()
        {
            InitializeComponent();
        }

        // ─── BOTÓN: Guardar Transacción ─────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();

            // Validar que el ID no esté vacío
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(
                    "El ID de transacción no puede estar vacío.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Leer el monto desde el NumericUpDown
            double monto = (double)numMonto.Value;

            // Armar la línea CSV: ID,Monto
            string linea = $"{id},{monto}";

            // Guardar en el archivo (agregar al final)
            File.AppendAllText(rutaArchivo, linea + Environment.NewLine);

            MessageBox.Show(
                "Transacción guardada correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar campos
            txtID.Clear();
            numMonto.Value = 0;
            txtID.Focus();
        }

        // ─── BOTÓN: Cargar ──────────────────────────────────────────────────────
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show(
                    "No existe el archivo de ventas todavía.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Limpiar el historial
            listBoxHistorial.Items.Clear();

            // Leer todas las líneas
            string[] lineas = File.ReadAllLines(rutaArchivo);

            double totalAcumulado = 0.0;

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                // Separar los datos por coma: partes[0] = ID, partes[1] = Monto
                string[] partes = linea.Split(',');

                if (partes.Length >= 2)
                {
                    // Convertir el monto de texto a número
                    double monto = double.Parse(partes[1]);

                    // Sumar al total
                    totalAcumulado += monto;

                    // Mostrar en el ListBox con formato legible
                    listBoxHistorial.Items.Add($"ID: {partes[0]}   |   Monto: ${monto:F2}");
                }
            }

            // Actualizar la etiqueta del total
            lblTotal.Text = $"TOTAL: ${totalAcumulado:F2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
