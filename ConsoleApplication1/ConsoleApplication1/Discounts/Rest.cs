using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Discounts
{
    public static class Rest
    {
        public static void Check()
        {
            var flag = Contain();
            while (flag)
            {
                Calculate();
                flag = Contain();
            }
        }

        static bool Contain()
        {
            return Entities.Row.LP.Count > 0;
        }

        static void Calculate()
        {
            var product = Entities.Row.LP.First();
            Entities.Row.DeleteProduct(product);
            Entities.TotalSum.Sum += product.GetCost();
        }
    }
}
