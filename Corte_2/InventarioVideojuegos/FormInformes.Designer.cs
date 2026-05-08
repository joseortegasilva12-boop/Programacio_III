namespace InventarioVideojuegos
{
    partial class FormInformes
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.panelBoxEntradas = new System.Windows.Forms.Panel();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.lblLabelEntradas = new System.Windows.Forms.Label();
            this.panelBoxSalidas = new System.Windows.Forms.Panel();
            this.lblTotalSalidas = new System.Windows.Forms.Label();
            this.lblLabelSalidas = new System.Windows.Forms.Label();
            this.panelBoxBajo = new System.Windows.Forms.Panel();
            this.lblStockBajo = new System.Windows.Forms.Label();
            this.lblLabelBajo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblFiltroProducto = new System.Windows.Forms.Label();
            this.cmbFiltroProducto = new System.Windows.Forms.ComboBox();
            this.lblFiltroTipo = new System.Windows.Forms.Label();
            this.cmbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusOk = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalProductos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusFuente = new System.Windows.Forms.ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(194, 223, 245);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblIcono);

            this.lblIcono.Text = "📊"; this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblIcono.Location = new System.Drawing.Point(10, 8); this.lblIcono.Size = new System.Drawing.Size(50, 50);
            this.lblTitulo.Text = "Informes"; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTitulo.Location = new System.Drawing.Point(68, 10); this.lblTitulo.Size = new System.Drawing.Size(300, 22);
            this.lblSubtitulo.Text = "Resumen de movimientos y stock actual calculado";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(74, 112, 153);
            this.lblSubtitulo.Location = new System.Drawing.Point(70, 35); this.lblSubtitulo.Size = new System.Drawing.Size(380, 18);

            // panelContenido
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Padding = new System.Windows.Forms.Padding(10);
            this.panelContenido.Controls.Add(this.grpStock);
            this.panelContenido.Controls.Add(this.dgvMovimientos);
            this.panelContenido.Controls.Add(this.panelFiltros);
            this.panelContenido.Controls.Add(this.panelResumen);

            // panelResumen (3 boxes de resumen)
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResumen.Height = 75;
            this.panelResumen.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);

            ConfigSummaryBox(this.panelBoxEntradas, this.lblTotalEntradas, this.lblLabelEntradas,
                "+0", "Total unidades ingresadas", System.Drawing.Color.FromArgb(39, 174, 96));
            ConfigSummaryBox(this.panelBoxSalidas, this.lblTotalSalidas, this.lblLabelSalidas,
                "-0", "Total unidades despachadas", System.Drawing.Color.FromArgb(192, 57, 43));
            ConfigSummaryBox(this.panelBoxBajo, this.lblStockBajo, this.lblLabelBajo,
                "0", "Videojuegos con stock bajo", System.Drawing.Color.FromArgb(230, 126, 34));

            this.panelBoxEntradas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBoxEntradas.Width = 200;
            this.panelBoxSalidas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBoxSalidas.Width = 200;
            this.panelBoxBajo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBoxBajo.Width = 200;

            this.panelResumen.Controls.Add(this.panelBoxBajo);
            this.panelResumen.Controls.Add(this.panelBoxSalidas);
            this.panelResumen.Controls.Add(this.panelBoxEntradas);

            // panelFiltros
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Height = 45;
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(5);

            this.lblFiltroProducto.Text = "Videojuego:";
            this.lblFiltroProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFiltroProducto.Location = new System.Drawing.Point(8, 13); this.lblFiltroProducto.Size = new System.Drawing.Size(72, 18);

            this.cmbFiltroProducto.Location = new System.Drawing.Point(82, 9); this.cmbFiltroProducto.Size = new System.Drawing.Size(220, 22);
            this.cmbFiltroProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblFiltroTipo.Text = "Tipo:";
            this.lblFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFiltroTipo.Location = new System.Drawing.Point(312, 13); this.lblFiltroTipo.Size = new System.Drawing.Size(35, 18);

            this.cmbFiltroTipo.Location = new System.Drawing.Point(350, 9); this.cmbFiltroTipo.Size = new System.Drawing.Size(140, 22);
            this.cmbFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTipo.Items.AddRange(new object[] { "Todos", "Solo Entradas", "Solo Salidas" });
            this.cmbFiltroTipo.SelectedIndex = 0;

            this.btnFiltrar.Text = "🔍 Filtrar"; this.btnFiltrar.Location = new System.Drawing.Point(500, 8); this.btnFiltrar.Size = new System.Drawing.Size(90, 26);
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215); this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);

            this.btnVerTodo.Text = "↺ Ver todo"; this.btnVerTodo.Location = new System.Drawing.Point(598, 8); this.btnVerTodo.Size = new System.Drawing.Size(90, 26);
            this.btnVerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);

            this.panelFiltros.Controls.Add(this.btnVerTodo);
            this.panelFiltros.Controls.Add(this.btnFiltrar);
            this.panelFiltros.Controls.Add(this.cmbFiltroTipo);
            this.panelFiltros.Controls.Add(this.lblFiltroTipo);
            this.panelFiltros.Controls.Add(this.cmbFiltroProducto);
            this.panelFiltros.Controls.Add(this.lblFiltroProducto);

            // dgvMovimientos
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMovimientos.Height = 160;
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.Columns.Add("colFecha", "Fecha");
            this.dgvMovimientos.Columns.Add("colTipo", "Tipo");
            this.dgvMovimientos.Columns.Add("colCodigo", "Código");
            this.dgvMovimientos.Columns.Add("colNombre", "Videojuego");
            this.dgvMovimientos.Columns.Add("colCantidad", "Cantidad");
            this.dgvMovimientos.Columns.Add("colStock", "Stock");
            this.dgvMovimientos.Columns["colFecha"].FillWeight = 18;
            this.dgvMovimientos.Columns["colTipo"].FillWeight = 18;
            this.dgvMovimientos.Columns["colCodigo"].FillWeight = 13;
            this.dgvMovimientos.Columns["colCantidad"].FillWeight = 13;
            this.dgvMovimientos.Columns["colStock"].FillWeight = 13;

            // grpStock
            this.grpStock.Text = "Stock actual por videojuego";
            this.grpStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStock.Controls.Add(this.dgvStock);

            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.Columns.Add("colCodigo", "Código");
            this.dgvStock.Columns.Add("colNombre", "Videojuego");
            this.dgvStock.Columns.Add("colStockIni", "Stock Ini.");
            this.dgvStock.Columns.Add("colEntradas", "+ Entradas");
            this.dgvStock.Columns.Add("colSalidas", "- Salidas");
            this.dgvStock.Columns.Add("colStockActual", "Stock Actual");
            this.dgvStock.Columns["colCodigo"].FillWeight = 13;
            this.dgvStock.Columns["colStockIni"].FillWeight = 14;
            this.dgvStock.Columns["colEntradas"].FillWeight = 14;
            this.dgvStock.Columns["colSalidas"].FillWeight = 14;
            this.dgvStock.Columns["colStockActual"].FillWeight = 14;

            // StatusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusOk, this.lblTotalProductos, this.lblStatusFuente });
            this.lblStatusOk.Text = "✔ Datos actualizados";
            this.lblTotalProductos.Text = "Productos: 0";
            this.lblStatusFuente.Text = "videojuegos.csv + entradas.csv + salidas.csv";
            this.lblStatusFuente.Spring = true;
            this.lblStatusFuente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Form
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Text = "Informes y Stock Actual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelHeader.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.grpStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigSummaryBox(System.Windows.Forms.Panel panel, System.Windows.Forms.Label lblValor,
            System.Windows.Forms.Label lblTexto, string valor, string texto, System.Drawing.Color color)
        {
            panel.BackColor = System.Drawing.Color.White;
            panel.Margin = new System.Windows.Forms.Padding(3);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Padding = new System.Windows.Forms.Padding(8);

            lblValor.Text = valor;
            lblValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblValor.ForeColor = color;
            lblValor.Dock = System.Windows.Forms.DockStyle.Top;
            lblValor.Height = 30;
            lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lblTexto.Text = texto;
            lblTexto.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblTexto.ForeColor = System.Drawing.Color.Gray;
            lblTexto.Dock = System.Windows.Forms.DockStyle.Top;
            lblTexto.Height = 18;
            lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            panel.Controls.Add(lblTexto);
            panel.Controls.Add(lblValor);
        }

        private System.Windows.Forms.Panel panelHeader, panelContenido, panelResumen, panelFiltros;
        private System.Windows.Forms.Panel panelBoxEntradas, panelBoxSalidas, panelBoxBajo;
        private System.Windows.Forms.Label lblIcono, lblTitulo, lblSubtitulo;
        private System.Windows.Forms.Label lblTotalEntradas, lblLabelEntradas;
        private System.Windows.Forms.Label lblTotalSalidas, lblLabelSalidas;
        private System.Windows.Forms.Label lblStockBajo, lblLabelBajo;
        private System.Windows.Forms.Label lblFiltroProducto, lblFiltroTipo;
        private System.Windows.Forms.ComboBox cmbFiltroProducto, cmbFiltroTipo;
        private System.Windows.Forms.Button btnFiltrar, btnVerTodo;
        private System.Windows.Forms.DataGridView dgvMovimientos, dgvStock;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOk, lblTotalProductos, lblStatusFuente;
    }
}
