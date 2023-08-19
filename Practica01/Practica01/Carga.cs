using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica01
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textTaxi1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textOmnibus1_TextChanged(object sender, EventArgs e)
        {

        }
        List<Omnibus> ListaPasajerosOmnibus = new List<Omnibus>();
        List<Taxi> ListaPasajerosTaxi = new List<Taxi>();
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        if (textTaxi1.Text.ToString() == "") 
                        {
                            Omnibus pasajerosO = new Omnibus();
                            pasajerosO.Cantidad = Convert.ToInt32(textOmnibus1.Text);
                            ListaPasajerosOmnibus.Add(pasajerosO);

                            listView1.Items.Clear();
                            foreach (Omnibus omnibus in ListaPasajerosOmnibus)
                            {
                                ListViewItem item = new ListViewItem();
                                item = listView1.Items.Add(omnibus.Cantidad.ToString());

                            }
                            textOmnibus1.Clear();
                            textOmnibus1.Focus();
                            break;
                        }
                        else 
                        {
                            Taxi pasajerosT = new Taxi();
                            pasajerosT.Cantidad = Convert.ToInt32(textTaxi1.Text);
                            ListaPasajerosTaxi.Add(pasajerosT);

                            listView2.Items.Clear();
                            foreach (Taxi taxi in ListaPasajerosTaxi)
                            {
                                ListViewItem item = new ListViewItem();
                                item = listView2.Items.Add(taxi.Cantidad.ToString());

                            }
                            textTaxi1.Clear();
                            textTaxi1.Focus();
                            break;
                        }
                    }
                case 1:
                    {
                        errorProvider1.SetError(textError, "El campo no puede estar vacío");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(textError, "Ingresar sólo números positivos");
                        break;
                    }

            }

        }

        public int validaciones()
        {
            if ((textOmnibus1.Text.All(Char.IsNumber)) & (textTaxi1.Text.All(Char.IsNumber))) {
                if ((string.IsNullOrEmpty(textOmnibus1.Text)) & (string.IsNullOrEmpty(textTaxi1.Text))){
                    return 1;
                }
                else {
                    return 0; 
                }   
            }
            else{
                return 2;
            }
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
    }
}
