namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                lbl_resultado.Text = "Por favor, escribe una oraci�n.";
                return;
            }

            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            lbl_resultado.Text = $"N�mero de palabras: {palabras.Length}";
        }

        
    }
}
