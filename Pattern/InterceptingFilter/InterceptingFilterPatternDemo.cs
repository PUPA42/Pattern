using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.InterceptingFilter
{
    class InterceptingFilterPatternDemo
    {
        public static void Test() {
            var filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());

            var client = new Client();
            client.SetFilterManager(filterManager);
            client.SendRequest("HOME");
        }
    }
}
