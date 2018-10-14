using System;

namespace SalesTaxProblem
{
    public interface IProductFactory
    {
        Product GetProduct(string Name, decimal price, int quantity, GoodsType goodsType, bool isImported);
    }

    public class ProductFactory : IProductFactory
    {
        public Product GetProduct(string name, decimal price, int quantity, GoodsType goodsType, bool isImported)
        {
            switch (goodsType)
            {
                case GoodsType.Book:
                    return new Book(name, isImported, price, quantity);

                case GoodsType.Food:
                    return new Food(name, isImported, price, quantity);

                case GoodsType.Medical:
                    return new Medical(name, isImported, price, quantity);

                case GoodsType.Other:
                    return new Others(name, isImported, price, quantity);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
