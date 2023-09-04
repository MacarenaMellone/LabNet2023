using Practica04.Linq.Entities;
using Practica04.Linq.Logic;
using System;
using System.Windows.Forms;

namespace Practica4.Linq.UI
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
            labelEjer.Text = "EJERCICIO 1";
            labelSub.Text = "Query para devolver objeto customer."; 
        }
        private void btnEjec_Click(object sender, EventArgs e)
        {
            CustomersLogic customersLogic = new CustomersLogic();
            string valor1;
            valor1 = textClte.Text;

            Customers customers = customersLogic.CustomerObjects(valor1);
            if (customers != null)
            {
                label6.Text = "ID  -   COMPAÑÍA  -  CIUDAD  -  PAÍS";
                label4.Text = $"{customers.CustomerID} - {customers.CompanyName} -  {customers.City} - {customers.Country}";
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
