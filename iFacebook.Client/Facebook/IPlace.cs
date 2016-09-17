using System.Collections.Generic;

namespace iFacebook.Client.Facebook
{
    public interface IPlace : IFacebookResponse
    {
        string getId();
        string getName();
        List<ICategory> getCategories();
        ILocation getLocation();
    }
}
