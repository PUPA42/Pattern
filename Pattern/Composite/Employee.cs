using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite
{
    class Employee
    {
        private string m_name;
        private string m_dept;
        private int m_salary;
        private List<Employee> m_subordinates=new List<Employee>();

        public Employee(string name, string dept, int salary)
        {
            this.m_name = name;
            this.m_dept = dept;
            this.m_salary = salary;
        }

        public void Add(Employee e) {
            m_subordinates.Add(e);
        }
        public void Remove(Employee e) {
            m_subordinates.Remove(e);   
        }
        public List<Employee> GetSubordinates()
        {
            return m_subordinates;
        }
        public override string ToString()
        {
            var sb = new StringBuilder("[name]:").Append(m_name)
                .Append(" ,[dept]:").Append(m_dept).Append(",[salary]:").Append(m_salary);
            return sb.ToString();
        }


    }
}
