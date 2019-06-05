using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.InterceptingFilter
{
    class Client
    {
        FilterManager m_filterManager;
        public void SetFilterManager(FilterManager filterManager) {
            m_filterManager = filterManager;
        }
        public void SendRequest(string request)
        {
            m_filterManager.FilterRequest(request);
        }
    }
}
