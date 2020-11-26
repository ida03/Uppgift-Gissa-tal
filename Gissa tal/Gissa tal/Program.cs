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
            int tal; //det talet som slumpas fram
            int räknare; //räknare för att hålla koll på antalet gissningar som har gjorts
            Console.WriteLine("Ange ett heltal mellan 1 och 100"); //fråga till användaren
            string strgissning = Console.ReadLine();
            int gissning = Convert.ToInt32(strgissning);

            if (gissning < tal) //om gissningen är mindre än det slumpade talet
                Console.WriteLine("Gissningen är för låg");

            if (gissning > tal) //om gissningen är högre än det slumpade talet
                Console.WriteLine("Gissningen är för hög");

            if (gissning == tal) //om gissningen är lika med det slumpade talet
                Console.WriteLine("Gissningen är rätt!");

        }
    }
}
