using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public class GenerateRandomNumber
    {
        private Random random = new Random();
        public int Generate(int min, int max)
        {
            
            int number = random.Next(min, max);
            return number;  
        }
    }
}
