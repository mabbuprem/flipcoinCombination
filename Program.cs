using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipcoin
{
    internal class flipcoinCombination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the flipcoin combination");
            //CONSTANTS
            const int Head = 1;
            const int FLIPCOINTIMES 20;

            //VARIABLES
            int i1 = 1;
            int headcounter = 0;
            int tailcounter = 0;
            IDictionary<int, string> tripleCombination = new Dictionary<int, string>();

            while (i1 <= FLIPCOINTIMES)
            {

                Random rand = new Random();
                int flipcoin = random.Next(0, 2);
                if (flipcoin == Head)
                {
                    //Console.WriteLine("HEAD")
                    SingleCombination[i1] = "H";
                    tailcounter++;
                }
                i1++;
            }
            for (int i2 = 1; i2 <= singleCombination.count; i2++)
            {
                Console.WriteLine(singleCombination[i2]);
            }
            Console.WriteLine();
            Console.WriteLine($"Persentage of HHH Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HHT Single is {(hhh_counter * 100) / FLIPCOINTIMES}");


            Console.ReadLine();
        }
    }
}
            

