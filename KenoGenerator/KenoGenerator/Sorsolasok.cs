using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public static class Sorsolasok
    {
        public static Dictionary<DateTime, int[]> ReadSorsolas(DateTime startDate, DateTime endDate)
        {
            //var numberOfDays = (int)(endDate - startDate).TotalDays;
            var numberOfDays = 8000;
            var filePath = @"Sorsolasok\keno.csv";
            Dictionary<DateTime, int[]> sorsolasok = new Dictionary<DateTime, int[]>();
            int sorsolasokSzama = 0;

            var lines = File.ReadAllLines(filePath).Select(a => a.Split(';'));
            var sorsolasokFromFile = ((from line in lines
                      select (from piece in line
                              select piece))).ToList();

            foreach (var sorsol in sorsolasokFromFile)
            {
                sorsolasok.Add(DateTime.Parse(sorsol.Skip(3).Take(1).FirstOrDefault()), 
                    sorsol.Skip(4).Select(x => int.Parse(x)).ToArray());

                if (sorsolasok.Count == numberOfDays)
                    break;
            }
            return sorsolasok.Where(x => x.Key >= startDate && x.Key <= endDate).ToDictionary(x=> x.Key,x=>x.Value);
        }
    }
}
