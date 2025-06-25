using System.Drawing;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ConvertirLongitud(double valor, string unidadOrigen, string unidadDestino)
        {
            switch (unidadOrigen.ToLower())
            {
                case "pulgadas":
                    switch (unidadDestino.ToLower())
                    {
                        case "centimetros":
                            return valor * 2.54;
                        case "metros":
                            return valor * 0.0254;
                        default:
                            return valor;
                    }

                case "centimetros":
                    switch (unidadDestino.ToLower())
                    {
                        case "pulgadas":
                            return valor * 0.3937;
                        case "metros":
                            return valor * 0.01;
                        default:
                            return valor;
                    }

                case "metros":
                    switch (unidadDestino.ToLower())
                    {
                        case "centimetros":
                            return valor * 100;
                        case "pulgadas":
                            return valor * 39.3701;
                        default:
                            return valor;
                    }

                default:
                    throw new ArgumentException("Unidad no reconocida.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double accion = ConvertirLongitud(double.Parse(textEntrada.Text), comboEntrada.SelectedItem.ToString(),comboSalida.SelectedItem.ToString());
            lbl_resultado.Text = accion.ToString();
            lbl_unidad.Text = comboSalida.SelectedItem.ToString();
        }

       
    }
}
