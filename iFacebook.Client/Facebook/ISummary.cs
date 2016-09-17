using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface ISummary
    {
        SummaryOrder getOrder();
        int getTotalCount();
    }
}
