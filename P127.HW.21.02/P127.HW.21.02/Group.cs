using System;
using System.Collections.Generic;
using System.Text;

namespace P127.HW._21._02
{
    class Group
    {
        public string No;
        public int Limit;
        public Student[] Students ;

        
       /* public string AddStudents(Student student)
        {
            if (Limit =! Students.Length)
            {
                foreach (var item in Students)
                {
                    Students[item] = student;
                    item++;
                }


            }*/
        /*}*/

        // AddStudents hissesinde bezi problemleri edebilmedim.

        public void GetStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }

    }
}
