using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.TransferObject
{
    class StudentBO
    {
        private List<StudentVO> m_students = new List<StudentVO>();

        public void AddStudent(string name)
        {
            var index = m_students.Count;
            m_students.Add(new StudentVO(name, index));
        }

        public void DeleteStudent(StudentVO student)
        {
            m_students.Remove(student);
            for (int i = student.GetRollNo(); i < m_students.Count; i++)
            {
                m_students[i].SetRollNo(i);
            }
            Console.WriteLine("Student: Roll No "
     + student.GetRollNo() + ", deleted from database");
        }
        public List<StudentVO> GetAllStudent()
        {
            return m_students;
        }
        public StudentVO GetStudent(int index)
        {
            return m_students[index];
        }

        public void UpdateStudent(StudentVO student)
        {
            m_students[student.GetRollNo()] = student;
        }

    }
}
