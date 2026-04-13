using System;
using System.Text;
using System.Windows.Forms;

namespace EjercicioHotel
{
    public partial class Form1 : Form
    {
        // Tarifas constantes del sistema
        private const double COSTO_BASE_NOCHE      = 50.0;   // Por noche
        private const double COSTO_PERSONA_EXTRA   = 15.0;   // A partir de la 2da persona
        private const double COSTO_SERVICIO_DIARIO = 10.0;   // Por servicio por día

        public Form1()
        {
            InitializeComponent();

            // Configurar fechas por defecto al cargar el formulario
            dtpEntrada.MinDate = DateTime.Today;
            dtpSalida.MinDate  = DateTime.Today.AddDays(1);
        }

        // ─── BOTÓN: Calcular Reserva ─────────────────────────────────────────────
        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool esValido = true;

            // 1. Validar nombre del cliente
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                errorProvider.SetError(txtCliente, "El nombre del cliente es obligatorio.");
                esValido = false;
            }

            // 2. Validar que la fecha de entrada NO sea anterior a hoy
            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                errorProvider.SetError(dtpEntrada, "La fecha de entrada no puede ser anterior a hoy.");
                esValido = false;
            }

            // 3. Validar que la fecha de salida sea al menos 1 día después de la entrada
            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                errorProvider.SetError(dtpSalida, "La fecha de salida debe ser al menos un día posterior a la entrada.");
                esValido = false;
            }

            if (!esValido)
            {
                rtbResumen.Text = "⚠ Corrija los errores indicados antes de calcular.";
                return;
            }

            // ── Cálculo de días usando TimeSpan ──────────────────────────────────
            TimeSpan diferencia = dtpSalida.Value.Date - dtpEntrada.Value.Date;
            int totalDias = diferencia.Days;

            // ── Cálculo del costo ────────────────────────────────────────────────
            int personas = (int)numPersonas.Value;

            // Costo base: $50 por noche
            double costoBase = COSTO_BASE_NOCHE * totalDias;

            // Costo personas adicionales: $15 por cada persona extra (desde la 2da)
            int personasExtras = Math.Max(0, personas - 1);
            double costoPersonas = personasExtras * COSTO_PERSONA_EXTRA * totalDias;

            // Costo servicios: $10 por servicio seleccionado por día
            int cantidadServicios = clbServicios.CheckedItems.Count;
            double costoServicios = cantidadServicios * COSTO_SERVICIO_DIARIO * totalDias;

            double totalAPagar = costoBase + costoPersonas + costoServicios;

            // ── Construir lista de servicios seleccionados ───────────────────────
            string listaServicios;
            if (cantidadServicios == 0)
            {
                listaServicios = "Ninguno";
            }
            else
            {
                var sb = new StringBuilder();
                foreach (var item in clbServicios.CheckedItems)
                    sb.AppendLine($"   • {item}");
                listaServicios = sb.ToString().TrimEnd();
            }

            // ── Construir el resumen en el RichTextBox ───────────────────────────
            var resumen = new StringBuilder();
            resumen.AppendLine("--- RESUMEN DE RESERVA ---");
            resumen.AppendLine($"Cliente:  {txtCliente.Text.Trim()}");
            resumen.AppendLine($"Estancia: {totalDias} noche(s)  " +
                               $"({dtpEntrada.Value:dd/MM/yyyy} → {dtpSalida.Value:dd/MM/yyyy})");
            resumen.AppendLine($"Personas: {personas}");
            resumen.AppendLine($"Servicios:\n{listaServicios}");
            resumen.AppendLine("--------------------------");
            resumen.AppendLine($"Costo base:          ${costoBase:F2}  ({totalDias} noches × ${COSTO_BASE_NOCHE})");

            if (personasExtras > 0)
                resumen.AppendLine($"Personas adicionales: ${costoPersonas:F2}  " +
                                   $"({personasExtras} pers. × ${COSTO_PERSONA_EXTRA} × {totalDias} noches)");

            if (cantidadServicios > 0)
                resumen.AppendLine($"Servicios:           ${costoServicios:F2}  " +
                                   $"({cantidadServicios} serv. × ${COSTO_SERVICIO_DIARIO} × {totalDias} noches)");

            resumen.AppendLine("--------------------------");
            resumen.AppendLine($"TOTAL A PAGAR: ${totalAPagar:F2}");

            rtbResumen.Text = resumen.ToString();
        }

        // ─── BOTÓN: Limpiar ──────────────────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtCliente.Clear();
            dtpEntrada.Value   = DateTime.Today;
            dtpSalida.Value    = DateTime.Today.AddDays(1);
            numPersonas.Value  = 1;
            rtbResumen.Clear();

            // Desmarcar todos los servicios
            for (int i = 0; i < clbServicios.Items.Count; i++)
                clbServicios.SetItemChecked(i, false);

            txtCliente.Focus();
        }
    }
}
