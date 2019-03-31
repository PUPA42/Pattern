using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var malePersons = new List<Person>();
            foreach (var item in persons)
            {
                if (item.GetGender() == "Male")
                {
                    malePersons.Add(item);
                }
            }
            return malePersons;
        }
    }
}
