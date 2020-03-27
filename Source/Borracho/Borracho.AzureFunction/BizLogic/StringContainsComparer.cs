using System;
using System.Collections.Generic;

namespace Borracho.AzureFunction.BizLogic
{
    public class StringContainsComparer : EqualityComparer<string>
    {
        public override bool Equals(string x, string y)
        {
            if (x == null && y == null)
                return true;

            if (x == null)
                return false;

            if (y == null)
                return false;

            return x.Contains(y, StringComparison.InvariantCultureIgnoreCase)
                   || y.Contains(x, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode(string obj)
        {
            return 0;
        }
    }
}
