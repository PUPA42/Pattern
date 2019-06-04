using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.TransferObject
{
    class TransferObjectPatternDemo
    {
        public static void Test()
        {
            var studentBO = new StudentBO();
            studentBO.AddStudent("John");
            studentBO.AddStudent("Robert");
            foreach (var item in studentBO.GetAllStudent())
            {
                Print(item);
            }
            var temp = studentBO.GetStudent(0);
            temp.SetName("Michael");
            studentBO.UpdateStudent(temp);
            var st = studentBO.GetStudent(0);
            Print(st);
        }
        private static void Print(StudentVO student)
        {
            System.Console.WriteLine("Name=" + student.GetName() + ",Roll Name=" + student.GetRollNo());
        }
    }
}
