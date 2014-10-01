using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class WeakStudents
    {
        public static List<Student> FindWeakStudents(List<Student> students)
        {
            return students.Where(s => s.Marks.Count(i => i == 2) == 2).ToList();
        }
    }
}
