namespace InventarioVideojuegos
{
    partial class FormPrincipal
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIcono = new System.Windows.Forms.Label();
            this.tableLayoutNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            this.tableLayoutNav.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(194, 223, 245);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblIcono);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;

            this.lblIcono.Text = "🎮";
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblIcono.Location = new System.Drawing.Point(12, 10);
            this.lblIcono.Size = new System.Drawing.Size(55, 50);

            this.lblTitulo.Text = "INVENTARIO DE VIDEOJUEGOS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTitulo.Location = new System.Drawing.Point(75, 12);
            this.lblTitulo.Size = new System.Drawing.Size(400, 25);

            this.lblSubtitulo.Text = "Selecciona un módulo para comenzar";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(74, 112, 153);
            this.lblSubtitulo.Location = new System.Drawing.Point(77, 40);
            this.lblSubtitulo.Size = new System.Drawing.Size(300, 20);

            // tableLayoutNav
            this.tableLayoutNav.ColumnCount = 4;
            this.tableLayoutNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNav.RowCount = 1;
            this.tableLayoutNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutNav.Controls.Add(this.btnProductos, 0, 0);
            this.tableLayoutNav.Controls.Add(this.btnEntradas, 1, 0);
            this.tableLayoutNav.Controls.Add(this.btnSalidas, 2, 0);
            this.tableLayoutNav.Controls.Add(this.btnInformes, 3, 0);
            this.tableLayoutNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutNav.Padding = new System.Windows.Forms.Padding(20);

            // Botones de navegación
            ConfigurarBotonNav(this.btnProductos, "🎮", "Videojuegos", this.btnProductos_Click);
            ConfigurarBotonNav(this.btnEntradas, "📥", "Entradas", this.btnEntradas_Click);
            ConfigurarBotonNav(this.btnSalidas, "📤", "Salidas", this.btnSalidas_Click);
            ConfigurarBotonNav(this.btnInformes, "📊", "Informes", this.btnInformes_Click);

            // StatusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatus, this.lblVersion });
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.lblStatus.Text = "✔ Listo";
            this.lblVersion.Text = "v1.0 — Inventario Videojuegos";
            this.lblVersion.Spring = true;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Form
            this.ClientSize = new System.Drawing.Size(580, 290);
            this.Controls.Add(this.tableLayoutNav);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Text = "Sistema de Inventario — Videojuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.panelHeader.ResumeLayout(false);
            this.tableLayoutNav.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarBotonNav(System.Windows.Forms.Button btn, string icono, string texto,
            System.EventHandler handler)
        {
            btn.Text = icono + "\n" + texto;
            btn.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            btn.BackColor = System.Drawing.Color.White;
            btn.Size = new System.Drawing.Size(120, 110);
            btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.Click += handler;
        }

        // Controls
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo, lblSubtitulo, lblIcono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutNav;
        private System.Windows.Forms.Button btnProductos, btnEntradas, btnSalidas, btnInformes;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus, lblVersion;
    }
}
