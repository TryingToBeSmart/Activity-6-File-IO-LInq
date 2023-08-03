using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set;}

        public Student() { }

        public Student (string name, int age, int grade)
        {
            this.Name = name;
            this.Age = age; 
            this.Grade = grade;
        }

        public string Display()
        {
            return $"{this.Name} {this.Age} {this.Grade}";
        }

        //https://www.dotnetperls.com/icomparable
        public int CompareTo(Student? other)
        {
            //if grade is the same, then order by name
            if(this.Grade == other.Grade) return this.Name.CompareTo(other.Name);

            //order by grade
            return this.Grade.CompareTo(other.Grade);
        }
    }
}
