using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxProblem;

namespace SalesTaxProblemTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCalculateTax_Book_Imported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("book", 10, 3, GoodsType.Book, true);
            decimal expectedTax = 1.5m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Book_NotImported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("book", 10, 3, GoodsType.Book, false);
            decimal expectedTax = 0m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Food_Imported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("Pizza", 250, 1, GoodsType.Food, true);
            decimal expectedTax = 12.5m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Food_NotImported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("Shahi paneer", 250, 1, GoodsType.Food, false);
            decimal expectedTax = 0m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Medical_Imported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("Tab xyz", 2500, 1, GoodsType.Medical, true);
            decimal expectedTax = 125m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Medical_NotImported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("Tab Moov", 300, 1, GoodsType.Medical, false);
            decimal expectedTax = 0m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Other_Imported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("Car", 76547380, 1, GoodsType.Other, true);
            decimal expectedTax = 11482107M;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }

        [TestMethod]
        public void TestCalculateTax_Other_NotImported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("Tyre", 5000, 1, GoodsType.Other, false);
            decimal expectedTax = 500m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }
    }
}
