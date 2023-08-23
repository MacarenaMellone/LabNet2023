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

        private void btnCargarOmnibus_Click(object sender, EventArgs e)
        {
            using (Carga cargaOmnibus = new Carga())
                cargaOmnibus.ShowDialog();
        }

        private void btnCargaTaxi_Click(object sender, EventArgs e)
        {
            using (CargaTaxi cargaOmnibus = new CargaTaxi())
                cargaOmnibus.ShowDialog();
        }
    }
}
