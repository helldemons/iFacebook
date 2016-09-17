using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Internal.Http
{
    public interface IHttpClientConfiguration
    {
        string getHttpProxyHost();
        int getHttpProxyPort();
        string getHttpProxyUser();
        string getHttpProxyPassword();
        int getHttpConnectionTimeout();
        int getHttpReadTimeout();
        int getHttpRetryCount();
        int getHttpRetryIntervalSeconds();
        int getHttpMaxTotalConnections();
        int getHttpDefaultMaxPerRoute();
        bool isPrettyDebugEnabled();
        bool isGZIPEnabled();
    }
}
