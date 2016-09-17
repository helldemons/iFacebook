using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface ILocation
    {
        string getStreet();
        string getCity();
        string getState();
        string getCountry();
        string getZip();
        double getLatitude();
        double getLongtitude();
        string getText();
    }
}
