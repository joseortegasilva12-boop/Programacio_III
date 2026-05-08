namespace InventarioVideojuegos
{
    partial class FormProductos
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.cmbPlataforma = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panelBotonesRight = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusArchivo = new System.Windows.Forms.ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(194, 223, 245);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblIcono);

            this.lblIcono.Text = "🎮"; this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblIcono.Location = new System.Drawing.Point(10, 8); this.lblIcono.Size = new System.Drawing.Size(50, 50);

            this.lblTitulo.Text = "Videojuegos"; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTitulo.Location = new System.Drawing.Point(68, 10); this.lblTitulo.Size = new System.Drawing.Size(300, 22);

            this.lblSubtitulo.Text = "Registro y listado de videojuegos del inventario";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(74, 112, 153);
            this.lblSubtitulo.Location = new System.Drawing.Point(70, 35); this.lblSubtitulo.Size = new System.Drawing.Size(350, 18);

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.SplitterDistance = 240;
            this.splitContainer.Panel1.Controls.Add(this.grpRegistro);
            this.splitContainer.Panel2.Controls.Add(this.panelBotonesRight);
            this.splitContainer.Panel2.Controls.Add(this.grpListado);

            // grpRegistro
            this.grpRegistro.Text = "Nuevo Videojuego";
            this.grpRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegistro.Padding = new System.Windows.Forms.Padding(8);
            this.grpRegistro.Controls.Add(this.panelBotones);
            this.grpRegistro.Controls.Add(this.tableLayout);

            // tableLayout
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowCount = 6;
            for (int i = 0; i < 6; i++)
                this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayout.Controls.Add(this.lblCodigo, 0, 0); this.tableLayout.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayout.Controls.Add(this.lblNombre, 0, 1); this.tableLayout.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayout.Controls.Add(this.lblGenero, 0, 2); this.tableLayout.Controls.Add(this.cmbGenero, 1, 2);
            this.tableLayout.Controls.Add(this.lblPlataforma, 0, 3); this.tableLayout.Controls.Add(this.cmbPlataforma, 1, 3);
            this.tableLayout.Controls.Add(this.lblPrecio, 0, 4); this.tableLayout.Controls.Add(this.txtPrecio, 1, 4);
            this.tableLayout.Controls.Add(this.lblStock, 0, 5); this.tableLayout.Controls.Add(this.nudStock, 1, 5);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayout.Height = 200;
            this.tableLayout.Padding = new System.Windows.Forms.Padding(5);

            // Labels del formulario
            ConfigLabel(this.lblCodigo, "Código:");
            ConfigLabel(this.lblNombre, "Nombre:");
            ConfigLabel(this.lblGenero, "Género:");
            ConfigLabel(this.lblPlataforma, "Plataforma:");
            ConfigLabel(this.lblPrecio, "Precio ($):");
            ConfigLabel(this.lblStock, "Stock Ini.:");

            // Inputs
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill; this.txtCodigo.PlaceholderText = "Ej: VJ001";
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill; this.txtNombre.PlaceholderText = "Ej: The Last of Us";
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Fill; this.txtPrecio.PlaceholderText = "Ej: 199900";

            this.cmbGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Items.AddRange(new object[] { "Acción", "Aventura", "RPG", "Deportes", "Estrategia", "Simulación", "Terror", "Carreras", "Pelea", "Plataformas" });

            this.cmbPlataforma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlataforma.Items.AddRange(new object[] { "PlayStation 5", "PlayStation 4", "Xbox Series X", "Xbox One", "Nintendo Switch", "PC", "iOS", "Android" });

            this.nudStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudStock.Minimum = 0; this.nudStock.Maximum = 9999;

            // panelBotones (izquierdo)
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.btnGuardar.Text = "💾 Guardar Videojuego";
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.Height = 32;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // grpListado
            this.grpListado.Text = "Videojuegos Registrados";
            this.grpListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListado.Controls.Add(this.dgvProductos);

            // dgvProductos
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvProductos.Columns.Add("colCodigo", "Código");
            this.dgvProductos.Columns.Add("colNombre", "Nombre");
            this.dgvProductos.Columns.Add("colGenero", "Género");
            this.dgvProductos.Columns.Add("colPlataforma", "Plataforma");
            this.dgvProductos.Columns.Add("colPrecio", "Precio");
            this.dgvProductos.Columns.Add("colStock", "Stock Ini.");

            this.dgvProductos.Columns["colCodigo"].FillWeight = 15;
            this.dgvProductos.Columns["colStock"].FillWeight = 15;

            // panelBotonesRight
            this.panelBotonesRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotonesRight.Height = 40;
            this.panelBotonesRight.Controls.Add(this.btnEliminar);
            this.panelBotonesRight.Controls.Add(this.btnActualizar);

            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.Location = new System.Drawing.Point(5, 5);
            this.btnActualizar.Size = new System.Drawing.Size(110, 28);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Text = "🗑 Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(120, 5);
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // StatusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusItems, this.lblStatusArchivo });
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatusItems.Text = "Total videojuegos: 0";
            this.lblStatusArchivo.Text = "videojuegos.csv";
            this.lblStatusArchivo.Spring = true;
            this.lblStatusArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Form
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Text = "Gestión de Videojuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelHeader.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigLabel(System.Windows.Forms.Label lbl, string texto)
        {
            lbl.Text = texto;
            lbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        // Controls
        private System.Windows.Forms.Panel panelHeader, panelBotones, panelBotonesRight;
        private System.Windows.Forms.Label lblIcono, lblTitulo, lblSubtitulo;
        private System.Windows.Forms.Label lblCodigo, lblNombre, lblGenero, lblPlataforma, lblPrecio, lblStock;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpRegistro, grpListado;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TextBox txtCodigo, txtNombre, txtPrecio;
        private System.Windows.Forms.ComboBox cmbGenero, cmbPlataforma;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnGuardar, btnActualizar, btnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusItems, lblStatusArchivo;
    }
}
