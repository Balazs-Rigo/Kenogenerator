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
        public bool IsAWinnerTicket(int[] numbers, DateTime date)
        {
            Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadSorsolas(500);

            if (numbers.Intersect(sorsolasok[date]).Count() == numbers.Length)
                return true;

            return false;
        }

        public bool IsAWinnerTicket(int[] numbers, DateTime startDate, DateTime endDate)
        {
            Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadSorsolas(300);

            do
            {
                if (numbers.Intersect(sorsolasok[startDate]).Count() == numbers.Length)
                    return true;

                startDate =  startDate.AddDays(1);

            } while (startDate <= endDate);   

            return false;
        }
    }
}
