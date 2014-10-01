using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class ExcellentStudents
    {
        public static List<Student> FindExcellentStudents(List<Student> students)
        {
            return students.Where(s => s.Marks.Contains(6)).ToList();
        }
    }
}
