using Practica04.Linq.Entities;
using Practica04.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Practica4.Linq.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelEjer.Text = "BIENVENIDO";
            label1.Text = "SELECCIONE UN EJERCICIO";
        }

        private static CustomersLogic customersLogic = new CustomersLogic();
        private static ProductsLogic productsLogic = new ProductsLogic();
        private static CategoriesLogic categoriesLogic = new CategoriesLogic();

        private void btnEjer1_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 1";
            labelSub.Text = "Query para devolver objeto customer.";
            label6.Text = "ID  -   COMPAÑÍA  -  CIUDAD  -  PAÍS";

            Customers customers = customersLogic.CustomerObjects("Sweden");
            label4.Text = $"{customers.CustomerID} - {customers.CompanyName} -  {customers.City} - {customers.Country}";
        }
        private void btnEjer2_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 2";
            labelSub.Text = "Query para devolver todos los productos sin stock.";
            label6.Text = "STOCK  - PRODUCTO";

            IEnumerable<Products> products = productsLogic.ProductsStock();
            foreach (var p in products){
                label4.Text += $"{p.UnitsInStock} - {p.ProductName} \n";
            }
        }
        private void btnEjer3_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 3";
            labelSub.Text = "Query para devolver todos los productos\nque tienen stock y que cuestan más de 3 por unidad.";       
            label6.Text = "PRODUCTO  -  STOCK  -  PRECIO";

            List<Products> products = productsLogic.ProductsStockPrice();
            foreach (var p in products){
                label4.Text += $"{p.ProductName} - {p.UnitsInStock} - {p.UnitPrice}\n";
            }
        }
        private void btnEjer4_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 4";
            labelSub.Text = "Query para devolver todos los customers de la Región WA.";
            label6.Text = "ID CLIENTE  -  REGIÓN";

            List<Customers> customers = customersLogic.CustomerRegion();
            foreach (var c in customers){
                label4.Text += $"{c.CustomerID} - {c.Region} \n";
            }
        }
        private void btnEjer5_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 5";
            labelSub.Text = "Query para devolver el primer elemento\no nulo de una lista de productos donde el ID de producto sea igual a 789.";
            label6.Text = "ID  -  PRODUCTO";

            Products p = productsLogic.FirstOrNullProducts();
            if (p != null){
                label4.Text = $"{p.ProductID} - {p.ProductName}";
            }
            else{
                label4.Text = "No existe producto con ID: 789";
            }
        }
        private void btnEjer6_Click(object sender, EventArgs e)
        {
            ResetLabels(); 
            labelEjer.Text = "EJERCICIO 6";
            labelSub.Text = "Query para devolver los nombre de los Customers.\nMostrarlos en Mayúscula y en Minúscula.";
            label6.Text = "MAYÚSCULA  -  MINÚSCULA";

            List<Customers> customers = customersLogic.CustomersNombre();
            foreach (var c in customers){
                label4.Text += $"{c.ContactName.ToUpper()} - {c.ContactName.ToLower()} \n";
            }
        }
        private void btnEjer7_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 7";
            labelSub.Text = "Query para devolver Join entre Customers y Orders\ndónde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.";
            label6.Text = "CLIENTE  -  ORDEN  -  COMPAÑÍA  -  REGIÓN  -  ORDEN  -  FECHA DE ORDEN";

            var tuple = customersLogic.CustomerOrder();
            foreach (var c in tuple){
                label4.Text += $"{c.Item1.CustomerID} - {c.Item1.CompanyName} - {c.Item1.Region} - {c.Item2.OrderID} - {c.Item2.OrderDate} \n";
            }
        }
        private void btnEjer8_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 8";
            labelSub.Text = "Query para devolver los primeros 3 Customers de la  Región WA.";
            label6.Text = "ID  -  CLIENTE  -  REGIÓN";

            IEnumerable<Customers> customers = customersLogic.CustomerRegion3();
            foreach (var c in customers){
                label4.Text += $"{c.CustomerID} - {c.CompanyName} - {c.Region} \n";
            }
        }
        private void btnEjer9_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 9";
            labelSub.Text = "Query para devolver lista de productos ordenados por nombre.";
            label6.Text = "PRODUCTO";

            List<Products> products = productsLogic.ProductsList();
            foreach (var p in products){
                label4.Text += $"{p.ProductName} \n";
            }
        }
        private void btnEjer10_Click(object sender, EventArgs e)
        {
            ResetLabels();  
            labelEjer.Text = "EJERCICIO 10";
            labelSub.Text = "Query para devolver lista de productos ordenados por UnitInStock de mayor a menor.";
            label6.Text = "STOCK  -  PRODUCTO";

            List<Products> products = productsLogic.ProductsListStock();
            foreach (var p in products){
                label4.Text += $"{p.UnitsInStock} - {p.ProductName} \n";
            }
        }
        private void btnEjer11_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 11";
            labelSub.Text = "Query para devolver las distintas categorías asociadas a los productos.";
            label6.Text = "ID  -  CATEGORÍA";

            List<Categories> categories = categoriesLogic.CategoriesProducts();
            IEnumerable<Categories> noDuplicadas = categories.Distinct();
            foreach (var c in noDuplicadas){
                label4.Text += $"{c.CategoryID} - {c.CategoryName} \n";
            }
        }
        private void btnEjer12_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 12";
            labelSub.Text = "Query para devolver el primer elemento de una lista de productos.";
            label6.Text = "ID  -  PRODUCTO";

            Products p = productsLogic.FirstProduct();
            label4.Text = $"{p.ProductID} - {p.ProductName}";
        }
        private void btnEjer13_Click(object sender, EventArgs e)
        {
            ResetLabels();
            labelEjer.Text = "EJERCICIO 13";
            labelSub.Text = "Query para devolver los customer con la cantidad de ordenes asociadas.";
            label6.Text = "ÓRDENES ASOCIADAS  -  ID  -  CLIENTE";

            var tuple = customersLogic.CustomerOrdersA();
            foreach (var c in tuple){
                label4.Text += $"{c.Item2} - {c.Item1.CustomerID} - {c.Item1.CompanyName} \n";
            }
        }
        private void ResetLabels()
        {
            labelEjer.ResetText();
            labelSub.ResetText();
            label1.ResetText();
            label2.ResetText();
            label4.ResetText();
            label6.ResetText();
        }
    }
}
