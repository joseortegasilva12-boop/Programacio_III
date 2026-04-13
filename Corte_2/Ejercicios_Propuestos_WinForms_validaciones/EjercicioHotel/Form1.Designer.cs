namespace EjercicioHotel
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
            this.groupBoxReserva     = new System.Windows.Forms.GroupBox();
            this.lblCliente          = new System.Windows.Forms.Label();
            this.txtCliente          = new System.Windows.Forms.TextBox();
            this.lblEntrada          = new System.Windows.Forms.Label();
            this.dtpEntrada          = new System.Windows.Forms.DateTimePicker();
            this.lblSalida           = new System.Windows.Forms.Label();
            this.dtpSalida           = new System.Windows.Forms.DateTimePicker();
            this.lblPersonas         = new System.Windows.Forms.Label();
            this.numPersonas         = new System.Windows.Forms.NumericUpDown();
            this.lblServicios        = new System.Windows.Forms.Label();
            this.clbServicios        = new System.Windows.Forms.CheckedListBox();
            this.btnCalcularReserva  = new System.Windows.Forms.Button();
            this.btnLimpiar          = new System.Windows.Forms.Button();
            this.groupBoxResumen     = new System.Windows.Forms.GroupBox();
            this.rtbResumen          = new System.Windows.Forms.RichTextBox();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();

            // ── errorProvider ────────────────────────────────────────────────────
            this.errorProvider.ContainerControl = this;

            // ── groupBoxReserva ──────────────────────────────────────────────────
            this.groupBoxReserva.Text     = "Datos de la Reserva";
            this.groupBoxReserva.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReserva.Size     = new System.Drawing.Size(370, 370);
            this.groupBoxReserva.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // Cliente
            this.lblCliente.Text     = "Nombre del Cliente";
            this.lblCliente.Location = new System.Drawing.Point(15, 30);
            this.lblCliente.Size     = new System.Drawing.Size(140, 18);
            this.lblCliente.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtCliente.Location = new System.Drawing.Point(15, 52);
            this.txtCliente.Size     = new System.Drawing.Size(335, 23);
            this.txtCliente.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Fecha Entrada
            this.lblEntrada.Text     = "Fecha de Entrada";
            this.lblEntrada.Location = new System.Drawing.Point(15, 90);
            this.lblEntrada.Size     = new System.Drawing.Size(120, 18);
            this.lblEntrada.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.dtpEntrada.Location = new System.Drawing.Point(15, 112);
            this.dtpEntrada.Size     = new System.Drawing.Size(155, 23);
            this.dtpEntrada.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEntrada.Format   = System.Windows.Forms.DateTimePickerFormat.Short;

            // Fecha Salida
            this.lblSalida.Text     = "Fecha de Salida";
            this.lblSalida.Location = new System.Drawing.Point(195, 90);
            this.lblSalida.Size     = new System.Drawing.Size(115, 18);
            this.lblSalida.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.dtpSalida.Location = new System.Drawing.Point(195, 112);
            this.dtpSalida.Size     = new System.Drawing.Size(155, 23);
            this.dtpSalida.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSalida.Format   = System.Windows.Forms.DateTimePickerFormat.Short;

            // Personas
            this.lblPersonas.Text     = "N.º de Personas";
            this.lblPersonas.Location = new System.Drawing.Point(15, 152);
            this.lblPersonas.Size     = new System.Drawing.Size(120, 18);
            this.lblPersonas.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.numPersonas.Location = new System.Drawing.Point(15, 174);
            this.numPersonas.Size     = new System.Drawing.Size(80, 23);
            this.numPersonas.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.numPersonas.Minimum  = 1;
            this.numPersonas.Maximum  = 4;
            this.numPersonas.Value    = 1;

            // Servicios Adicionales
            this.lblServicios.Text     = "Servicios Adicionales ($10 c/u por noche)";
            this.lblServicios.Location = new System.Drawing.Point(15, 215);
            this.lblServicios.Size     = new System.Drawing.Size(310, 18);
            this.lblServicios.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.clbServicios.Location       = new System.Drawing.Point(15, 237);
            this.clbServicios.Size           = new System.Drawing.Size(335, 84);
            this.clbServicios.Font           = new System.Drawing.Font("Segoe UI", 9F);
            this.clbServicios.CheckOnClick   = true;
            this.clbServicios.Items.AddRange(new object[] {
                "WiFi Premium",
                "Desayuno Buffet",
                "Estacionamiento",
                "Spa"
            });

            // Botones
            this.btnCalcularReserva.Text      = "Calcular Reserva";
            this.btnCalcularReserva.Location  = new System.Drawing.Point(15, 330);
            this.btnCalcularReserva.Size      = new System.Drawing.Size(140, 34);
            this.btnCalcularReserva.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalcularReserva.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnCalcularReserva.ForeColor = System.Drawing.Color.White;
            this.btnCalcularReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularReserva.Click    += new System.EventHandler(this.btnCalcularReserva_Click);

            this.btnLimpiar.Text     = "Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(170, 330);
            this.btnLimpiar.Size     = new System.Drawing.Size(90, 34);
            this.btnLimpiar.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.Click   += new System.EventHandler(this.btnLimpiar_Click);

            this.groupBoxReserva.Controls.Add(this.lblCliente);
            this.groupBoxReserva.Controls.Add(this.txtCliente);
            this.groupBoxReserva.Controls.Add(this.lblEntrada);
            this.groupBoxReserva.Controls.Add(this.dtpEntrada);
            this.groupBoxReserva.Controls.Add(this.lblSalida);
            this.groupBoxReserva.Controls.Add(this.dtpSalida);
            this.groupBoxReserva.Controls.Add(this.lblPersonas);
            this.groupBoxReserva.Controls.Add(this.numPersonas);
            this.groupBoxReserva.Controls.Add(this.lblServicios);
            this.groupBoxReserva.Controls.Add(this.clbServicios);
            this.groupBoxReserva.Controls.Add(this.btnCalcularReserva);
            this.groupBoxReserva.Controls.Add(this.btnLimpiar);

            // ── groupBoxResumen ──────────────────────────────────────────────────
            this.groupBoxResumen.Text     = "Resumen de la Reserva";
            this.groupBoxResumen.Location = new System.Drawing.Point(395, 12);
            this.groupBoxResumen.Size     = new System.Drawing.Size(370, 370);
            this.groupBoxResumen.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.rtbResumen.Location  = new System.Drawing.Point(15, 25);
            this.rtbResumen.Size      = new System.Drawing.Size(340, 330);
            this.rtbResumen.Font      = new System.Drawing.Font("Consolas", 9.5F);
            this.rtbResumen.ReadOnly  = true;
            this.rtbResumen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.groupBoxResumen.Controls.Add(this.rtbResumen);

            // ── Form1 ────────────────────────────────────────────────────────────
            this.Text            = "Sistema de Reserva de Hotel";
            this.ClientSize      = new System.Drawing.Size(779, 395);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);

            this.Controls.Add(this.groupBoxReserva);
            this.Controls.Add(this.groupBoxResumen);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
        }

        #endregion

        private System.Windows.Forms.ErrorProvider     errorProvider;
        private System.Windows.Forms.GroupBox          groupBoxReserva;
        private System.Windows.Forms.Label             lblCliente;
        private System.Windows.Forms.TextBox           txtCliente;
        private System.Windows.Forms.Label             lblEntrada;
        private System.Windows.Forms.DateTimePicker    dtpEntrada;
        private System.Windows.Forms.Label             lblSalida;
        private System.Windows.Forms.DateTimePicker    dtpSalida;
        private System.Windows.Forms.Label             lblPersonas;
        private System.Windows.Forms.NumericUpDown     numPersonas;
        private System.Windows.Forms.Label             lblServicios;
        private System.Windows.Forms.CheckedListBox    clbServicios;
        private System.Windows.Forms.Button            btnCalcularReserva;
        private System.Windows.Forms.Button            btnLimpiar;
        private System.Windows.Forms.GroupBox          groupBoxResumen;
        private System.Windows.Forms.RichTextBox       rtbResumen;
    }
}
