using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //construct Person objects
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Url { get; set; } 

        public Person() { }

        public Person(string firsName, string lastName, string Url) 
        { 
            this.firstName = firsName;
            this.lastName = lastName;
            this.Url = Url; 
        }

        //used to display info in the listbox
        public string AllInfo 
        { 
            get
            {
                return $"{firstName} {lastName} {Url}";
            }
                
         }
    }
}
