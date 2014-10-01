using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class StudentsByFirstLast
    {
        public static List<Student> SortByFirstLast(List<Student> students)
        {
            return students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
        }
    }
}
