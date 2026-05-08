using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.views
{
    partial class FormEntradas
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
            this.lblProd = new Label();
            this.cmbProducto = new ComboBox();
            this.lblCant = new Label();
            this.nudCantidad = new NumericUpDown();
            this.lblObs = new Label();
            this.txtObs = new TextBox();
            this.panelBtns = new Panel();
            this.btnRegistrar = new Button();
            this.grpHistorial = new GroupBox();
            this.dgv = new DataGridView();
            this.panelBtnsR = new Panel();
            this.btnActualizar = new Button();
            this.statusBar = new StatusStrip();
            this.lblStatus = new ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.split).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgv).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(39, 174, 96);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 65;
            this.panelHeader.Controls.Add(this.lblSub);
            this.panelHeader.Controls.Add(this.lblTitulo);

            this.lblTitulo.Text = "📥  Entradas de Stock";
            this.lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(14, 10);
            this.lblTitulo.Size = new Size(340, 24);

            this.lblSub.Text = "Registrar ingreso de videojuegos al inventario";
            this.lblSub.Font = new Font("Segoe UI", 8F);
            this.lblSub.ForeColor = Color.FromArgb(210, 245, 210);
            this.lblSub.Location = new Point(16, 36);
            this.lblSub.Size = new Size(380, 18);

            // SplitContainer
            this.split.Dock = DockStyle.Fill;
            this.split.SplitterDistance = 260;
            this.split.Panel1.Controls.Add(this.grpForm);
            this.split.Panel2.Controls.Add(this.panelBtnsR);
            this.split.Panel2.Controls.Add(this.grpHistorial);

            // GroupBox formulario
            this.grpForm.Text = "Nueva Entrada";
            this.grpForm.Dock = DockStyle.Fill;
            this.grpForm.Padding = new Padding(8);
            this.grpForm.Controls.Add(this.panelBtns);
            this.grpForm.Controls.Add(this.tbl);

            // TableLayoutPanel
            this.tbl.ColumnCount = 2;
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tbl.RowCount = 3;
            for (int i = 0; i < 3; i++)
                this.tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            this.tbl.Dock = DockStyle.Top;
            this.tbl.Height = 115;
            this.tbl.Padding = new Padding(4);

            // Labels
            CL(this.lblProd, "Videojuego:");
            CL(this.lblCant, "Cantidad:");
            CL(this.lblObs, "Observación:");

            // Inputs
            this.cmbProducto.Dock = DockStyle.Fill;
            this.cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            this.nudCantidad.Dock = DockStyle.Fill;
            this.nudCantidad.Minimum = 1;
            this.nudCantidad.Maximum = 9999;
            this.nudCantidad.Value = 1;

            this.txtObs.Dock = DockStyle.Fill;
            this.txtObs.PlaceholderText = "Ej: Reposición mensual";

            // Agregar a tabla
            this.tbl.Controls.Add(this.lblProd, 0, 0);
            this.tbl.Controls.Add(this.cmbProducto, 1, 0);
            this.tbl.Controls.Add(this.lblCant, 0, 1);
            this.tbl.Controls.Add(this.nudCantidad, 1, 1);
            this.tbl.Controls.Add(this.lblObs, 0, 2);
            this.tbl.Controls.Add(this.txtObs, 1, 2);

            // Panel botones
            this.panelBtns.Dock = DockStyle.Top;
            this.panelBtns.Height = 38;
            this.panelBtns.Padding = new Padding(4, 4, 4, 0);
            this.panelBtns.Controls.Add(this.btnRegistrar);

            this.btnRegistrar.Text = "📥  Registrar Entrada";
            this.btnRegistrar.Dock = DockStyle.Left;
            this.btnRegistrar.Width = 160;
            this.btnRegistrar.BackColor = Color.FromArgb(39, 174, 96);
            this.btnRegistrar.ForeColor = Color.White;
            this.btnRegistrar.FlatStyle = FlatStyle.Flat;
            this.btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // GroupBox historial
            this.grpHistorial.Text = "Historial de Entradas";
            this.grpHistorial.Dock = DockStyle.Fill;
            this.grpHistorial.Controls.Add(this.dgv);

            // DataGridView
            this.dgv.Dock = DockStyle.Fill;
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.RowHeadersVisible = false;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 174, 96);
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 245);
            this.dgv.Columns.Add("cFec", "Fecha");
            this.dgv.Columns.Add("cCod", "Código");
            this.dgv.Columns.Add("cCan", "Cantidad");
            this.dgv.Columns.Add("cObs", "Observación");
            this.dgv.Columns["cFec"].FillWeight = 20;
            this.dgv.Columns["cCod"].FillWeight = 18;
            this.dgv.Columns["cCan"].FillWeight = 15;

            // Panel botones derecho
            this.panelBtnsR.Dock = DockStyle.Bottom;
            this.panelBtnsR.Height = 38;
            this.panelBtnsR.Padding = new Padding(4);
            this.panelBtnsR.Controls.Add(this.btnActualizar);

            this.btnActualizar.Text = "🔄  Actualizar";
            this.btnActualizar.Location = new Point(4, 4);
            this.btnActualizar.Size = new Size(130, 28);
            this.btnActualizar.FlatStyle = FlatStyle.Flat;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // StatusStrip
            this.lblStatus.Text = "Entradas registradas: 0";
            this.statusBar.Items.Add(this.lblStatus);

            // Form
            this.ClientSize = new Size(900, 460);
            this.Text = "Entradas de Stock";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.split);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusBar);

            this.panelHeader.ResumeLayout(false);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            this.split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgv).EndInit();
            this.statusBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CL(Label l, string t)
        {
            l.Text = t;
            l.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            l.ForeColor = Color.FromArgb(60, 60, 60);
            l.Dock = DockStyle.Fill;
            l.TextAlign = ContentAlignment.MiddleRight;
        }

        private Panel panelHeader, panelBtns, panelBtnsR;
        private Label lblTitulo, lblSub, lblProd, lblCant, lblObs;
        private SplitContainer split;
        private GroupBox grpForm, grpHistorial;
        private TableLayoutPanel tbl;
        private ComboBox cmbProducto;
        private NumericUpDown nudCantidad;
        private TextBox txtObs;
        private Button btnRegistrar, btnActualizar;
        private DataGridView dgv;
        private StatusStrip statusBar;
        private ToolStripStatusLabel lblStatus;
    }
}