using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Auth
{
    public interface IAuthOption
    {
        string getQuery(string paramString);
    }
}
