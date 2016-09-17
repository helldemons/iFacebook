using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Internal.Http
{
    public interface IHttpClientWrapperConfiguration : IHttpClientConfiguration
    {
        Dictionary<string, string> getRequestHeaders();
    }
}
