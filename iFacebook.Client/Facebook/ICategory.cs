using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface ICategory
    {
        string getId();
        string getName();
        string getCategory();
        DateTime getCreatedTime();
    }
}
