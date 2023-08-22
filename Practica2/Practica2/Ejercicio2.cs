using System;
using System.Linq;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio2 : Form
    {

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            resultado1.Text = "";
        }

        private void btndividir1_Click(object sender, EventArgs e)
        {

            Dividir();
        }

        private void Dividir()
        {
            ExceptionMat dividir = new ExceptionMat();
            try
            {
                if (divisor.Text.ToString() == "0")
                {
                    int a = Convert.ToInt32(dividendo.Text);
                    int b = Convert.ToInt32(divisor.Text);
                    dividir.SimpleException(a, b);
                    divisor.Clear();

                }
                else if (divisor.Text.All(Char.IsNumber))
                {
                    int a = Convert.ToInt32(dividendo.Text);
                    int b = Convert.ToInt32(divisor.Text);
                    int c = a / b;
                    resultado1.Text = c.ToString();
                }
                else{
                    ExceptionMat.DivisionException();   
                }

            }
            catch (Exception)
            {
                MessageBox.Show("¡Seguro Ingreso una letra o no ingreso nada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
