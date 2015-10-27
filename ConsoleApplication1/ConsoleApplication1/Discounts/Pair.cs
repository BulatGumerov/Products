using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Discounts
{
    public static class Pair90
    {
        public static void Check(Product first, Product second)
        {
            var flag = Contain(first, second);
            while (flag)
            {
                Calculate(first, second);
                flag = Contain(first, second);
            }
        }

        static bool Contain(Product first, Product second)
        {
            return (Entities.Row.LP.Contains(first) && Entities.Row.LP.Contains(second));
        }

        static void Calculate(Product first, Product second)
        {
            Entities.Row.DeleteProduct(first);
            Entities.Row.DeleteProduct(second);
            Entities.TotalSum.Sum += (first.GetCost() + second.GetCost()) * 0.9;
        }

    }

    public static class Pair95
    {
        public static void Check(Product first, Product second)
        {
            var flag = Contain(first, second);
            while (flag)
            {
                Calculate(first, second);
                flag = Contain(first, second);
            }
        }

        static bool Contain(Product first, Product second)
        {
            return (Entities.Row.LP.Contains(first) && Entities.Row.LP.Contains(second));
        }

        static void Calculate(Product first, Product second)
        {
            Entities.Row.DeleteProduct(first);
            Entities.Row.DeleteProduct(second);
            Entities.TotalSum.Sum += (first.GetCost() + second.GetCost()) * 0.95;
        }
    }
}
