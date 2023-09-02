using Practica3.EF.Entities;
using Practica3.EF.Logic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Practica3
{
    public partial class FormShippers : Form
    {
        public FormShippers()
        {
            InitializeComponent();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            label1.ResetText();
            foreach (var item in shippersLogic.GetAll())
            {
                label1.Text += $"{item.ShipperID} - {item.CompanyName} - {item.Phone} \n";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            switch (ValidacionesAgregar())
            {
                case 0:
                    {
                        AgregarShipper();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtError, "El campo Compañia no debe estar vacío");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtError, "El campo ID debe estar vacío");
                        break;
                    }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            switch (ValidacionesEliminar())
            {
                case 0:
                    {
                        EliminarShipper();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtError, "El campo ID no debe estar vacío o contener letras.");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtError, "Los campos Compañía y/o Teléfono deben estar vacíos");
                        break;
                    }
            }
            
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            switch (ValidacionModificar())
            {
                case 0:
                    {
                        ModificacionShipper();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtError, "El campo ID no debe estar vacío o contener letras.");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtError, "El campo Companía no debe estar vacío.");
                        break;
                    }
            }

        }   
        public int ValidacionesAgregar()
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                return 2;
            }
            else if(string.IsNullOrEmpty(txtComp.Text))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int ValidacionesEliminar()
        {
            if ((string.IsNullOrEmpty(txtId.Text)) || (!txtId.Text.All(Char.IsNumber)))
            {
                return 1;
            }
            else if((!string.IsNullOrEmpty(txtComp.Text)) || (!string.IsNullOrEmpty(txtTel.Text)))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public int ValidacionModificar()
        {
            
            if ((string.IsNullOrEmpty(txtId.Text)) || (!txtId.Text.All(Char.IsNumber)))
            {
                return 1;
            }
            else if ((string.IsNullOrEmpty(txtComp.Text)))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private void AgregarShipper()
        {
            errorProvider1.Clear();
            ShippersLogic shippersLogic = new ShippersLogic();
            string valor1;
            valor1 = txtComp.Text;
            string valor2;
            valor2 = txtTel.Text;

            shippersLogic.Add(new Shippers
            {
                CompanyName = valor1,
                Phone = valor2
            });

            label1.ResetText();
            foreach (var item in shippersLogic.GetAll())
            {
                label1.Text += $"{item.ShipperID} - {item.CompanyName} - {item.Phone} \n";
            }
            txtId.Clear();
            txtComp.Clear();
            txtTel.Clear();
        }
        private void ModificacionShipper()
        {
            errorProvider1.Clear();
            ShippersLogic shippersLogic = new ShippersLogic();
            int valor1;
            valor1 = Convert.ToInt32(txtId.Text);
            string valor2;
            valor2 = txtComp.Text;
            string valor3;
            valor3 = txtTel.Text;

            shippersLogic.Update(new Shippers
            {
               ShipperID = valor1,
               CompanyName = valor2,
               Phone = valor3
            });

            label1.ResetText();
            foreach (var item in shippersLogic.GetAll())
            {
               label1.Text += $"{item.ShipperID} - {item.CompanyName} - {item.Phone}  \n";
            }
            txtId.Clear();
            txtComp.Clear();
            txtTel.Clear();
        }
        private void EliminarShipper()
        {
            errorProvider1.Clear();
            ShippersLogic shippersLogic = new ShippersLogic();
            int valor1;
            valor1 = Convert.ToInt32(txtId.Text);

            shippersLogic.Delete(valor1);

            label1.ResetText();
            foreach (var item in shippersLogic.GetAll())
            {
                label1.Text += $"{item.ShipperID} - {item.CompanyName} - {item.Phone}  \n";
            }
            txtId.Clear();
            txtComp.Clear();
            txtTel.Clear();
        }
    }
}
