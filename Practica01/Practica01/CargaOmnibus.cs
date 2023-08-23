using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace Practica01
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textOmnibus1.Clear();
            textOmnibus2.Clear();
            textOmnibus3.Clear();
            textOmnibus4.Clear();
            textOmnibus5.Clear();
            textOmnibus1.Focus();
        }
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            switch (Validaciones())
            {
                case 0:
                    {
                        errorProvider1.Clear();
                        CargaOmnibus();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(textError, "El campo no puede estar vacío");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(textError, "No se puede ingresar más de 75 pasajeros");
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
            if ((textOmnibus1.Text.All(Char.IsNumber)) & (textOmnibus2.Text.All(Char.IsNumber)) & (textOmnibus3.Text.All(Char.IsNumber)) & (textOmnibus4.Text.All(Char.IsNumber)) & (textOmnibus5.Text.All(Char.IsNumber))) {
                if ((string.IsNullOrEmpty(textOmnibus1.Text)) || (string.IsNullOrEmpty(textOmnibus2.Text)) || (string.IsNullOrEmpty(textOmnibus3.Text)) || (string.IsNullOrEmpty(textOmnibus4.Text)) || (string.IsNullOrEmpty(textOmnibus5.Text)))
                {
                    return 1;
                }
                else if ((Convert.ToInt32(textOmnibus1.Text) > 75) || (Convert.ToInt32(textOmnibus2.Text) > 75) || (Convert.ToInt32(textOmnibus3.Text) > 75) || (Convert.ToInt32(textOmnibus4.Text) > 75) || (Convert.ToInt32(textOmnibus5.Text) > 75))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            else{
                return 3;
            }
        }

        private void CargaOmnibus()
        {

            int Omnibus1 = Convert.ToInt32(textOmnibus1.Text);
            int Omnibus2 = Convert.ToInt32(textOmnibus2.Text);
            int Omnibus3 = Convert.ToInt32(textOmnibus3.Text);
            int Omnibus4 = Convert.ToInt32(textOmnibus4.Text);
            int Omnibus5 = Convert.ToInt32(textOmnibus5.Text);

            List<TransportePublico> ListaPasajerosOmnibus = new List<TransportePublico> {
                new Omnibus(Omnibus1, "Omnibus 1"),
                new Omnibus(Omnibus2, "Omnibus 2"),
                new Omnibus(Omnibus3, "Omnibus 3"),
                new Omnibus(Omnibus4, "Omnibus 4"),
                new Omnibus(Omnibus5, "Omnibus 5")
            };
            
            foreach (var item in ListaPasajerosOmnibus)
            {
                string itemTex = item.Avanzar();
                string mensaje = $"{itemTex}";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Carga exitosa!", buttons);

            }
            textOmnibus1.Clear();
            textOmnibus2.Clear();
            textOmnibus3.Clear();
            textOmnibus4.Clear();
            textOmnibus5.Clear();
            textOmnibus1.Focus();
        }
    }
}
