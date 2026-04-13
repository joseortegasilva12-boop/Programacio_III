namespace EjercicioEmpleados
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
            this.components         = new System.ComponentModel.Container();
            this.errorProvider      = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDatos      = new System.Windows.Forms.GroupBox();
            this.lblNombres         = new System.Windows.Forms.Label();
            this.txtNombres         = new System.Windows.Forms.TextBox();
            this.lblApellidos       = new System.Windows.Forms.Label();
            this.txtApellidos       = new System.Windows.Forms.TextBox();
            this.lblEmail           = new System.Windows.Forms.Label();
            this.txtEmail           = new System.Windows.Forms.TextBox();
            this.lblIdentificacion  = new System.Windows.Forms.Label();
            this.txtIdentificacion  = new System.Windows.Forms.TextBox();
            this.lblDepartamento    = new System.Windows.Forms.Label();
            this.cmbDepartamento    = new System.Windows.Forms.ComboBox();
            this.lblSueldoBase      = new System.Windows.Forms.Label();
            this.numSueldoBase      = new System.Windows.Forms.NumericUpDown();
            this.groupBoxResultado  = new System.Windows.Forms.GroupBox();
            this.lblResultadoSueldo = new System.Windows.Forms.Label();
            this.btnRegistrar       = new System.Windows.Forms.Button();
            this.btnLimpiar         = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).BeginInit();

            // ── errorProvider ────────────────────────────────────────────────────
            this.errorProvider.ContainerControl = this;

            // ── groupBoxDatos ────────────────────────────────────────────────────
            this.groupBoxDatos.Text     = "Datos del Empleado";
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Size     = new System.Drawing.Size(580, 290);
            this.groupBoxDatos.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // Nombres
            this.lblNombres.Text     = "Nombres";
            this.lblNombres.Location = new System.Drawing.Point(15, 30);
            this.lblNombres.Size     = new System.Drawing.Size(60, 18);
            this.lblNombres.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtNombres.Location = new System.Drawing.Point(15, 52);
            this.txtNombres.Size     = new System.Drawing.Size(250, 23);
            this.txtNombres.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Apellidos
            this.lblApellidos.Text     = "Apellidos";
            this.lblApellidos.Location = new System.Drawing.Point(300, 30);
            this.lblApellidos.Size     = new System.Drawing.Size(65, 18);
            this.lblApellidos.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtApellidos.Location = new System.Drawing.Point(300, 52);
            this.txtApellidos.Size     = new System.Drawing.Size(250, 23);
            this.txtApellidos.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Email
            this.lblEmail.Text     = "Email";
            this.lblEmail.Location = new System.Drawing.Point(15, 90);
            this.lblEmail.Size     = new System.Drawing.Size(40, 18);
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtEmail.Location = new System.Drawing.Point(15, 112);
            this.txtEmail.Size     = new System.Drawing.Size(535, 23);
            this.txtEmail.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Identificación
            this.lblIdentificacion.Text     = "Identificación (10 dígitos)";
            this.lblIdentificacion.Location = new System.Drawing.Point(15, 150);
            this.lblIdentificacion.Size     = new System.Drawing.Size(180, 18);
            this.lblIdentificacion.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtIdentificacion.Location  = new System.Drawing.Point(15, 172);
            this.txtIdentificacion.Size      = new System.Drawing.Size(200, 23);
            this.txtIdentificacion.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentificacion.MaxLength = 10;

            // Departamento
            this.lblDepartamento.Text     = "Departamento";
            this.lblDepartamento.Location = new System.Drawing.Point(240, 150);
            this.lblDepartamento.Size     = new System.Drawing.Size(100, 18);
            this.lblDepartamento.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.cmbDepartamento.Location     = new System.Drawing.Point(240, 172);
            this.cmbDepartamento.Size         = new System.Drawing.Size(180, 23);
            this.cmbDepartamento.Font         = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Items.AddRange(new object[] {
                "Ventas", "IT", "Recursos Humanos", "Contabilidad" });

            // Sueldo Base
            this.lblSueldoBase.Text     = "Sueldo Base ($)";
            this.lblSueldoBase.Location = new System.Drawing.Point(440, 150);
            this.lblSueldoBase.Size     = new System.Drawing.Size(110, 18);
            this.lblSueldoBase.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.numSueldoBase.Location      = new System.Drawing.Point(440, 172);
            this.numSueldoBase.Size          = new System.Drawing.Size(110, 23);
            this.numSueldoBase.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.numSueldoBase.Minimum       = 1000;
            this.numSueldoBase.Maximum       = 10000;
            this.numSueldoBase.Value         = 1000;
            this.numSueldoBase.DecimalPlaces = 2;
            this.numSueldoBase.ThousandsSeparator = true;

            // Botones dentro del groupBox
            this.btnRegistrar.Text     = "Registrar";
            this.btnRegistrar.Location = new System.Drawing.Point(15, 245);
            this.btnRegistrar.Size     = new System.Drawing.Size(110, 32);
            this.btnRegistrar.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Click    += new System.EventHandler(this.btnRegistrar_Click);

            this.btnLimpiar.Text     = "Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(140, 245);
            this.btnLimpiar.Size     = new System.Drawing.Size(110, 32);
            this.btnLimpiar.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.Click   += new System.EventHandler(this.btnLimpiar_Click);

            this.groupBoxDatos.Controls.Add(this.lblNombres);
            this.groupBoxDatos.Controls.Add(this.txtNombres);
            this.groupBoxDatos.Controls.Add(this.lblApellidos);
            this.groupBoxDatos.Controls.Add(this.txtApellidos);
            this.groupBoxDatos.Controls.Add(this.lblEmail);
            this.groupBoxDatos.Controls.Add(this.txtEmail);
            this.groupBoxDatos.Controls.Add(this.lblIdentificacion);
            this.groupBoxDatos.Controls.Add(this.txtIdentificacion);
            this.groupBoxDatos.Controls.Add(this.lblDepartamento);
            this.groupBoxDatos.Controls.Add(this.cmbDepartamento);
            this.groupBoxDatos.Controls.Add(this.lblSueldoBase);
            this.groupBoxDatos.Controls.Add(this.numSueldoBase);
            this.groupBoxDatos.Controls.Add(this.btnRegistrar);
            this.groupBoxDatos.Controls.Add(this.btnLimpiar);

            // ── groupBoxResultado ────────────────────────────────────────────────
            this.groupBoxResultado.Text     = "Resultado";
            this.groupBoxResultado.Location = new System.Drawing.Point(12, 315);
            this.groupBoxResultado.Size     = new System.Drawing.Size(580, 65);
            this.groupBoxResultado.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.lblResultadoSueldo.Text      = "El sueldo neto se mostrará aquí tras el registro.";
            this.lblResultadoSueldo.Location  = new System.Drawing.Point(15, 28);
            this.lblResultadoSueldo.Size      = new System.Drawing.Size(550, 22);
            this.lblResultadoSueldo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResultadoSueldo.ForeColor = System.Drawing.Color.Gray;

            this.groupBoxResultado.Controls.Add(this.lblResultadoSueldo);

            // ── Form1 ────────────────────────────────────────────────────────────
            this.Text            = "Sistema de Registro de Empleados";
            this.ClientSize      = new System.Drawing.Size(604, 395);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);

            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxResultado);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).EndInit();
        }

        #endregion

        private System.Windows.Forms.ErrorProvider    errorProvider;
        private System.Windows.Forms.GroupBox         groupBoxDatos;
        private System.Windows.Forms.GroupBox         groupBoxResultado;
        private System.Windows.Forms.Label            lblNombres;
        private System.Windows.Forms.TextBox          txtNombres;
        private System.Windows.Forms.Label            lblApellidos;
        private System.Windows.Forms.TextBox          txtApellidos;
        private System.Windows.Forms.Label            lblEmail;
        private System.Windows.Forms.TextBox          txtEmail;
        private System.Windows.Forms.Label            lblIdentificacion;
        private System.Windows.Forms.TextBox          txtIdentificacion;
        private System.Windows.Forms.Label            lblDepartamento;
        private System.Windows.Forms.ComboBox         cmbDepartamento;
        private System.Windows.Forms.Label            lblSueldoBase;
        private System.Windows.Forms.NumericUpDown    numSueldoBase;
        private System.Windows.Forms.Label            lblResultadoSueldo;
        private System.Windows.Forms.Button           btnRegistrar;
        private System.Windows.Forms.Button           btnLimpiar;
    }
}
