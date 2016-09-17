using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Auth
{
    public class AccessToken
    {
        private static long serialVersionUID = -569157870319118047L;
        private string token;
        private string type;
        private long? expires;
        private AuthType authType;
        private string authNonce;
        string[] responseStr = null;

        public AccessToken()
        {

        }

        public AccessToken(string str)
        {
            parseQueryString(str);
        }

        public AccessToken(string token, long expires)
        {
            this.token = token;
            this.expires = expires;
        }

        private void parseQueryString(string url)
        {
            if (url.Contains("access_token="))
            {
                responseStr = url.Split('&');
                token = getParameter("access_token");
                if (responseStr.Length > 1)
                    expires = Convert.ToInt64(getParameter("expires"));
            }
            else
            {
                token = url;
                expires = null;
            }
        }

        public string getParameter(string parameter)
        {
            string value = string.Empty;
            foreach (var str in responseStr)
            {
                if (str.StartsWith(parameter + '='))
                {
                    value = str.Split('=')[1].Trim();
                    break;
                }
            }

            return value;
        }

        public string getToken()
        {
            return token;
        }

        public string getType()
        {
            return type;
        }

        public long getExpires()
        {
            return expires.HasValue ? expires.Value : 0;
        }

        public string getAuthNonce()
        {
            return authNonce;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (!(obj is AccessToken))
                return false;
            AccessToken that = (AccessToken)obj;
            if (token != null ? !token.Equals(that.token) : that.token != null)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return token != null ? token.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return string.Format("AccessToken{token='{0}', type='{1}', expires={2}, authType={3}, authNonce={4}, responseStr={5}}", token, expires, authType, authNonce, responseStr.ToString());
        }
    }
}
