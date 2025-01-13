using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EvenNumbersFilter
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }
    }

}


