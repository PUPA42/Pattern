using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    class AndCriteria : ICriteria
    {
        public ICriteria m_criteria;
        public ICriteria m_otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.m_criteria = criteria;
            this.m_otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var meetFirstCriteria = m_criteria.MeetCriteria(persons);
            return m_otherCriteria.MeetCriteria(meetFirstCriteria);
        }
    }
}
