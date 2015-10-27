using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Discounts
{
    public static class OneWithMany
    {
        //public static double? Check(Product main, List<Product> products)
        //{
        //    var flag = true;
        //    if (Entities.Row.LP.Contains(main))
        //    {
        //        foreach (var product in products)
        //        {
        //            if (!Entities.Row.LP.Contains(product))
        //            {
        //                flag = false;
        //                break;
        //            }
        //        }
        //        if(flag)
        //        {
        //            var sum = products.Sum(a => a.GetCost());
        //            sum += main.GetCost();
        //            Entities.Row.DeleleProducts(products);
        //            Entities.Row.DeleteProduct(main);
        //            return sum * 0.95;
        //        }
        //    }
        //    return null;
        //}

        public static void Check(Product main, List<Product> products)
        {
            var flag = Contain(main, products);
            while (flag)
            {
                Calculate(first, second, third);
                flag = Contain(main, products);
            }
        }

        static bool Contain(Product target, List<Product> products)
        {
            if(!Entities.Row.LP.Contains(target))
            {
                return false;
            }
            else
            {
                foreach(var product in products)
                {
                    if(!Entities.Row.LP.Contains(product))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Calculate(Product main, List<Product> products)
        {
            Entities.Row.DeleteProduct(main);
            Entities.Row.DeleteProducts(products);
            var pro
            Entities.TotalSum.Sum += products.Sum(a => a.GetCost());
        }
    }
}
