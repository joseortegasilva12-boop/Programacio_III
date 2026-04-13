namespace EjercicioInventario
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components          = new System.ComponentModel.Container();
            this.errorProvider       = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxProducto    = new System.Windows.Forms.GroupBox();
            this.lblCodigo           = new System.Windows.Forms.Label();
            this.txtCodigo           = new System.Windows.Forms.TextBox();
            this.lblNombreProducto   = new System.Windows.Forms.Label();
            this.txtNombreProducto   = new System.Windows.Forms.TextBox();
            this.lblCategoria        = new System.Windows.Forms.Label();
            this.cmbCategoria        = new System.Windows.Forms.ComboBox();
            this.lblStockInicial     = new System.Windows.Forms.Label();
            this.numStockInicial     = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo      = new System.Windows.Forms.Label();
            this.numStockMinimo      = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIVA         = new System.Windows.Forms.GroupBox();
            this.rbExento            = new System.Windows.Forms.RadioButton();
            this.rbGeneral           = new System.Windows.Forms.RadioButton();
            this.rbReducido          = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero     = new System.Windows.Forms.CheckBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar          = new System.Windows.Forms.Button();
            this.btnLimpiar          = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();

            // ── errorProvider ────────────────────────────────────────────────────
            this.errorProvider.ContainerControl = this;

            // ── groupBoxProducto ─────────────────────────────────────────────────
            this.groupBoxProducto.Text     = "Datos del Producto";
            this.groupBoxProducto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProducto.Size     = new System.Drawing.Size(600, 360);
            this.groupBoxProducto.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // Código
            this.lblCodigo.Text     = "Código (PROD-0000)";
            this.lblCodigo.Location = new System.Drawing.Point(15, 30);
            this.lblCodigo.Size     = new System.Drawing.Size(150, 18);
            this.lblCodigo.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtCodigo.Location    = new System.Drawing.Point(15, 52);
            this.txtCodigo.Size        = new System.Drawing.Size(160, 23);
            this.txtCodigo.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.MaxLength   = 9;  // "PROD-" + 4 dígitos

            // Nombre Producto
            this.lblNombreProducto.Text     = "Nombre del Producto";
            this.lblNombreProducto.Location = new System.Drawing.Point(200, 30);
            this.lblNombreProducto.Size     = new System.Drawing.Size(150, 18);
            this.lblNombreProducto.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtNombreProducto.Location = new System.Drawing.Point(200, 52);
            this.txtNombreProducto.Size     = new System.Drawing.Size(370, 23);
            this.txtNombreProducto.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Categoría
            this.lblCategoria.Text     = "Categoría";
            this.lblCategoria.Location = new System.Drawing.Point(15, 90);
            this.lblCategoria.Size     = new System.Drawing.Size(70, 18);
            this.lblCategoria.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.cmbCategoria.Location      = new System.Drawing.Point(15, 112);
            this.cmbCategoria.Size          = new System.Drawing.Size(180, 23);
            this.cmbCategoria.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] { "Electrónica", "Alimentos", "Ropa" });

            // Stock Inicial
            this.lblStockInicial.Text     = "Stock Inicial";
            this.lblStockInicial.Location = new System.Drawing.Point(220, 90);
            this.lblStockInicial.Size     = new System.Drawing.Size(90, 18);
            this.lblStockInicial.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.numStockInicial.Location = new System.Drawing.Point(220, 112);
            this.numStockInicial.Size     = new System.Drawing.Size(120, 23);
            this.numStockInicial.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.numStockInicial.Maximum  = 99999;

            // Stock Mínimo
            this.lblStockMinimo.Text     = "Stock Mínimo";
            this.lblStockMinimo.Location = new System.Drawing.Point(360, 90);
            this.lblStockMinimo.Size     = new System.Drawing.Size(100, 18);
            this.lblStockMinimo.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.numStockMinimo.Location = new System.Drawing.Point(360, 112);
            this.numStockMinimo.Size     = new System.Drawing.Size(120, 23);
            this.numStockMinimo.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.numStockMinimo.Maximum  = 99999;

            // ── groupBoxIVA ──────────────────────────────────────────────────────
            this.groupBoxIVA.Text     = "IVA";
            this.groupBoxIVA.Location = new System.Drawing.Point(15, 155);
            this.groupBoxIVA.Size     = new System.Drawing.Size(250, 80);
            this.groupBoxIVA.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.rbExento.Text     = "Exento (0%)";
            this.rbExento.Location = new System.Drawing.Point(10, 25);
            this.rbExento.Size     = new System.Drawing.Size(95, 20);
            this.rbExento.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.rbGeneral.Text     = "General (19%)";
            this.rbGeneral.Location = new System.Drawing.Point(10, 48);
            this.rbGeneral.Size     = new System.Drawing.Size(105, 20);
            this.rbGeneral.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.rbReducido.Text     = "Reducido (5%)";
            this.rbReducido.Location = new System.Drawing.Point(120, 25);
            this.rbReducido.Size     = new System.Drawing.Size(110, 20);
            this.rbReducido.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.groupBoxIVA.Controls.Add(this.rbExento);
            this.groupBoxIVA.Controls.Add(this.rbGeneral);
            this.groupBoxIVA.Controls.Add(this.rbReducido);

            // CheckBox Perecedero
            this.chkEsPerecedero.Text     = "¿Es Perecedero?";
            this.chkEsPerecedero.Location = new System.Drawing.Point(290, 165);
            this.chkEsPerecedero.Size     = new System.Drawing.Size(130, 22);
            this.chkEsPerecedero.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkEsPerecedero.CheckedChanged += new System.EventHandler(this.chkEsPerecedero_CheckedChanged);

            // Fecha Vencimiento
            this.lblFechaVencimiento.Text     = "Fecha de Vencimiento";
            this.lblFechaVencimiento.Location = new System.Drawing.Point(290, 200);
            this.lblFechaVencimiento.Size     = new System.Drawing.Size(150, 18);
            this.lblFechaVencimiento.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.dtpFechaVencimiento.Location = new System.Drawing.Point(290, 222);
            this.dtpFechaVencimiento.Size     = new System.Drawing.Size(200, 23);
            this.dtpFechaVencimiento.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaVencimiento.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Enabled  = false;

            // Botones
            this.btnAgregar.Text      = "Agregar Producto";
            this.btnAgregar.Location  = new System.Drawing.Point(15, 310);
            this.btnAgregar.Size      = new System.Drawing.Size(140, 34);
            this.btnAgregar.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(0, 150, 80);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Click    += new System.EventHandler(this.btnAgregar_Click);

            this.btnLimpiar.Text     = "Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(170, 310);
            this.btnLimpiar.Size     = new System.Drawing.Size(100, 34);
            this.btnLimpiar.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.Click   += new System.EventHandler(this.btnLimpiar_Click);

            // Agregar todos al groupBox
            this.groupBoxProducto.Controls.Add(this.lblCodigo);
            this.groupBoxProducto.Controls.Add(this.txtCodigo);
            this.groupBoxProducto.Controls.Add(this.lblNombreProducto);
            this.groupBoxProducto.Controls.Add(this.txtNombreProducto);
            this.groupBoxProducto.Controls.Add(this.lblCategoria);
            this.groupBoxProducto.Controls.Add(this.cmbCategoria);
            this.groupBoxProducto.Controls.Add(this.lblStockInicial);
            this.groupBoxProducto.Controls.Add(this.numStockInicial);
            this.groupBoxProducto.Controls.Add(this.lblStockMinimo);
            this.groupBoxProducto.Controls.Add(this.numStockMinimo);
            this.groupBoxProducto.Controls.Add(this.groupBoxIVA);
            this.groupBoxProducto.Controls.Add(this.chkEsPerecedero);
            this.groupBoxProducto.Controls.Add(this.lblFechaVencimiento);
            this.groupBoxProducto.Controls.Add(this.dtpFechaVencimiento);
            this.groupBoxProducto.Controls.Add(this.btnAgregar);
            this.groupBoxProducto.Controls.Add(this.btnLimpiar);

            // ── Form1 ────────────────────────────────────────────────────────────
            this.Text            = "Gestión de Inventario de Productos";
            this.ClientSize      = new System.Drawing.Size(624, 385);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);

            this.Controls.Add(this.groupBoxProducto);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
        }

        #endregion

        private System.Windows.Forms.ErrorProvider    errorProvider;
        private System.Windows.Forms.GroupBox         groupBoxProducto;
        private System.Windows.Forms.Label            lblCodigo;
        private System.Windows.Forms.TextBox          txtCodigo;
        private System.Windows.Forms.Label            lblNombreProducto;
        private System.Windows.Forms.TextBox          txtNombreProducto;
        private System.Windows.Forms.Label            lblCategoria;
        private System.Windows.Forms.ComboBox         cmbCategoria;
        private System.Windows.Forms.Label            lblStockInicial;
        private System.Windows.Forms.NumericUpDown    numStockInicial;
        private System.Windows.Forms.Label            lblStockMinimo;
        private System.Windows.Forms.NumericUpDown    numStockMinimo;
        private System.Windows.Forms.GroupBox         groupBoxIVA;
        private System.Windows.Forms.RadioButton      rbExento;
        private System.Windows.Forms.RadioButton      rbGeneral;
        private System.Windows.Forms.RadioButton      rbReducido;
        private System.Windows.Forms.CheckBox         chkEsPerecedero;
        private System.Windows.Forms.Label            lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker   dtpFechaVencimiento;
        private System.Windows.Forms.Button           btnAgregar;
        private System.Windows.Forms.Button           btnLimpiar;
    }
}
