using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public class PersonalComputer : Computer
    {
        public override void print(string message)
        {
            Console.WriteLine("Personal Computer: " + message);
        }
    }
}
