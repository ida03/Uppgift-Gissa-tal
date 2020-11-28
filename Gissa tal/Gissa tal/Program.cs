using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            int räknare = 0;
            int gissning = 0;
            Random randomerare = new Random();
            int tal = randomerare.Next(1, 100);

            while (gissning != tal)
            {
                Console.WriteLine("Ange ett heltal mellan 1 och 100");
                string strgissning = Console.ReadLine();
                gissning = Convert.ToInt32(strgissning);
                räknare++;

                if (gissning < tal)
                    Console.WriteLine("Gissningen är för låg");
                if (gissning > tal)
                    Console.WriteLine("Gissningen är för hög");
            } 
            if (gissning == tal)
                Console.WriteLine("Gissningen är rätt!");
                Console.WriteLine("Antal gissningar: " + räknare);
                Console.ReadLine();
        }
    }
}
