using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Product
    {
        new abstract public string GetType();
        abstract public int GetCost();

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var otherProduct = obj as Product;
            if (otherProduct == null)
            {
                return false;
            }
            else if (otherProduct.GetType().Equals(GetType()))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode();
        }
    }

    public class A : Product
    {
        public override int GetCost()
        {
            return 1;
        }

        public override string GetType()
        {
            return "A";
        }
    }

    public class B : Product
    {
        public override int GetCost()
        {
            return 2;
        }

        public override string GetType()
        {
            return "B";
        }
    }

    public class C : Product
    {
        public override int GetCost()
        {
            return 3;
        }

        public override string GetType()
        {
            return "C";
        }
    }

    public class D : Product
    {
        public override int GetCost()
        {
            return 4;
        }

        public override string GetType()
        {
            return "D";
        }
    }

    public class E : Product
    {
        public override int GetCost()
        {
            return 5;
        }

        public override string GetType()
        {
            return "E";
        }
    }

    public class F : Product
    {
        public override int GetCost()
        {
            return 6;
        }

        public override string GetType()
        {
            return "F";
        }
    }

    public class G : Product
    {
        public override int GetCost()
        {
            return 7;
        }

        public override string GetType()
        {
            return "G";
        }
    }

    public class H : Product
    {
        public override int GetCost()
        {
            return 8;
        }

        public override string GetType()
        {
            return "H";
        }
    }

    public class I : Product
    {
        public override int GetCost()
        {
            return 9;
        }

        public override string GetType()
        {
            return "I";
        }
    }

    public class J : Product
    {
        public override int GetCost()
        {
            return 10;
        }

        public override string GetType()
        {
            return "J";
        }
    }

    public class K : Product
    {
        public override int GetCost()
        {
            return 11;
        }

        public override string GetType()
        {
            return "K";
        }
    }

    public class L : Product
    {
        public override int GetCost()
        {
            return 12;
        }

        public override string GetType()
        {
            return "L";
        }
    }

    public class M : Product
    {
        public override int GetCost()
        {
            return 13;
        }

        public override string GetType()
        {
            return "M";
        }
    }


}
