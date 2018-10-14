using System;

namespace SalesTaxProblem
{
    public enum GoodsType
    {
        Book = 1,
        Food = 2,
        Medical = 3,
        Other = 4
    }

    public abstract class Product
    {
        public string Name { get; set; }

        public bool IsImported { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int Type { get; }

        public Product(string name, bool isImported, decimal price, int quantity)
        {
            Name = name;
            IsImported = isImported;
            Price = price;
            Quantity = quantity;
        }

        public virtual decimal CalculateTax()
        {
            decimal tax = 0;

            if (IsImported == true)
            {
                tax = Convert.ToDecimal(Convert.ToDouble(Price * Quantity) * 0.05);
            }

            return tax;
        }
    }

    public class Book : Product
    {
        public Book(string name, bool isImported, decimal price, int quantity)
            : base(name, isImported, price, quantity)
        {
        }
    }

    public class Medical : Product
    {
        public Medical(string name, bool isImported, decimal price, int quantity)
            : base(name, isImported, price, quantity)
        {
        }
    }

    public class Food : Product
    {
        public Food(string name, bool isImported, decimal price, int quantity)
            : base(name, isImported, price, quantity)
        {
        }
    }

    public class Others : Product
    {
        public Others(string name, bool isImported, decimal price, int quantity)
            : base(name, isImported, price, quantity)
        {
        }

        public override decimal CalculateTax()
        {
            decimal importedTax = 0;

            if (IsImported == true)
            {
                importedTax = Convert.ToDecimal(Convert.ToDouble(Price * Quantity) * 0.05);
            }

            var salesTax = Convert.ToDecimal(Convert.ToDouble(Price * Quantity) * 0.1);

            return importedTax + salesTax;
        }
    }
}
