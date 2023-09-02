using Practica3.EF.Entities;
using Practica3.EF.Logic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Practica3
{
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            label1.ResetText();
            foreach (var item in categoriesLogic.GetAll())
            {
                label1.Text += $"{item.CategoryID} - {item.CategoryName} - {item.Description} \n";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            switch (ValidacionesAgregar())
            {
                case 0:
                    {
                        AgregarCtg();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtError, "El campo Categoría no debe estar vacío");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtError, "El campo ID debe estar vacío");
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
                        ModificarCtg();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtError, "El campo ID no debe estar vacío o contener letras.");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtError, "El campo Categoría no debe estar vacío.");
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
                        EliminarCtg();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtError, "El campo ID no debe estar vacío o contener letras.");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtError, "Los campos Categóría y/o Descripción deben estar vacíos");
                        break;
                    }
            }
        }
        public int ValidacionesAgregar()
        {
            if (!string.IsNullOrEmpty(txtIdCat.Text))
            {
                return 2;
            }
            else if (string.IsNullOrEmpty(txtCat.Text))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int ValidacionModificar()
        {

            if ((string.IsNullOrEmpty(txtIdCat.Text)) || (!txtIdCat.Text.All(Char.IsNumber)))
            {
                return 1;
            }
            else if ((string.IsNullOrEmpty(txtCat.Text)))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public int ValidacionesEliminar()
        {
            if ((string.IsNullOrEmpty(txtIdCat.Text)) || (!txtIdCat.Text.All(Char.IsNumber)))
            {
                return 1;
            }
            else if ((!string.IsNullOrEmpty(txtCat.Text)) || (!string.IsNullOrEmpty(txtDesc.Text)))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private void EliminarCtg()
        {
            try
            {
                errorProvider1.Clear();
                CategoriesLogic categoriesLogic = new CategoriesLogic();
                int valor1;
                valor1 = Convert.ToInt32(txtIdCat.Text);
                categoriesLogic.Delete(valor1);

                label1.ResetText();
                foreach (var item in categoriesLogic.GetAll())
                {
                    label1.Text += $"{item.CategoryID} - {item.CategoryName} - {item.Description} \n";
                }
                
                txtIdCat.Clear();
                txtCat.Clear();
                txtDesc.Clear();
            }
            catch (Exception)
            {
                ExceptionsLogic.CustomExceptionEliminar();
            }
        }
        private void ModificarCtg()
        {
            errorProvider1.Clear();
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            int valor1;
            valor1 = Convert.ToInt32(txtIdCat.Text);
            string valor2;
            valor2 = txtCat.Text;
            string valor3;
            valor3 = txtDesc.Text;

            categoriesLogic.Update(new Categories
            {
                CategoryID = valor1,
                CategoryName = valor2,
                Description = valor3
            });

            label1.ResetText();
            foreach (var item in categoriesLogic.GetAll())
            {
                label1.Text += $"{item.CategoryID} - {item.CategoryName} - {item.Description} \n";
            }
            txtIdCat.Clear();
            txtCat.Clear();
            txtDesc.Clear();
        }
        private void AgregarCtg()
        {
            errorProvider1.Clear();
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            string valor1;
            valor1 = txtCat.Text;
            string valor2;
            valor2 = txtDesc.Text;

            categoriesLogic.Add(new Categories
            {
                CategoryName = valor1,
                Description = valor2
            });

            label1.ResetText();
            foreach (var item in categoriesLogic.GetAll())
            {
                label1.Text += $"{item.CategoryID}  -  {item.CategoryName} - {item.Description} \n";
            }
            txtCat.Clear();
            txtDesc.Clear();
        }
    }
}
