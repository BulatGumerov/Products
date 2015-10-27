using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pair90 = new List<Product>();
            pair90.Add(new A());
            pair90.Add(new B());

            var pair95 = new List<Product>();
            pair95.Add(new D());
            pair95.Add(new E());

            var triple95 = new List<Product>();
            triple95.Add(new E());
            triple95.Add(new F());
            triple95.Add(new G());

            var firstPair95 = new List<Product>();
            firstPair95.Add(new A());
            firstPair95.Add(new K());

            var secondPair95 = new List<Product>();
            secondPair95.Add(new A());
            secondPair95.Add(new L());

            var thirdPair95 = new List<Product>();
            thirdPair95.Add(new A());
            thirdPair95.Add(new M());

            var exceptions = new List<Product>();
            exceptions.Add(new A());
            exceptions.Add(new C());

            Discounts.Stack.Check(pair90, 0.9);
            Discounts.Stack.Check(pair95, 0.95);
            Discounts.Stack.Check(triple95, 0.95);
            Discounts.Stack.Check(firstPair95, 0.95);
            Discounts.Stack.Check(secondPair95, 0.95);
            Discounts.Stack.Check(thirdPair95, 0.95);

            Discounts.Combo.Check(5, exceptions, 0.8);
            Discounts.Combo.Check(4, exceptions, 0.9);
            Discounts.Combo.Check(3, exceptions, 0.95);

            while(Entities.Row.LP.Count>0)
            {
                Discounts.Rest.Check();
            }

            Console.WriteLine(Entities.TotalSum.Sum.ToString());
            Console.ReadKey();
        }
    }
}
