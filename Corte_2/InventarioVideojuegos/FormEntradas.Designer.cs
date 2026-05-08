namespace InventarioVideojuegos
{
    partial class FormEntradas
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.panelBotonesRight = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusEntradas = new System.Windows.Forms.ToolStripStatusLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(194, 223, 245);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblIcono);

            this.lblIcono.Text = "📥"; this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblIcono.Location = new System.Drawing.Point(10, 8); this.lblIcono.Size = new System.Drawing.Size(50, 50);
            this.lblTitulo.Text = "Entradas"; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTitulo.Location = new System.Drawing.Point(68, 10); this.lblTitulo.Size = new System.Drawing.Size(300, 22);
            this.lblSubtitulo.Text = "Registrar ingreso de stock de videojuegos";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(74, 112, 153);
            this.lblSubtitulo.Location = new System.Drawing.Point(70, 35); this.lblSubtitulo.Size = new System.Drawing.Size(350, 18);

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.SplitterDistance = 260;
            this.splitContainer.Panel1.Controls.Add(this.grpRegistro);
            this.splitContainer.Panel2.Controls.Add(this.panelBotonesRight);
            this.splitContainer.Panel2.Controls.Add(this.grpHistorial);

            // grpRegistro
            this.grpRegistro.Text = "Nueva Entrada";
            this.grpRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegistro.Padding = new System.Windows.Forms.Padding(8);
            this.grpRegistro.Controls.Add(this.btnRegistrarEntrada);
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
            this.nudCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCantidad.Minimum = 1; this.nudCantidad.Maximum = 9999; this.nudCantidad.Value = 1;
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.PlaceholderText = "Ej: Reposición mensual";

            this.btnRegistrarEntrada.Text = "📥 Registrar Entrada";
            this.btnRegistrarEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarEntrada.Height = 32;
            this.btnRegistrarEntrada.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnRegistrarEntrada.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntrada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);

            // grpHistorial
            this.grpHistorial.Text = "Historial de Entradas";
            this.grpHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHistorial.Controls.Add(this.dgvEntradas);

            this.dgvEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.MultiSelect = false;
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.Columns.Add("colFecha", "Fecha");
            this.dgvEntradas.Columns.Add("colCodigo", "Código");
            this.dgvEntradas.Columns.Add("colCantidad", "Cantidad");
            this.dgvEntradas.Columns.Add("colObservacion", "Observación");
            this.dgvEntradas.Columns["colFecha"].FillWeight = 20;
            this.dgvEntradas.Columns["colCodigo"].FillWeight = 15;
            this.dgvEntradas.Columns["colCantidad"].FillWeight = 15;

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
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusEntradas, this.lblStatusArchivo });
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatusEntradas.Text = "Total entradas hoy: 0";
            this.lblStatusArchivo.Text = "entradas.csv";
            this.lblStatusArchivo.Spring = true;
            this.lblStatusArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Form
            this.ClientSize = new System.Drawing.Size(860, 420);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Text = "Entradas de Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelHeader.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
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
        private System.Windows.Forms.Label lblIcono, lblTitulo, lblSubtitulo;
        private System.Windows.Forms.Label lblProducto, lblCantidad, lblObservacion;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpRegistro, grpHistorial;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnRegistrarEntrada, btnActualizar;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusEntradas, lblStatusArchivo;
    }
}
