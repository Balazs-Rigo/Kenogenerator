using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public class SorsolasOsszehasonlito
    {
        private KenoGenerator _generator;

        public SorsolasOsszehasonlito(KenoGenerator generator)
        {
            _generator = generator;
        }

        public int SorsolasSzelvenyOsszehasonlito(int[][] sorsolasok, int[][] szelvenyek)
        {
            bool isWinner = false;
            int sorsolasokSzama = 0;
            do
            {
                foreach (var sorsolt in sorsolasok)
                {
                    foreach (var generalt in szelvenyek)
                    {
                        if ((generalt.Intersect(sorsolt)).Count() == generalt.Length)
                        {
                            isWinner = true;
                            break;
                            // nyeroSzelvenyekSzama++;
                        }
                    }
                }
                if (!isWinner)
                {
                    szelvenyek = _generator.GenerateSzelvenyek();
                    sorsolasokSzama++;
                }
            } while (!isWinner);

            return sorsolasokSzama;
        }
    }
}
