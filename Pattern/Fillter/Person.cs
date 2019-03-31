using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fillter
{
    class Person
    {
        private string m_name;
        private string m_gender;
        private string m_marritalStatus;

        public Person(string name, string gender, string marritalStatus)
        {
            m_name = name;
            m_gender = gender;
            m_marritalStatus = marritalStatus;
        }
        public string GetName()
        {
            return m_name;
        }
        public string GetGender()
        {
            return m_gender;
        }
        public string GetMaritalStatus()
        {
            return m_marritalStatus;
        }
    }
}
