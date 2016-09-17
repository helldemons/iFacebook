using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Auth
{
    public interface IAuthorizationConfiguration
    {
        string getOAuthAppId();
        string getOAuthAppSecret();
        string getOAuthAccessToken();
        string getOAuthPermissions();
        string getOAuthCallbackURL();
        bool isAppSecretProofEnabled();
        int getAppSecretProofCacheSize();
    }
}
