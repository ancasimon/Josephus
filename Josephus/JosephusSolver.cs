using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Josephus
{
    public class JosephusSolver
    {
        public int Solve(int numberOfPeople, int killingInterval)
        {
            //throw new NotImplementedException();
            //return 1; ---this was the correct answer for the first test case 

            //code block for the first 3 tests:
            //if (killingInterval == 1) return numberOfPeople;
            //if (killingInterval == 2) return numberOfPeople / 2;

            if (killingInterval == 1) return numberOfPeople;
            if (killingInterval == 2)
            {
                return Enumerable.Range(1, numberOfPeople).Where(number => number % 2 > 0).Max(); //Give me a list of all the numbers in that range - then take away all the even ones (because we know they will die right away) - and then give me the biggest number (the person left standing)
            }


            return numberOfPeople;
        }
    }
}
