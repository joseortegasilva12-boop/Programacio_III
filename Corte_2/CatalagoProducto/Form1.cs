using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalagoProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ── Formulario ──────────────────────────────────────
            this.Text = "Catálogo de Producto";
            this.Size = new Size(360, 320);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ── Panel (BorderStyle = FixedSingle) ────────────────
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(310, 240);
            panel.Location = new Point(15, 15);

            // ── Label: Nombre ────────────────────────────────────
            Label lblNombre = new Label();
            lblNombre.Text = "Monitor Gamer 24\"";
            lblNombre.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNombre.ForeColor = Color.Blue;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 10);

            // ── TextBox: Descripción ─────────────────────────────
            TextBox txtDescripcion = new TextBox();
            txtDescripcion.Multiline = true;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.ReadOnly = true;
            txtDescripcion.BackColor = panel.BackColor;
            txtDescripcion.Text = "Panel IPS Full HD (1920x1080), 144 Hz,\r\n1 ms de respuesta. Compatible con\r\nFreeSync y G-Sync.";
            txtDescripcion.Size = new Size(285, 60);
            txtDescripcion.Location = new Point(10, 45);

            // ── Label: Precio ────────────────────────────────────
            Label lblPrecio = new Label();
            lblPrecio.Text = "$299.99";
            lblPrecio.Font = new Font("Arial", 18, FontStyle.Bold);
            lblPrecio.ForeColor = Color.Green;
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(10, 115);

            // ── Label: Cantidad ──────────────────────────────────
            Label lblCantidad = new Label();
            lblCantidad.Text = "Cantidad:";
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(10, 170);

            // ── NumericUpDown ────────────────────────────────────
            NumericUpDown nudCantidad = new NumericUpDown();
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 99;
            nudCantidad.Value = 1;
            nudCantidad.Size = new Size(55, 22);
            nudCantidad.Location = new Point(75, 167);

            // ── Button ───────────────────────────────────────────
            Button btnCarrito = new Button();
            btnCarrito.Text = "Añadir al carrito";
            btnCarrito.BackColor = Color.Green;
            btnCarrito.ForeColor = Color.White;
            btnCarrito.Size = new Size(130, 28);
            btnCarrito.Location = new Point(145, 165);

            // ── Agregar controles ────────────────────────────────
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(txtDescripcion);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(lblCantidad);
            panel.Controls.Add(nudCantidad);
            panel.Controls.Add(btnCarrito);
            this.Controls.Add(panel);
        }
    }
}