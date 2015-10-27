using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Discounts
{
    public static class Combo
    {
        static List<Product> subAr;
        public static void Check(int amount, List<Product> exceptions, double discount)
        {
            var flag = Contain(amount, exceptions);
            while (flag)
            {
                Calculate(amount, discount);
                flag = Contain(amount, exceptions);
            }
        }

        static bool Contain(int amount, List<Product> exceptions)
        {
            List<Product> sub = Entities.Row.LP;
            foreach(var product in exceptions)
            {
                sub = sub.Where(a => !a.Equals(product)).ToList();
            }
            if (sub.Count >= amount)
            {
                subAr = sub;
                return true;
            }
            return false;

        }

        static void Calculate(int amount, double discount)
        {
            var products = new List<Product>();
            var sum = 0;
            for(var i =0; i<amount; i++)
            {
                var elem = subAr.First();
                sum += elem.GetCost();
                subAr.RemoveAt(subAr.IndexOf(elem));
                Entities.Row.DeleteProduct(elem);
            }
            Entities.TotalSum.Sum += sum * discount;
        }
    }
}
