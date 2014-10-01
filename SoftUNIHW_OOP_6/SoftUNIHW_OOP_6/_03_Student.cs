using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string phone;
        private string email;
        private int age;
        private IList<int> marks;
        private string groupNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public IList<int> Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public Student(string firstname, string lastname, string facultynumber, string phone, string email, int age, 
            IList<int> marks, string groupnumber)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.FacultyNumber = facultynumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupnumber;

        }

        public static List<Student> students = new Student[]
        {
            new Student("Gosho", "Peshov", "212385901", "0878656434","goshopeshov@goshop.bg", 20, new int[]{3, 4, 5, 6, 5, 3, 3 ,4, 5},"14"),
            new Student("Tosho", "Georgiev", "212385711", "0888343434","tosho@abv.bg", 30, new int[]{4, 4, 4, 6, 6, 2, 3 ,3, 3},"14"),
            new Student("Maria", "Ivanova", "21115771", "0898656565","ivanova@gmail.com", 18, new int[]{6, 4, 5, 6, 5, 6, 6 ,6, 5},"14"),
            new Student("Anna", "Tzvetanova", "21335442", "0898656565","tzvetanova@yahoo.com", 25, new int[]{2, 4, 4, 6, 3, 5},"15")
        }.ToList();

    
        public override string ToString()
        {
            return String.Format("First Name : {0}\n Second Name : {1}\n Faculty Number :{2}\n Phone : {3}\n Email : {4}\n Avarage Grade: {5}\n Group : {6}", FirstName, LastName, FacultyNumber, Phone, Email, Marks.Average(), GroupNumber);
        }
    }
}
