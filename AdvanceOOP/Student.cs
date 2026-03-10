using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public class Student : Person, IPerson
    {
        private const string idPrefix = "C-";
        private readonly int _id; 
        private string address;

        public Student(int id) : base(100)
        {
            _id = id;
        }
        public string GetStudentId()
        {
            return idPrefix + _id;
        }
        public double CalculateCgpa()
        {
            var cgpa = 0.0;
            foreach (var grade in grades)
            {
                cgpa += grade;
            }
            return cgpa / grades.Length;

        }

        public override string GetId()
        {
            throw new NotImplementedException();
        }

        public void Talk(string message)
        {
            this.address = address;
        }

        public void SetAddress(string message)
        {
            Console.WriteLine(message);
        }
    }
}
