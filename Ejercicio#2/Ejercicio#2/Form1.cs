namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tiemporestante;
        private void button1_Click(object sender, EventArgs e)
        {
            int minutos = Convert.ToInt32(textMIN.Text);
            int segundos = Convert.ToInt32(textSEG.Text);
            tiemporestante = (minutos * 60) + segundos;

            labREST.Text = $"{minutos:D2}:{segundos:D2}";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiemporestante > 0)
            {
                tiemporestante--;
                int min = tiemporestante / 60;
                int seg = tiemporestante % 60;
                labREST.Text = $"{min:D2}:{seg:D2}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo agotado!");
            }
        }
    }
}
