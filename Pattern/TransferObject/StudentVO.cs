using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.TransferObject
{
    class StudentVO
    {
        private string m_name;
        private int m_rollNo;

        public StudentVO(string m_name, int m_rollNo)
        {
            this.m_name = m_name;
            this.m_rollNo = m_rollNo;
        }

        public string GetName()
        {
            return m_name;
        }
        public void SetName(string name)
        {
            m_name = name;
        }
        public int GetRollNo()
        {
            return m_rollNo;
        }
        public void SetRollNo(int rollNo)
        {
            m_rollNo = rollNo;
        }

    }
}
