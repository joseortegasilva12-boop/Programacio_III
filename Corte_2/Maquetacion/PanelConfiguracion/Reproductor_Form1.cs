namespace ReproductorMusica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar2.Value = 45;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 5; // Atrasa un poco la barra
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Play")
            {
                button2.Text = "Pause";
                // Aquí podrías iniciar un Timer para que la barra avance
            }
            else
            {
                button2.Text = "Play";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 5; // Adelanta un poco la barra
            }
        }

        // Agregamos estos métodos para evitar el error CS1061 
        // ya que están declarados en tu Form1.Designer.cs
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Por ahora vacío
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Por ahora vacío
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Por ahora vacío
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            // Por ahora vacío
        }
    }
}
