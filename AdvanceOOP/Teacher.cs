using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public Teacher() : base(0)
        {
        }
        public int CalclateBonus(int percent)
        {
            return Salary * percent / 100;
        }
    }
}
