using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entities
{
    public static class Row
    {
        static List<Product> lP = SetRow();

        static List<Product> SetRow()
        {
            //var _lP = new List<Product>();
            //_lP.Add(new A());
            //_lP.Add(new B());
            //_lP.Add(new C());
            //_lP.Add(new D());
            //_lP.Add(new E());
            //_lP.Add(new F());
            //_lP.Add(new G());
            //_lP.Add(new H());
            //_lP.Add(new I());
            //_lP.Add(new J());
            //_lP.Add(new K());
            //_lP.Add(new L());
            //_lP.Add(new M());
            var _lP = new List<Product>();
            _lP.Add(new A());
            _lP.Add(new A());
            _lP.Add(new A());
            _lP.Add(new C());
            _lP.Add(new C());
            _lP.Add(new C());
            return _lP;
        }

        public static List<Product> LP { get { return lP; } }

        //может не удаляться, т.к. ссылки на объект не совпадают
        public static void DeleteProduct(Product product)
        {
            if(lP.Contains(product))
            {
                lP.RemoveAt(lP.IndexOf(product));
            }
        }

        public static void DeleteProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                DeleteProduct(product);
            }
        }
    }
}
