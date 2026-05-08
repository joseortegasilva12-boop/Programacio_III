using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.views
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitulo = new Label();
            this.lblSubtitulo = new Label();
            this.tableNav = new TableLayoutPanel();
            this.btnProductos = new Button();
            this.btnEntradas = new Button();
            this.btnSalidas = new Button();
            this.btnInformes = new Button();
            this.statusStrip = new StatusStrip();
            this.lblStatus = new ToolStripStatusLabel();
            this.lblVer = new ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            this.tableNav.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(26, 58, 92);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 75;
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);

            // lblTitulo
            this.lblTitulo.Text = "🎮  INVENTARIO DE VIDEOJUEGOS";
            this.lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(16, 12);
            this.lblTitulo.Size = new Size(500, 28);

            // lblSubtitulo
            this.lblSubtitulo.Text = "Sistema de gestión de stock  ·  Programación III";
            this.lblSubtitulo.Font = new Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = Color.FromArgb(180, 210, 240);
            this.lblSubtitulo.Location = new Point(18, 44);
            this.lblSubtitulo.Size = new Size(420, 20);

            // tableNav
            this.tableNav.Dock = DockStyle.Fill;
            this.tableNav.ColumnCount = 4;
            this.tableNav.RowCount = 1;
            for (int i = 0; i < 4; i++)
                this.tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableNav.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableNav.Padding = new Padding(24);
            this.tableNav.BackColor = Color.FromArgb(245, 247, 250);
            this.tableNav.Controls.Add(this.btnProductos, 0, 0);
            this.tableNav.Controls.Add(this.btnEntradas, 1, 0);
            this.tableNav.Controls.Add(this.btnSalidas, 2, 0);
            this.tableNav.Controls.Add(this.btnInformes, 3, 0);

            // Botones
            ConfigNav(this.btnProductos, "🎮", "Videojuegos", Color.FromArgb(41, 128, 185), this.btnProductos_Click);
            ConfigNav(this.btnEntradas, "📥", "Entradas", Color.FromArgb(39, 174, 96), this.btnEntradas_Click);
            ConfigNav(this.btnSalidas, "📤", "Salidas", Color.FromArgb(192, 57, 43), this.btnSalidas_Click);
            ConfigNav(this.btnInformes, "📊", "Informes", Color.FromArgb(142, 68, 173), this.btnInformes_Click);

            // StatusStrip
            this.lblStatus.Text = "✔  Listo";
            this.lblVer.Text = "v1.0  ·  Inventario Videojuegos";
            this.lblVer.Spring = true;
            this.lblVer.TextAlign = ContentAlignment.MiddleRight;
            this.statusStrip.Items.AddRange(new ToolStripItem[] { this.lblStatus, this.lblVer });

            // Form
            this.ClientSize = new Size(620, 320);
            this.Controls.Add(this.tableNav);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Text = "Inventario de Videojuegos";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);

            this.panelHeader.ResumeLayout(false);
            this.tableNav.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigNav(Button btn, string icono, string texto,
            Color color, System.EventHandler handler)
        {
            btn.Text = icono + "\n" + texto;
            btn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = color;
            btn.FlatAppearance.BorderSize = 2;
            btn.BackColor = Color.White;
            btn.ForeColor = color;
            btn.Size = new Size(128, 120);
            btn.Anchor = AnchorStyles.None;
            btn.Cursor = Cursors.Hand;
            btn.Click += handler;
        }

        private Panel panelHeader;
        private Label lblTitulo, lblSubtitulo;
        private TableLayoutPanel tableNav;
        private Button btnProductos, btnEntradas, btnSalidas, btnInformes;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus, lblVer;
    }
}