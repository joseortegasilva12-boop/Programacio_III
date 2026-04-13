namespace EjercicioVentas
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
            this.groupBoxNuevaVenta = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxHistorial = new System.Windows.Forms.GroupBox();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBoxNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.groupBoxHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNuevaVenta
            // 
            this.groupBoxNuevaVenta.Controls.Add(this.lblID);
            this.groupBoxNuevaVenta.Controls.Add(this.lblMonto);
            this.groupBoxNuevaVenta.Controls.Add(this.txtID);
            this.groupBoxNuevaVenta.Controls.Add(this.numMonto);
            this.groupBoxNuevaVenta.Controls.Add(this.btnGuardar);
            this.groupBoxNuevaVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxNuevaVenta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNuevaVenta.Name = "groupBoxNuevaVenta";
            this.groupBoxNuevaVenta.Size = new System.Drawing.Size(560, 110);
            this.groupBoxNuevaVenta.TabIndex = 0;
            this.groupBoxNuevaVenta.TabStop = false;
            this.groupBoxNuevaVenta.Text = "Nueva Venta";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(15, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Transacción";
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonto.Location = new System.Drawing.Point(290, 28);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(80, 20);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto ($)";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 23);
            this.txtID.TabIndex = 2;
            // 
            // numMonto
            // 
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Location = new System.Drawing.Point(290, 50);
            this.numMonto.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(150, 23);
            this.numMonto.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 80);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Transacción";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxHistorial
            // 
            this.groupBoxHistorial.Controls.Add(this.listBoxHistorial);
            this.groupBoxHistorial.Controls.Add(this.btnCargar);
            this.groupBoxHistorial.Controls.Add(this.lblTotal);
            this.groupBoxHistorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxHistorial.Location = new System.Drawing.Point(12, 135);
            this.groupBoxHistorial.Name = "groupBoxHistorial";
            this.groupBoxHistorial.Size = new System.Drawing.Size(560, 240);
            this.groupBoxHistorial.TabIndex = 1;
            this.groupBoxHistorial.TabStop = false;
            this.groupBoxHistorial.Text = "Historial";
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.Font = new System.Drawing.Font("Consolas", 9F);
            this.listBoxHistorial.ItemHeight = 14;
            this.listBoxHistorial.Location = new System.Drawing.Point(15, 25);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(525, 158);
            this.listBoxHistorial.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(15, 200);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 28);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(120, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 22);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL: $0.00";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 390);
            this.Controls.Add(this.groupBoxNuevaVenta);
            this.Controls.Add(this.groupBoxHistorial);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNuevaVenta.ResumeLayout(false);
            this.groupBoxNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.groupBoxHistorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Declaración de controles ───────────────────────────────────────────
        private System.Windows.Forms.GroupBox        groupBoxNuevaVenta;
        private System.Windows.Forms.GroupBox        groupBoxHistorial;
        private System.Windows.Forms.Label           lblID;
        private System.Windows.Forms.Label           lblMonto;
        private System.Windows.Forms.TextBox         txtID;
        private System.Windows.Forms.NumericUpDown   numMonto;
        private System.Windows.Forms.Button          btnGuardar;
        private System.Windows.Forms.ListBox         listBoxHistorial;
        private System.Windows.Forms.Button          btnCargar;
        private System.Windows.Forms.Label           lblTotal;
    }
}
