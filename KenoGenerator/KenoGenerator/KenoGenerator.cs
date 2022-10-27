using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public class KenoGenerator
    {
        public int[][] szelvenyek { get; }
        public int MegjatszottSzamokSzama { get; private set; }
        private int NumberOfDuplicates { get; set; } = 0;

        public KenoGenerator(int szelvenyekSzama, int megjatszottSzamokSzama)
        {
            szelvenyek = new int[szelvenyekSzama][];
            MegjatszottSzamokSzama = megjatszottSzamokSzama;
        }

        public int[][] GenerateSzelvenyek()
        {
            for (int i = 0; i < szelvenyek.Length; i++)
            {
                szelvenyek[i] = GenerateSzelveny();
            }           
            return szelvenyek;
        }

        private int[] GenerateSzelveny()
        {
            int[] szelveny = new int[MegjatszottSzamokSzama];
            int szam = 0;
            Random veletlenSzam = new Random();
            
            for (int j = 0; j < szelveny.Length; j++)
            {
                szam = veletlenSzam.Next(1, 81);
                szelveny[j] = szam;
            }
            
            Array.Sort(szelveny);

            if (HasDuplicateNumberInSzelveny(szelveny))
            {
                NumberOfDuplicates++;
                GenerateSzelveny();
            }

            return szelveny;
        }

        public void PrintSzelvenyek()
        {
            int sorszam = 0;

            foreach (var szelveny in szelvenyek)
            {
                sorszam++;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("sorszam: " + sorszam);

                foreach (var szam in szelveny)
                {
                    Console.Write(szam+ ", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Number of duplicats in szelveny: " + NumberOfDuplicates);
        }

        public bool IsThereDuplicateSzelvenyExist()
        {
            bool isThereEqualArraysExist;

            for (int i = 0; i < szelvenyek.Length; i++)
            {
                for (int j = i+1; j < szelvenyek.Length; j++)
                {
                    isThereEqualArraysExist = szelvenyek[i].SequenceEqual(szelvenyek[j]);

                    if (isThereEqualArraysExist)
                    {
                        Console.WriteLine(" egyezo sorszamok: " + i + ", "+j);

                        return true;
                    }
                }
            }
            return false;
        }

        private bool HasDuplicateNumberInSzelveny(int[] szelveny)
        {
            return szelveny.Distinct().Count() < szelveny.Length;           
        }
    }
}
