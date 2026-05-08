using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventarioVideojuegos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            new FormProductos().Show();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            new FormEntradas().Show();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            new FormSalidas().Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            new FormInformes().Show();
        }
    }
}
