using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.InterceptingFilter
{
    class FilterChan
    {
        private List<IFilter> m_filters = new List<IFilter>();
        private Target m_target;

        public void AddFilter(IFilter filter) {
            m_filters.Add(filter);
        }

        public void Execute(string request) {
            foreach (var item in m_filters)
            {
                item.Execute(request);
            }
            m_target.Execute(request);
        }
        public void SetTarget(Target target) {
            m_target = target;
        }
    }
}
