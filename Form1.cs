using System;
using System.Text;
using System.Windows.Forms;

namespace EliseoSmuttEjer8
{
    public partial class Form1 : Form
    {
        private string[] valores = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        private string[] palos = { "Espada", "Basto", "Copas", "Oro" };
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder cartas = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                string carta = ObtenerCartaAleatoria();
                cartas.AppendLine(carta);
            }

            label1.Text = cartas.ToString();
        }
        private string ObtenerCartaAleatoria()
        {
            string valor = valores[random.Next(valores.Length)];
            string palo = palos[random.Next(palos.Length)];
            return valor + " de " + palo;
        }
    }
}
