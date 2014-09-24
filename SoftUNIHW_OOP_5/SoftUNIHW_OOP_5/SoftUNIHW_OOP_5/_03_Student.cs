using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_5
{
    class Student
    {
        private string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public delegate void PropertiesChanged(object sender, EventProperties e);

        private class PropertiesChangedEvent
        {
            public event PropertiesChanged Changed;

            protected virtual void OnChanged(EventProperties e)
            {
                if (Changed != null)
                {
                    Changed(this, e);
                }
            }

        }

        public override string ToString()
        {
            return String.Format("Name : {0}\t,Age : {1}", this.name, this.age);
        }

        public class EventProperties : EventArgs
        {
            private Student studentArgs;

            public Student StudentArgs
            {
                get { return studentArgs; }
                set { this.studentArgs = value; }
            }
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Tester()
        {
            Student newStudent = new Student();
        }
    }
}
