namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                if (EsPrimo(numero))
                    MessageBox.Show($"{numero} es un número primo.", "Resultado");
                else
                    MessageBox.Show($"{numero} no es un número primo.", "Resultado");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Entrada inválida");
            }
        }
    }
}
