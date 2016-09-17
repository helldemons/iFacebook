using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public class FacebookException : Exception
    {
        private static long serialVersionUID = 1200504652249544235L;
        private int statusCode = -1;
    }
}
