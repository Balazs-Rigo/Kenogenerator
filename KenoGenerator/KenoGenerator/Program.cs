namespace KenoGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int megjatszottSzamok = 4;
            //var kenoGenerator = new KenoGenerator(1, megjatszottSzamok);
            //var generaltSzelvenyek = kenoGenerator.GenerateSzelvenyek();

            //var sorsolasok = new Sorsolasok();
            //var sorsoltSzelvenyek = sorsolasok.ReadAllSorsolas();

            //var osszehasonlito = new SorsolasOsszehasonlito(kenoGenerator);

            //int sorsolasokSzama = osszehasonlito.SorsolasSzelvenyOsszehasonlito(sorsoltSzelvenyek,generaltSzelvenyek);

            ////kenoGenerator.PrintSzelvenyek();

            ////if (kenoGenerator.IsThereDuplicateSzelvenyExist())
            ////{
            ////    Console.WriteLine("2 egyforma szelveny");
            ////}       


            //Console.WriteLine("sorsolasok szama: "+sorsolasokSzama);
            ////Console.WriteLine("Nyero Szelvenyek szama: " +nyeroSzelvenyekSzama);
            ////var szamok1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            ////var szamok2 = new int[] { 4, 1, 5, 4 };

            ////var intersect = szamok2.Intersect(szamok1).Count();
            ///
            KenoTicketChecker kenoTicketChech= new KenoTicketChecker();

            int[] numbers = new int[] { 24,25,26 };

            var isWinner = kenoTicketChech.IsAWinnerTicket(new DateTime(2021, 10, 20), numbers);

            Console.WriteLine("Is winner?: " + isWinner); 

            Console.ReadLine();
        }  
    }
}