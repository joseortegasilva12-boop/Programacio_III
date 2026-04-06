namespace Cuenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string genero = "";
            if (radioButton1.Checked) genero = "Masculino";
            else if (radioButton2.Checked) genero = "Femenino";
            else if (radioButton3.Checked) genero = "Otro";

            MessageBox.Show($"Perfil de {textBox1.Text} guardado con éxito.");
            MessageBox.Show($"¡Cambios guardados con éxito!\nUsuario: {textBox1.Text} {textBox2.Text}\nGénero: {genero}",
                            "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
