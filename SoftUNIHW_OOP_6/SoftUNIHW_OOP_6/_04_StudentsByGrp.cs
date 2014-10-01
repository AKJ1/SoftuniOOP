using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class StudentsByGrp
    {
        public static List<Student> sortStudents(List<Student> student)
        {
            return student.OrderBy(s => s.FirstName).ToList();
        }
    }
}
