using System;


namespace Practica01
{
    public partial class Inicio : System.Windows.Forms.Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (Carga cargaTaxiOmnibus = new Carga())
                cargaTaxiOmnibus.ShowDialog();
        }
    }
}
