using System;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndividir0_Click(object sender, EventArgs e)
        {
            divicionCero();    
        }

        public void divicionCero()
        {
            try
            {
                int a = Convert.ToInt32(dividendo.Text);
                int b = Convert.ToInt32(cero.Text);
                int division = a / b;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                MessageBox.Show("El ejercicio ha finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dividendo.Clear();
                dividendo.Focus();
            }
        }
    }
}
