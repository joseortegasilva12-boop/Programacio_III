namespace InventarioVideojuegos
{
    partial class FormSalidas
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
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.panelBotonesRight = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusSalidas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusArchivo = new System.Windows.Forms.ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(194, 223, 245);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblIcono);

            this.lblIcono.Text = "📤"; this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblIcono.Location = new System.Drawing.Point(10, 8); this.lblIcono.Size = new System.Drawing.Size(50, 50);
            this.lblTitulo.Text = "Salidas"; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTitulo.Location = new System.Drawing.Point(68, 10); this.lblTitulo.Size = new System.Drawing.Size(300, 22);
            this.lblSubtitulo.Text = "Registrar salida de stock con validación de disponibilidad";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(74, 112, 153);
            this.lblSubtitulo.Location = new System.Drawing.Point(70, 35); this.lblSubtitulo.Size = new System.Drawing.Size(380, 18);

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.SplitterDistance = 280;
            this.splitContainer.Panel1.Controls.Add(this.grpRegistro);
            this.splitContainer.Panel2.Controls.Add(this.panelBotonesRight);
            this.splitContainer.Panel2.Controls.Add(this.grpHistorial);

            // grpRegistro
            this.grpRegistro.Text = "Nueva Salida";
            this.grpRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegistro.Padding = new System.Windows.Forms.Padding(8);
            this.grpRegistro.Controls.Add(this.btnRegistrarSalida);
            this.grpRegistro.Controls.Add(this.lblStockDisponible);
            this.grpRegistro.Controls.Add(this.tableLayout);

            // tableLayout
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowCount = 3;
            for (int i = 0; i < 3; i++)
                this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.Controls.Add(this.lblProducto, 0, 0); this.tableLayout.Controls.Add(this.cmbProducto, 1, 0);
            this.tableLayout.Controls.Add(this.lblCantidad, 0, 1); this.tableLayout.Controls.Add(this.nudCantidad, 1, 1);
            this.tableLayout.Controls.Add(this.lblObservacion, 0, 2); this.tableLayout.Controls.Add(this.txtObservacion, 1, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayout.Height = 115;
            this.tableLayout.Padding = new System.Windows.Forms.Padding(5);

            ConfigLabel(this.lblProducto, "Videojuego:");
            ConfigLabel(this.lblCantidad, "Cantidad:");
            ConfigLabel(this.lblObservacion, "Observación:");

            this.cmbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);

            this.nudCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCantidad.Minimum = 1; this.nudCantidad.Maximum = 9999; this.nudCantidad.Value = 1;

            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.PlaceholderText = "Ej: Venta cliente";

            // lblStockDisponible
            this.lblStockDisponible.Text = "Selecciona un videojuego para ver el stock disponible";
            this.lblStockDisponible.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblStockDisponible.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblStockDisponible.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStockDisponible.Height = 30;
            this.lblStockDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStockDisponible.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            // btnRegistrarSalida
            this.btnRegistrarSalida.Text = "📤 Registrar Salida";
            this.btnRegistrarSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarSalida.Height = 32;
            this.btnRegistrarSalida.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnRegistrarSalida.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);

            // grpHistorial
            this.grpHistorial.Text = "Historial de Salidas";
            this.grpHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHistorial.Controls.Add(this.dgvSalidas);

            this.dgvSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalidas.MultiSelect = false;
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.RowHeadersVisible = false;
            this.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalidas.Columns.Add("colFecha", "Fecha");
            this.dgvSalidas.Columns.Add("colCodigo", "Código");
            this.dgvSalidas.Columns.Add("colCantidad", "Cantidad");
            this.dgvSalidas.Columns.Add("colObservacion", "Observación");
            this.dgvSalidas.Columns["colFecha"].FillWeight = 20;
            this.dgvSalidas.Columns["colCodigo"].FillWeight = 15;
            this.dgvSalidas.Columns["colCantidad"].FillWeight = 15;

            // panelBotonesRight
            this.panelBotonesRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotonesRight.Height = 40;
            this.panelBotonesRight.Controls.Add(this.btnActualizar);
            this.btnActualizar.Text = "🔄 Actualizar historial";
            this.btnActualizar.Location = new System.Drawing.Point(5, 5);
            this.btnActualizar.Size = new System.Drawing.Size(150, 28);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // StatusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusSalidas, this.lblStatusArchivo });
            this.lblStatusSalidas.Text = "Total salidas hoy: 0";
            this.lblStatusArchivo.Text = "salidas.csv";
            this.lblStatusArchivo.Spring = true;
            this.lblStatusArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Form
            this.ClientSize = new System.Drawing.Size(860, 420);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Text = "Salidas de Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelHeader.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
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

        private System.Windows.Forms.Panel panelHeader, panelBotonesRight;
        private System.Windows.Forms.Label lblIcono, lblTitulo, lblSubtitulo, lblStockDisponible;
        private System.Windows.Forms.Label lblProducto, lblCantidad, lblObservacion;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpRegistro, grpHistorial;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnRegistrarSalida, btnActualizar;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSalidas, lblStatusArchivo;
    }
}
