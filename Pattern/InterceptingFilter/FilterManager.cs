using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.InterceptingFilter
{
    class FilterManager
    {
        FilterChan m_filterChan;
        public FilterManager(Target target) {
            m_filterChan = new FilterChan();
            m_filterChan.SetTarget(target);
        }
        public void SetFilter(IFilter filter) {
            m_filterChan.AddFilter(filter);
        }

        public void FilterRequest(string request) {
            m_filterChan.Execute(request);
        }

    }
}
