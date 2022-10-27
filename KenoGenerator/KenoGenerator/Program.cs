namespace KenoGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
            var kenoGenerator = new KenoGenerator(100,5);

            kenoGenerator.GenerateSzelvenyek();                   

            kenoGenerator.PrintSzelvenyek();

            if (kenoGenerator.IsThereDuplicateSzelvenyExist())
            {
                Console.WriteLine("2 egyforma szelveny");
            }

            Console.ReadLine();
        }       
    }
}