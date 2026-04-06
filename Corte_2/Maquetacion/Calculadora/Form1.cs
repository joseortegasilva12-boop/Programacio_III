namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        string operacion = "";
        bool esNuevaOperacion = true;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.ReadOnly = true;
        }

        private void botonNumero_Click(object sender, EventArgs e)
        {
            if (esNuevaOperacion)
                textBox1.Clear();

            esNuevaOperacion = false;
            Button boton = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = boton.Text;
            else
                textBox1.Text += boton.Text;
        }

        private void botonOperador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            resultado = Double.Parse(textBox1.Text);
            esNuevaOperacion = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultado = 0;
            esNuevaOperacion = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double valorActual = Double.Parse(textBox1.Text);

            switch (operacion)
            {
                case "+": textBox1.Text = (resultado + valorActual).ToString(); break;
                case "-": textBox1.Text = (resultado - valorActual).ToString(); break;
                case "*": textBox1.Text = (resultado * valorActual).ToString(); break;
                case "/":
                    if (valorActual != 0)
                        textBox1.Text = (resultado / valorActual).ToString();
                    else
                        MessageBox.Show("No se puede dividir por cero");
                    break;
            }
            esNuevaOperacion = true;
        }
    }
}
