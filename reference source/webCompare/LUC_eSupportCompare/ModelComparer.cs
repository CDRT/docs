using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUC_eSupportCompare
{
    class ModelComparer : IEqualityComparer<ModelInformation>
    {
        public bool Equals(ModelInformation x, ModelInformation y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.getName() == y.getName();
        }

        public int GetHashCode(ModelInformation obj)
        {
            return obj.GetHashCode();
        }
    }
}
