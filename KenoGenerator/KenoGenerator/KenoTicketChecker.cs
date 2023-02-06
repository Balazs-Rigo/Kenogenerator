using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public class KenoTicketChecker
    {   
        public bool IsAWinnerTicket(DateTime date, int[] numbers)
        {
            Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadAllSorsolas();

            if (numbers.Intersect(sorsolasok[date]).Count() == numbers.Length)
                return true;

            return false;
        }
    }
}
