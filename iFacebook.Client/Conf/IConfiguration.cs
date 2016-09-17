using iFacebook.Client.Auth;
using iFacebook.Client.Internal.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Conf
{
    public interface IConfiguration : IHttpClientConfiguration, IHttpClientWrapperConfiguration, IAuthorizationConfiguration
    {
        bool isDalvik();
        bool isGAE();
        bool isDebugEnabled();
        string getUserAgent();
        string getClientVersion();
        string getClientURL();
        string getRestBaseURL();
        string getVideoBaseURL();
        string getOAuthAuthorizationURL();
        string getOAuthAccessTokenURL();
        string getOAuthAccessTokenInfoURL();
        string getOAuthDeviceTokenURL();
        bool isJSONStoreEnabled();
        bool isMBeanEnabled();
    }
}
