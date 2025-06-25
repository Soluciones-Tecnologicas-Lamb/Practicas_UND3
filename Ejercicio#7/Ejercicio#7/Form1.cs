namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 

            if (int.TryParse(textBox1.Text, out int inicio) &&
                int.TryParse(textBox2.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El valor de inicio debe ser menor o igual al de fin.");
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                {
                    if (EsPrimo(i))
                        listBox1.Items.Add(i);
                }

                if (listBox1.Items.Count == 0)
                    listBox1.Items.Add("No hay primos en ese rango.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores num�ricos v�lidos.", "Entrada inv�lida");
            }
        }

    }
}
