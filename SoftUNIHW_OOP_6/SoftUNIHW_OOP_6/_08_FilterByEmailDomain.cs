using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class FilterByEmailDomain
    {
        public static List<Student> FilterByMailDomain(List<Student> students)
        {
            return students.Where(s => !s.Email.Contains("@abv.bg")).ToList();
        }
    }
}
