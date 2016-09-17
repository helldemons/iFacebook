using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public class PrivacyParameter
    {
        private static readonly long serialVersionUID = 3427495429925711593L;
        private string value;
        private string friends;
        private string networks;
        private string allow;
        private string deny;
        private string description;

        public string getValue()
        {
            return value;
        }

        public void setValue(string value)
        {
            this.value = value;
        }

        public string getFriends()
        {
            return friends;
        }

        public void setFriends(string friends)
        {
            this.friends = friends;
        }

        public string getNetworks()
        {
            return networks;
        }

        public void setNetworks(string networks)
        {
            this.networks = networks;
        }

        public string getAllow()
        {
            return allow;
        }

        public void setAllow(string allow)
        {
            this.allow = allow;
        }

        public string getDeny()
        {
            return deny;
        }

        public void setDeny(string deny)
        {
            this.deny = deny;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
