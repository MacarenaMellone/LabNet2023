using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica3.EF.Logic;
using Moq;
using System.Collections.Generic;
using Practica3.EF.Entities;
using System.Data.Entity;
using Practica3.EF.Data;

namespace Practica3.EF.Logic.Tests
{
    [TestClass()]
    public class CategoriesLogicTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var mockSet = new Mock<DbSet<Categories>>();

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            CategoriesLogic categoriesLogic = new CategoriesLogic(mockContext.Object);

            categoriesLogic.Add(new Categories
            {
                CategoryID = 12,
                CategoryName = "Test",
                Description = "DescriptionTest"
            });

            mockSet.Verify(m => m.Add(It.IsAny<Categories>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());



        }
    }
}