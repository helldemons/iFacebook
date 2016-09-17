using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Conf
{
    public class ConfigurationBase : IConfiguration
    {
        private static long serialVersionUID = -4618524490519309627L;
        private bool debug;
        private string userAgent;
        private bool useSSL;
        private bool prettyDebug;
        private bool gzipEnabled;
        private string httpProxyHost;
        private string httpProxyUser;
        private string httpProxyPassword;
        private int httpProxyPort;
        private int httpConnectionTimeout;
        private int httpReadTimeout;
        private int httpStreamingReadTimeout;
        private int httpRetryCount;
        private int httpRetryIntervalSeconds;
        private int maxTotalConnections;
        private int defaultMaxPerRoute;
        private string oAuthAppId;
        private string oAuthAppSecret;
        private string oAuthPermissions;
        private string oAuthAccessToken;
        private string oAuthCallbackURL;
        private bool appSecrectProofEnabled;
        private string oAuthAuthorizationURL;
        private string oAuthAccessTokenURL;
        private string oAuthAccessTokenInfoURL;
        private string oAuthDeviceTokenURL;
        private string restBaseURL;
        private string videoBaseURL;
        private bool jsonStoreEnabled;
        private bool mbeanEnabled;
        private string clientVersion;
        private string clientURL;
        private static readonly string DEFAULT_OAUTH_AUTHORIZATION_URL = "http://www.facebook.com/dialog/oauth";
  private static readonly string DEFAULT_OAUTH_ACCESS_TOKEN_URL = "http://graph.facebook.com/oauth/access_token";
  private static readonly string DEFAULT_OAUTH_ACCESS_TOKEN_INFO_URL = "http://graph.facebook.com/oauth/access_token_info";
  private static readonly string DEFAULT_OAUTH_DEVICE_TOKEN_URL = "http://graph.facebook.com/oauth/device";
  private static readonly string DEFAULT_REST_BASE_URL = "http://graph.facebook.com/";
  private static readonly string DEFAULT_VIDEO_BASE_URL = "http://graph-video.facebook.com/";
        private bool IS_DALVIK;
        private bool IS_GAE;
        static string dalvikDetected;
        static string gaeDetected;
        Dictionary<string, string> requestHeaders;

        protected ConfigurationBase()
        {
            
        }

        public int getAppSecretProofCacheSize()
        {
            throw new NotImplementedException();
        }

        public string getClientURL()
        {
            throw new NotImplementedException();
        }

        public string getClientVersion()
        {
            throw new NotImplementedException();
        }

        public int getHttpConnectionTimeout()
        {
            throw new NotImplementedException();
        }

        public int getHttpDefaultMaxPerRoute()
        {
            throw new NotImplementedException();
        }

        public int getHttpMaxTotalConnections()
        {
            throw new NotImplementedException();
        }

        public string getHttpProxyHost()
        {
            throw new NotImplementedException();
        }

        public string getHttpProxyPassword()
        {
            throw new NotImplementedException();
        }

        public int getHttpProxyPort()
        {
            throw new NotImplementedException();
        }

        public string getHttpProxyUser()
        {
            throw new NotImplementedException();
        }

        public int getHttpReadTimeout()
        {
            throw new NotImplementedException();
        }

        public int getHttpRetryCount()
        {
            throw new NotImplementedException();
        }

        public int getHttpRetryIntervalSeconds()
        {
            throw new NotImplementedException();
        }

        public string getOAuthAccessToken()
        {
            throw new NotImplementedException();
        }

        public string getOAuthAccessTokenInfoURL()
        {
            throw new NotImplementedException();
        }

        public string getOAuthAccessTokenURL()
        {
            throw new NotImplementedException();
        }

        public string getOAuthAppId()
        {
            throw new NotImplementedException();
        }

        public string getOAuthAppSecret()
        {
            throw new NotImplementedException();
        }

        public string getOAuthAuthorizationURL()
        {
            throw new NotImplementedException();
        }

        public string getOAuthCallbackURL()
        {
            throw new NotImplementedException();
        }

        public string getOAuthDeviceTokenURL()
        {
            throw new NotImplementedException();
        }

        public string getOAuthPermissions()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> getRequestHeaders()
        {
            throw new NotImplementedException();
        }

        public string getRestBaseURL()
        {
            throw new NotImplementedException();
        }

        public string getUserAgent()
        {
            throw new NotImplementedException();
        }

        public string getVideoBaseURL()
        {
            throw new NotImplementedException();
        }

        public bool isAppSecretProofEnabled()
        {
            throw new NotImplementedException();
        }

        public bool isDalvik()
        {
            return true;
        }

        public bool isDebugEnabled()
        {
            throw new NotImplementedException();
        }

        public bool isGAE()
        {
            throw new NotImplementedException();
        }

        public bool isGZIPEnabled()
        {
            throw new NotImplementedException();
        }

        public bool isJSONStoreEnabled()
        {
            throw new NotImplementedException();
        }

        public bool isMBeanEnabled()
        {
            throw new NotImplementedException();
        }

        public bool isPrettyDebugEnabled()
        {
            throw new NotImplementedException();
        }
    }
}
