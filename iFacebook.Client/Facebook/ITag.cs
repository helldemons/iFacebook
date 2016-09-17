using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface ITag : IFacebookResponse
    {
        string getId();
        string getName();
        int getOffset();
        int getLength();
        string getType();
        double getX();
        double getY();
        DateTime getCreatedTime();
    }
}
