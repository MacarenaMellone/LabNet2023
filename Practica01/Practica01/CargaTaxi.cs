using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Practica01
{
    public partial class CargaTaxi : Form
    {
        public CargaTaxi()
        {
            InitializeComponent();
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textTaxi1.Clear();
            textTaxi2.Clear();
            textTaxi3.Clear();
            textTaxi4.Clear();
            textTaxi5.Clear();
            textTaxi1.Focus();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            switch (Validaciones())
            {
                case 0:
                    {
                        errorProvider1.Clear();
                        CargaTaxis();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(textError, "El campo no puede estar vacío");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(textError, "No se puede ingresar más de 4 pasajeros");
                        break;
                    }
                case 3:
                    {
                        errorProvider1.SetError(textError, "Ingresar sólo números positivos");
                        break;
                    }
                
            }
        }
        public int Validaciones()
        {
            if ((textTaxi1.Text.All(Char.IsNumber)) & (textTaxi2.Text.All(Char.IsNumber)) & (textTaxi3.Text.All(Char.IsNumber)) & (textTaxi4.Text.All(Char.IsNumber)) & (textTaxi5.Text.All(Char.IsNumber)))
            {
                if ((string.IsNullOrEmpty(textTaxi1.Text)) || (string.IsNullOrEmpty(textTaxi2.Text)) || (string.IsNullOrEmpty(textTaxi3.Text)) || (string.IsNullOrEmpty(textTaxi4.Text)) || (string.IsNullOrEmpty(textTaxi5.Text)))
                {
                    return 1;
                }
                else if((Convert.ToInt32(textTaxi1.Text) > 4) || (Convert.ToInt32(textTaxi2.Text) > 4) || (Convert.ToInt32(textTaxi3.Text) > 4) || (Convert.ToInt32(textTaxi4.Text) > 4) || (Convert.ToInt32(textTaxi5.Text) > 4))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 3;
            }
        }
        private void CargaTaxis()
        {
            int taxi1 = Convert.ToInt32(textTaxi1.Text);
            int taxi2 = Convert.ToInt32(textTaxi2.Text);
            int taxi3 = Convert.ToInt32(textTaxi3.Text);
            int taxi4 = Convert.ToInt32(textTaxi4.Text);
            int taxi5 = Convert.ToInt32(textTaxi5.Text);

            List<TransportePublico> ListaPasajerosOmnibus = new List<TransportePublico> {
                new Omnibus(taxi1, "Taxi 1"),
                new Omnibus(taxi2, "Taxi 2"),
                new Omnibus(taxi3, "Taxi 3"),
                new Omnibus(taxi4, "Taxi 4"),
                new Omnibus(taxi5, "Taxi 5")
            };

            foreach (var item in ListaPasajerosOmnibus)
            {
                string itemTex = item.Avanzar();
                string mensaje = $"{itemTex}";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Carga exitosa!", buttons);

            }
            textTaxi1.Clear();
            textTaxi2.Clear();
            textTaxi3.Clear();
            textTaxi4.Clear();
            textTaxi5.Clear();
            textTaxi1.Focus();
        }
    }
}
