using System;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mayorMenor_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = Convert.ToInt32(mayor.Text);
                int valor2 = Convert.ToInt32(menor.Text);
                Logic.MayorMenor(valor1, valor2, true);
                mayor.Clear();
                menor.Clear();
                mayor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
