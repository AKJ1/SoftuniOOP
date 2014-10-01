using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    // What's happening, this is the same as _05_...
    class SortStudents
    {
            public static List<Student> SortStudentsFirstLast(List<Student> students)
            {   
                return students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
            }
    }
}
