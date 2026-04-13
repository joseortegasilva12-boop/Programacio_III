using System;
using System.IO;
using System.Windows.Forms;

namespace EjercicioClientes
{
    public partial class Form1 : Form
    {
        // Ruta del archivo donde se guardan los clientes
        private readonly string rutaArchivo = "clientes.csv";

        public Form1()
        {
            InitializeComponent();
        }

        // ─── BOTÓN: Registrar Cliente ───────────────────────────────────────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Leer los valores de los campos
            string dni    = txtDNI.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();

            // 2. Validar que DNI y Nombre no estén vacíos
            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show(
                    "El DNI y el Nombre son obligatorios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; // Salir sin guardar
            }

            // 3. Si Ciudad está vacía, asignar valor por defecto
            if (string.IsNullOrEmpty(ciudad))
                ciudad = "No especificado";

            // 4. Armar la línea CSV: DNI,Nombre,Ciudad
            string linea = $"{dni},{nombre},{ciudad}";

            // 5. Guardar (agregar) al archivo
            File.AppendAllText(rutaArchivo, linea + Environment.NewLine);

            MessageBox.Show(
                "Cliente registrado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // 6. Limpiar los campos del formulario
            txtDNI.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
            txtDNI.Focus();
        }

        // ─── BOTÓN: Cargar desde Archivo ───────────────────────────────────────
        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Verificar que el archivo exista antes de leerlo
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show(
                    "No existe el archivo de clientes todavía.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Limpiar el ListBox para no duplicar datos
            listBoxClientes.Items.Clear();

            // Leer todas las líneas del archivo
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Recorrer cada línea y agregarla al ListBox
            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea)) // Ignorar líneas vacías
                    listBoxClientes.Items.Add(linea);
            }
        }
    }
}
