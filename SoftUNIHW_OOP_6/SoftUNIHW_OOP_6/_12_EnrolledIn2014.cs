using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class _12_EnrolledIn2014
    {
        public static List<Student> EnrolledThisYear(List<Student> students)
        {
            return students.OrderBy(s => s.GroupNumber == "14").ToList();
        }
    }
}
