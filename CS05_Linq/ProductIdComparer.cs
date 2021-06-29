using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS05_Linq
{
    class ProductIdComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product? x, Product? y)
        {
            return x.Id == y.Id;
        }

        public override int GetHashCode(Product obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
