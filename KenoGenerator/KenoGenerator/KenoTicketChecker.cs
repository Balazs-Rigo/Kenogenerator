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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = DateTime.Today;
        public int NumberOfDays { get; set; }

        public KenoTicketChecker()
        {
            StartDate = DateTime.Today;
        }

        public KenoTicketChecker(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public bool IsAWinnerTicket(int[] numbers)
        {
            var totalDays = (EndDate - StartDate).TotalDays;

            Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadSorsolas(StartDate,EndDate);

            //if (numbers.Intersect(sorsolasok[date]).Count() == numbers.Length)
            //    return true;

            return false;
        }

        public bool IsAWinnerTicket(int[] numbers, DateTime startDate)
        {
            var totalDays = (EndDate - StartDate).TotalDays;
            
            Dictionary<DateTime, int[]> sorsolasok = Sorsolasok.ReadSorsolas(StartDate, EndDate);

            //do
            //{
            //    if (numbers.Intersect(sorsolasok[startDate]).Count() == numbers.Length)
            //        return true;

            //    startDate =  startDate.AddDays(1);

            //} while (startDate <= endDate);   

            return false;
        }
    }
}
