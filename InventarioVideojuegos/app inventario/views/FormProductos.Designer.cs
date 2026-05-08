using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.views
{
    partial class FormProductos
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
            this.lblSub = new Label();
            this.split = new SplitContainer();
            this.grpForm = new GroupBox();
            this.tbl = new TableLayoutPanel();
            this.lblCodigo = new Label();
            this.txtCodigo = new TextBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblGenero = new Label();
            this.cmbGenero = new ComboBox();
            this.lblPlat = new Label();
            this.cmbPlataforma = new ComboBox();
            this.lblPrecio = new Label();
            this.txtPrecio = new TextBox();
            this.lblStock = new Label();
            this.nudStock = new NumericUpDown();
            this.panelBtns = new Panel();
            this.btnGuardar = new Button();
            this.btnLimpiar = new Button();
            this.grpTabla = new GroupBox();
            this.dgv = new DataGridView();
            this.panelBtnsR = new Panel();
            this.btnEliminar = new Button();
            this.statusBar = new StatusStrip();
            this.lblStatus = new ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.split).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgv).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblSub);
            this.panelHeader.Controls.Add(this.lblTitulo);

            this.lblTitulo.Text = "🎮  Videojuegos";
            this.lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(14, 10);
            this.lblTitulo.Size = new Size(300, 24);

            this.lblSub.Text = "Registro y gestión de videojuegos en el inventario";
            this.lblSub.Font = new Font("Segoe UI", 8F);
            this.lblSub.ForeColor = Color.FromArgb(210, 235, 255);
            this.lblSub.Location = new Point(16, 36);
            this.lblSub.Size = new Size(380, 18);

            // SplitContainer
            this.split.Dock = DockStyle.Fill;
            this.split.SplitterDistance = 250;
            this.split.Panel1.Controls.Add(this.grpForm);
            this.split.Panel2.Controls.Add(this.panelBtnsR);
            this.split.Panel2.Controls.Add(this.grpTabla);

            // GroupBox formulario
            this.grpForm.Text = "Datos del Videojuego";
            this.grpForm.Dock = DockStyle.Fill;
            this.grpForm.Padding = new Padding(8);
            this.grpForm.Controls.Add(this.panelBtns);
            this.grpForm.Controls.Add(this.tbl);

            // TableLayoutPanel
            this.tbl.ColumnCount = 2;
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tbl.RowCount = 6;
            for (int i = 0; i < 6; i++)
                this.tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            this.tbl.Dock = DockStyle.Top;
            this.tbl.Height = 205;
            this.tbl.Padding = new Padding(4);

            // Labels
            CL(this.lblCodigo, "Código:");
            CL(this.lblNombre, "Nombre:");
            CL(this.lblGenero, "Género:");
            CL(this.lblPlat, "Plataforma:");
            CL(this.lblPrecio, "Precio ($):");
            CL(this.lblStock, "Stock ini.:");

            // Inputs
            this.txtCodigo.Dock = DockStyle.Fill;
            this.txtCodigo.PlaceholderText = "Ej: VJ001";
            this.txtNombre.Dock = DockStyle.Fill;
            this.txtNombre.PlaceholderText = "Ej: The Last of Us";
            this.txtPrecio.Dock = DockStyle.Fill;
            this.txtPrecio.PlaceholderText = "Ej: 299900";

            this.cmbGenero.Dock = DockStyle.Fill;
            this.cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGenero.Items.AddRange(new object[] {
                "Acción","Aventura","RPG","Deportes",
                "Estrategia","Simulación","Terror","Carreras" });

            this.cmbPlataforma.Dock = DockStyle.Fill;
            this.cmbPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPlataforma.Items.AddRange(new object[] {
                "PlayStation 5","PlayStation 4","Xbox Series X",
                "Xbox One","Nintendo Switch","PC","iOS","Android" });

            this.nudStock.Dock = DockStyle.Fill;
            this.nudStock.Maximum = 9999;

            // Agregar controles a tabla
            this.tbl.Controls.Add(this.lblCodigo, 0, 0);
            this.tbl.Controls.Add(this.txtCodigo, 1, 0);
            this.tbl.Controls.Add(this.lblNombre, 0, 1);
            this.tbl.Controls.Add(this.txtNombre, 1, 1);
            this.tbl.Controls.Add(this.lblGenero, 0, 2);
            this.tbl.Controls.Add(this.cmbGenero, 1, 2);
            this.tbl.Controls.Add(this.lblPlat, 0, 3);
            this.tbl.Controls.Add(this.cmbPlataforma, 1, 3);
            this.tbl.Controls.Add(this.lblPrecio, 0, 4);
            this.tbl.Controls.Add(this.txtPrecio, 1, 4);
            this.tbl.Controls.Add(this.lblStock, 0, 5);
            this.tbl.Controls.Add(this.nudStock, 1, 5);

            // Panel botones izquierdo