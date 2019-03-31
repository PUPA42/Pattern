using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var femaleList = new List<Person>();
            foreach (var item in persons)
            {
                if (item.GetGender() == "Female")
                {
                    femaleList.Add(item);
                }
            }
            return femaleList;
        }
    }
}
