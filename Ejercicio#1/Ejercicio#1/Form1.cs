using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 1;
            int multi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            while (contador <= 12) 
            {
                listBox1.Items.Add($"{multi} x {contador} = {multi * contador}");
                contador++;
            }
        }
    }
}
