namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(entrada) )
            {
                MessageBox.Show("Ingresa una palabra, no puede estar en blanco.", "Atencion");            
            }
            string invertida = new string(entrada.Reverse().ToArray());

            if (entrada == invertida)
                MessageBox.Show("¡Es una palabra palíndroma!", "Resultado");
            else
                MessageBox.Show("No es una palabra palíndroma.", "Resultado");
        }
    }
}
