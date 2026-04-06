namespace PanelConfiguracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configuración inicial de la Pestaña 1 (Apariencia)
            // comboBox1: Selección de Tema
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Claro", "Oscuro", "Azul Cobalto" });
            comboBox1.SelectedIndex = 0;

            // Configuración inicial de la Pestaña 2 (Notificaciones)
            // numericUpDown1: Volumen de alerta
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
            numericUpDown1.Value = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tema = comboBox1.SelectedItem.ToString();

            // Cambiamos el color del Formulario y las Pestañas
            if (tema == "Oscuro")
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                this.ForeColor = Color.White;
                tabPage1.BackColor = Color.FromArgb(45, 45, 48); // Pestaña Apariencia
                tabPage2.BackColor = Color.FromArgb(45, 45, 48); // Pestaña Notificaciones
            }
            else if (tema == "Azul Cobalto")
            {
                // Un azul cobalto elegante (R:0, G:71, B:171)
                Color azulCobalto = Color.FromArgb(0, 71, 171);

                this.BackColor = azulCobalto;
                this.ForeColor = Color.White; // Texto en blanco para que resalte

                // Es vital cambiar también el fondo de las pestañas 
                // porque si no, se verán como parches grises sobre el fondo azul
                tabPage1.BackColor = azulCobalto;
                tabPage2.BackColor = azulCobalto;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
                tabPage1.BackColor = SystemColors.Window;
                tabPage2.BackColor = SystemColors.Window;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recopilamos la info usando los nombres originales de los CheckBox
            string info = "Configuración Actual:\n";
            info += $"- Tema: {comboBox1.Text}\n";
            info += $"- Animaciones: {(checkBox1.Checked ? "Activadas" : "Desactivadas")}\n";
            info += $"- Notificaciones Email: {(checkBox2.Checked ? "Sí" : "No")}\n";
            info += $"- Volumen: {numericUpDown1.Value}%";

            MessageBox.Show(info, "Ajustes Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
