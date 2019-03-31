using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var singlePersons = new List<Person>();
            foreach (var item in persons)
            {
                if (item.GetMaritalStatus() == "Single")
                {
                    singlePersons.Add(item);
                }
            }
            return singlePersons;
        }

    }
}
