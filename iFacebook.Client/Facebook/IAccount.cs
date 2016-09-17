using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface IAccount : IFacebookResponse
    {
        string getName();
        string getAccessToken();
        string getCategory();
        string getId();
        List<string> getPerms();
    }
}
