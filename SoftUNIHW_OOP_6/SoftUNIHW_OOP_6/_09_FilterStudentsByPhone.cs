using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class FilterStudentsByPhone
    {
        public static List<Student> FilterByPhone(List<Student> students)
        {
            return students.Where(s => s.Phone.Contains("02") || s.Phone.Contains("+3592") || s.Phone.Contains("+359 2")).ToList();
        }
    }
}
