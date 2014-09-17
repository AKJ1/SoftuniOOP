using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class _03_SoftuniStructure
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        protected string firstName ;
        protected string lastName ;
        protected int age;

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

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }

    class Trainer : Person
    {
        static void CreateCourse(string CourseName)
        {
            //TODO Create(CourseName);
        }
    }

    class SeniorTrainer : Trainer
    {
        static void DestroyCourse(string CourseName)
        {
            //TODO DESTROY(CourseName);
        }
    }

    class Student : Person
    {
        private decimal avgGrade;
        private string studentNumber;

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public decimal GetAvgGrade
        {
            get { return avgGrade; }
        }

        public void SetAvgGrade(decimal[] grades)
        {
            decimal total = 0.0m;
            int counter = 0;
            foreach (decimal d in grades)
            {
                total += d;
                counter++;
            }
            this.avgGrade = total/counter;
        }
    }

    class Dropout : Student
    {
        private string reason;

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public string Reapply()
        {
            return string.Format("First Name: {0} \n Last Name: {1} \n Age: {2} \n Reason For Dropout: {3} \n",
                this.firstName, this.lastName, this.age, this.Reason);
        }
    }

    class CurrentStudent : Student
    {
         
    }

    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public int NumberOfVisits
        {
            get { return numberOfVisits; }
            set { numberOfVisits = value; }
        }
    }

    class SULSTester
    {

        void Test()
        {
            //TODO : CBA
        }
    }
}
