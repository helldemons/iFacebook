using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Internal.Json
{
    public sealed class Null : ICloneable
    {
        public object Clone()
        {
            return this;
        }

        public override bool Equals(object obj)
        {
            return (obj == null) || (obj == this);
        }

        public override string ToString()
        {
            return "null";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
