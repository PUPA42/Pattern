using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    class OrCriteria : ICriteria
    {
        private ICriteria m_firstCriteria;
        private ICriteria m_secondCriteria;

        public OrCriteria(ICriteria firstCriteria, ICriteria secondCriteria)
        {
            this.m_firstCriteria = firstCriteria;
            this.m_secondCriteria = secondCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var meetFirstPerson = m_firstCriteria.MeetCriteria(persons);
            var meetSecondPerson = m_secondCriteria.MeetCriteria(persons);
            return meetFirstPerson.Union(meetSecondPerson).ToList();
        }
    }
}

