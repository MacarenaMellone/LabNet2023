using System;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnShippers_Click(object sender, EventArgs e)
        {
            using (FormShippers formShippers = new FormShippers())
            formShippers.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            using (FormCategories formCategorias = new FormCategories())
            formCategorias.ShowDialog();
        }
    }
}
