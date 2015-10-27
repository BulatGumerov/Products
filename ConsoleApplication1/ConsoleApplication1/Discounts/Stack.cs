using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Discounts
{
    public static class Stack
    {
        public static void Check(List<Product> products, double discount)
        {
            var flag = Contain(products);
            while (flag)
            {
                Calculate(products, discount);
                flag = Contain(products);
            }
        }

        static bool Contain(List<Product> products)
        {
            foreach(var product in products)
            {
                if(!Entities.Row.LP.Contains(product))
                {
                    return false;
                }
            }
            return true;
        }

        static void Calculate(List<Product> products, double discount)
        {
            Entities.Row.DeleteProducts(products);
            Entities.TotalSum.Sum += products.Sum(a => a.GetCost()) * discount;
        }
    }
}
