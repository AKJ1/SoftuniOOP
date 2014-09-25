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
            set
            {
                this.OnPropertiesChanged(new PropertyChangedEventArgs<string>(this.age.ToString(), value.ToString(), "Age"));
                try
                {
                    age = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something Went horribly wrong. You probably entered an incorrent integer or a string, Try again.");
                    Age = int.Parse(Console.ReadLine());
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                this.OnPropertiesChanged(new PropertyChangedEventArgs<string>(this.name, value, "Name"));
                try
                {
                    name = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went horribly wrong if this failed. Look outside your window for signs of Apocalypse.\n" +
                                      " If the apocalypse doesnt seem to have begun, try entering the name again, otherwise, Best of luck!");
                    Name = Console.ReadLine();

                }
            }
        }

        public event EventHandler<PropertyChangedEventArgs<string>> PropertiesChanged;

        protected virtual void OnPropertiesChanged(PropertyChangedEventArgs<string> e)
        {
            EventHandler<PropertyChangedEventArgs<string>> handler = PropertiesChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public override string ToString()
        {
            return String.Format("Name : {0}\n,Age : {1}", this.name, this.age);
        }


        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public static void Tester()
        {
            Student newStudent = new Student("Gesho", 22);
            newStudent.PropertiesChanged = (sender, args) =>
            {
                Console.WriteLine("Property Changed : {0}", args.Property);
                Console.WriteLine("Old value : {0}", args.OldValue);
                Console.WriteLine("New value : {0}", args.NewValue);
            };
            newStudent.Name = "Gosho";
            newStudent.Age = 32;
            Console.WriteLine("\nTry it out yourself!\n");
            Console.WriteLine("Enter desired name");
            newStudent.Name = Console.ReadLine();
            Console.WriteLine("Enter desired age");
            int desiredAge = default(int);
            int.TryParse(Console.ReadLine(), out desiredAge);
            newStudent.Age = desiredAge; 
        }
    }

    class PropertyChangedEventArgs<T> : EventArgs
    {
        
        public T NewValue { get; set; }
        public T OldValue { get; set;  }
        public string Property { get; set; }
        public PropertyChangedEventArgs(T oldValue, T newValue, string property)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.Property = property;
        }
    }
}
