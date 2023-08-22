using System;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Ejercicio2 divisionSimple = new Ejercicio2())
                divisionSimple.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Ejercicio3 ejercicio3 = new Ejercicio3())
                ejercicio3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Ejercicio1 ejercicio1 = new Ejercicio1())
                ejercicio1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Ejercicio4 ejercicio4 = new Ejercicio4())
                ejercicio4.ShowDialog();
        }
    }
}
