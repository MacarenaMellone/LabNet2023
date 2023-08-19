using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
                        if (textTaxi.Text.ToString() == "") 
                        {
                            cargaOmnibus();
                            break;
                        }
                        else 
                        {
                            cargaTaxis();
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
            if ((textOmnibus.Text.All(Char.IsNumber)) & (textTaxi.Text.All(Char.IsNumber))) {
                if ((string.IsNullOrEmpty(textOmnibus.Text)) & (string.IsNullOrEmpty(textTaxi.Text))){
                    return 1;
                }
                else { 
                    return 0; }
            }
            else{
                return 2;
            }
        }

        private void cargaOmnibus()
        {
            Omnibus pasajerosO = new Omnibus();
            pasajerosO.Cantidad = Convert.ToInt32(textOmnibus.Text);
            ListaPasajerosOmnibus.Add(pasajerosO);

            listView1.Items.Clear();
            int loop = 0;
            foreach (Omnibus omnibus in ListaPasajerosOmnibus)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(omnibus.Cantidad.ToString());
                loop++;

                if (loop == 5)
                {
                    string mensaje = "Ómnibus disponibles cargados.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje, "Carga exitosa!", buttons);
                    break;
                }

            }

            textOmnibus.Clear();
            textOmnibus.Focus();
        }

        private void cargaTaxis()
        {
            if (Convert.ToInt32(textTaxi.Text) <= 4)
            {
                Taxi pasajerosT = new Taxi();
                pasajerosT.Cantidad = Convert.ToInt32(textTaxi.Text);
                ListaPasajerosTaxi.Add(pasajerosT);

                listView2.Items.Clear();
                int loop = 0;
                foreach (Taxi taxi in ListaPasajerosTaxi)
                {

                    ListViewItem item = new ListViewItem();
                    item = listView2.Items.Add(taxi.Cantidad.ToString());
                    loop++;

                    if (loop == 5)
                    {
                        string mensaje = "Taxis disponibles cargados.";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Carga exitosa!", buttons);
                        break;
                    }
                }
                textTaxi.Clear();
                textTaxi.Focus();
            }
            else {
                errorProvider1.SetError(textError, "No pueden viajar más de 4 pasajeros en un taxi");
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            textOmnibus.Focus();
        }
    }
}
