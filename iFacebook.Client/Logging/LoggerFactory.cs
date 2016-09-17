using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Logging
{
    public abstract class LoggerFactory
    {
        public abstract Logger getLogger(dynamic paramClass);
    }
}
