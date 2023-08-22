using System;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mayorMenor_Click(object sender, EventArgs e)
        {
            Logic.CustomException();
            mayor.Clear();
            menor.Clear();
            mayor.Focus();
        }
    }
}
