namespace EjercicioClientes
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
            // ── Controles ──────────────────────────────────────────────────────
            this.groupBoxDatos      = new System.Windows.Forms.GroupBox();
            this.lblDNI             = new System.Windows.Forms.Label();
            this.lblCiudad          = new System.Windows.Forms.Label();
            this.lblNombre          = new System.Windows.Forms.Label();
            this.txtDNI             = new System.Windows.Forms.TextBox();
            this.txtCiudad          = new System.Windows.Forms.TextBox();
            this.txtNombre          = new System.Windows.Forms.TextBox();
            this.btnRegistrar       = new System.Windows.Forms.Button();
            this.groupBoxLista      = new System.Windows.Forms.GroupBox();
            this.listBoxClientes    = new System.Windows.Forms.ListBox();
            this.btnCargar          = new System.Windows.Forms.Button();

            // ── groupBoxDatos ──────────────────────────────────────────────────
            this.groupBoxDatos.Text     = "Datos del Cliente";
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Size     = new System.Drawing.Size(560, 170);
            this.groupBoxDatos.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // lblDNI
            this.lblDNI.Text     = "DNI (Código)";
            this.lblDNI.Location = new System.Drawing.Point(15, 30);
            this.lblDNI.Size     = new System.Drawing.Size(100, 20);
            this.lblDNI.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // lblCiudad
            this.lblCiudad.Text     = "Ciudad";
            this.lblCiudad.Location = new System.Drawing.Point(290, 30);
            this.lblCiudad.Size     = new System.Drawing.Size(60, 20);
            this.lblCiudad.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtDNI
            this.txtDNI.Location = new System.Drawing.Point(15, 55);
            this.txtDNI.Size     = new System.Drawing.Size(250, 23);

            // txtCiudad
            this.txtCiudad.Location = new System.Drawing.Point(290, 55);
            this.txtCiudad.Size     = new System.Drawing.Size(250, 23);

            // lblNombre
            this.lblNombre.Text     = "Nombre Completo";
            this.lblNombre.Location = new System.Drawing.Point(15, 90);
            this.lblNombre.Size     = new System.Drawing.Size(130, 20);
            this.lblNombre.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(15, 113);
            this.txtNombre.Size     = new System.Drawing.Size(525, 23);

            // btnRegistrar
            this.btnRegistrar.Text     = "Registrar Cliente";
            this.btnRegistrar.Location = new System.Drawing.Point(15, 140);
            this.btnRegistrar.Size     = new System.Drawing.Size(130, 23);
            this.btnRegistrar.Click   += new System.EventHandler(this.btnRegistrar_Click);

            // Agregar controles a groupBoxDatos
            this.groupBoxDatos.Controls.Add(this.lblDNI);
            this.groupBoxDatos.Controls.Add(this.lblCiudad);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.txtDNI);
            this.groupBoxDatos.Controls.Add(this.txtCiudad);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.btnRegistrar);

            // ── groupBoxLista ──────────────────────────────────────────────────
            this.groupBoxLista.Text     = "Clientes Registrados";
            this.groupBoxLista.Location = new System.Drawing.Point(12, 195);
            this.groupBoxLista.Size     = new System.Drawing.Size(560, 230);
            this.groupBoxLista.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // listBoxClientes
            this.listBoxClientes.Location = new System.Drawing.Point(15, 25);
            this.listBoxClientes.Size     = new System.Drawing.Size(525, 160);
            this.listBoxClientes.Font     = new System.Drawing.Font("Consolas", 9F);

            // btnCargar
            this.btnCargar.Text     = "Cargar desde Archivo";
            this.btnCargar.Location = new System.Drawing.Point(15, 195);
            this.btnCargar.Size     = new System.Drawing.Size(150, 23);
            this.btnCargar.Click   += new System.EventHandler(this.btnCargar_Click);

            // Agregar controles a groupBoxLista
            this.groupBoxLista.Controls.Add(this.listBoxClientes);
            this.groupBoxLista.Controls.Add(this.btnCargar);

            // ── Form1 ──────────────────────────────────────────────────────────
            this.Text            = "Gestión de Clientes";
            this.ClientSize      = new System.Drawing.Size(584, 440);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);

            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxLista);
        }

        #endregion

        // ── Declaración de controles ───────────────────────────────────────────
        private System.Windows.Forms.GroupBox  groupBoxDatos;
        private System.Windows.Forms.GroupBox  groupBoxLista;
        private System.Windows.Forms.Label     lblDNI;
        private System.Windows.Forms.Label     lblCiudad;
        private System.Windows.Forms.Label     lblNombre;
        private System.Windows.Forms.TextBox   txtDNI;
        private System.Windows.Forms.TextBox   txtCiudad;
        private System.Windows.Forms.TextBox   txtNombre;
        private System.Windows.Forms.Button    btnRegistrar;
        private System.Windows.Forms.ListBox   listBoxClientes;
        private System.Windows.Forms.Button    btnCargar;
    }
}
