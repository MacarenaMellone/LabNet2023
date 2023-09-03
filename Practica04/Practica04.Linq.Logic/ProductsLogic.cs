using Practica04.Linq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica04.Linq.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
        //Ejer.2
        public IEnumerable<Products> ProductsStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0);
            return query.ToList();
        }
        //Ejer.3
        public List<Products> ProductsStockPrice()
        {
            var query = from p in context.Products
                        where p.UnitsInStock > 0 && p.UnitPrice > 3
                        orderby p.UnitsInStock
                        select p;
            return query.ToList();
        }
        //Ejer.5
        public Products FirstOrNullProducts()
        {
            var query = context.Products.Where(p => p.ProductID == 789);
            return query.FirstOrDefault();
        }
        //Ejer.9
        public List <Products> ProductsList()
        {
            var query = from p in context.Products
                        orderby p.ProductName ascending
                        select p;
            return query.ToList();
        }
        //Ejer.10
        public List<Products> ProductsListStock()
        {
            var query = from p in context.Products
                        orderby p.UnitsInStock descending
                        select p;
            return query.ToList();
        }
        //Ejer.12
        public Products FirstProduct()
        {
            var query = from p in context.Products
                        select p;
            return query.First();
        }
    }
}
