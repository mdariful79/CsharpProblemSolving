using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public class Teacher : Person
    {
        private const string idPrefix = "T-";
        private readonly int _id;
        public int Salary { get; set; }
        public Teacher(int id) : base(0)
        {
            _id = id;
        }
        public int CalclateBonus(int percent)
        {
            return Salary * percent / 100;
        }

        public override string GetId()
        {
            throw new NotImplementedException();
        }
    }
}



