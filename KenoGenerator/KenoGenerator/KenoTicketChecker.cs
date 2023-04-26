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
        private readonly ISorsolasok _sorsolasok;
        public KenoTicketChecker(ISorsolasok sorsolasok)
        {
            _sorsolasok = sorsolasok;
        }

        //[Obsolete]
        //public bool IsAWinnerTicket(int[] numbers)
        //{
        //    var totalDays = (EndDate - StartDate).TotalDays;

        //    Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadSorsolas(StartDate,EndDate);

        //    if (numbers.Intersect(sorsolasok[StartDate]).Count() == numbers.Length)
        //        return true;

        //    return false;
        //}

        public bool IsAWinnerTicket(int[] numbers, DateTime startDate, DateTime endDate)
        {
            var totalDays = (endDate - startDate).TotalDays;
            
            Dictionary<DateTime, int[]> sorsolasok = _sorsolasok.ReadSorsolas(startDate, endDate);

            do
            {
                try
                {
                    if (numbers.Intersect(sorsolasok[startDate]).Count() == numbers.Length)
                        return true;
                }
                catch (KeyNotFoundException)
                {

                }

                startDate = startDate.AddDays(1);

            } while (startDate <= endDate);

            return false;
        }

        //public int HalfOfItBelow30()
        //{
        //    Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadSorsolas(StartDate, EndDate);

        //    var numbersOfBelow30 = sorsolasok.Where(x => x.Value.ElementAt(9) < 30);

        //    return numbersOfBelow30.Count();
        //}
    }
}
