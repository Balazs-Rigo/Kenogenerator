using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public class Sorsolasok
    {
        public int[][] ReadAllSorsolas()
        {
            var filePath = @"Sorsolasok\keno.csv";
            int[][] sorsolasok = new int[1][];
            int sorsolasokSzama = 0;

            var lines = File.ReadAllLines(filePath).Select(a => a.Split(';'));
            var sorsolasokFromFile = ((from line in lines
                      select (from piece in line
                              select piece))).ToList();

            foreach (var sorsol in sorsolasokFromFile)
            {
                sorsolasok[sorsolasokSzama] = sorsol.Skip(4).Select(x=> int.Parse(x)).ToArray();
                sorsolasokSzama++;
                if (sorsolasokSzama == 1)
                    break;
            }
            return sorsolasok;
        }
    }
}
