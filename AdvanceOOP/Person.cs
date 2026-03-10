using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        protected int[] grades;


        public string Id 
        {
            get
            {
                return GetId();
            }
        }
        public Person(int size) // Constructor
        {
            grades = new int[size];
        }
        ~Person()
        {
            grades = new int[0]; // Destructor or Finalizer
        }
        public void SetGrade(int[] grades)
        {
            this.grades = grades;
        }
        public abstract string GetId(); // Abstract method

    }
}
