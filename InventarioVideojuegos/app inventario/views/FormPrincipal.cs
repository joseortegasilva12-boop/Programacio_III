using System;
using System.Windows.Forms;
// Importamos las carpetas donde están las clases
using app_inventario.controllers;
using app_inventario.views;

namespace app_inventario.views
{
    public partial class FormPrincipal : Form
    {
        // Definición de los controladores
        private readonly ProductosController _prodCtrl;
        private readonly InventarioController _invCtrl;

        public FormPrincipal()
        {
            InitializeComponent();

            // 1. Inicializamos los controladores de forma independiente
            _prodCtrl = new ProductosController();
            _invCtrl = new InventarioController();
        }

        // Eventos para abrir los otros formularios
        private void btnProductos_Click(object sender, EventArgs e) =>
            new FormProductos(_prodCtrl).Show();

        private void btnEntradas_Click(object sender, EventArgs e) =>
            new FormEntradas(_prodCtrl, _invCtrl).Show();

        private void btnSalidas_Click(object sender, EventArgs e) =>
            new FormSalidas(_prodCtrl, _invCtrl).Show();

        private void btnInformes_Click(object sender, EventArgs e) =>
            new FormInformes(_prodCtrl, _invCtrl).Show();
    }
}