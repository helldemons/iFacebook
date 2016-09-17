using System.Collections.Generic;

namespace iFacebook.Client.Facebook
{
    public interface IAdmin : IFacebookResponse
    {
        string getId();
        string getName();
        string getRole();
        List<string> getPerms();
    }
}
