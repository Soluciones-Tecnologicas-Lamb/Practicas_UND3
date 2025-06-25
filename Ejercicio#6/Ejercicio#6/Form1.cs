namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if (numero <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un n�mero entero positivo.", "Entrada inv�lida");
                    return;
                }

                int suma = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                        suma += i;
                }

                if (suma == numero)
                    MessageBox.Show($"{numero} es un n�mero perfecto.", "Resultado");
                else
                    MessageBox.Show($"{numero} no es un n�mero perfecto.", "Resultado");
            }
            else
            {
                MessageBox.Show("Entrada no v�lida. Aseg�rate de ingresar solo n�meros.", "Error");
            }
        }
    }
}
