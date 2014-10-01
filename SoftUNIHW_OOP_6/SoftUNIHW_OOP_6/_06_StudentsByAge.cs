using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class StudentsByAge
    {
        public static List<Student> SortByAge(List<Student> students)
        {
            return students.OrderBy(s => s.Age).ToList();
        }
    }
}
