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
            const int TAIL = 0;
            const int FLIPCOINTIMES 20;

            //VARIABLES
            int i1 = 1;
            int ht_counter = 0;
            int th_counter = 0;
            int hh_counter = 0;
            int tt_counter = 0;

            IDictionary<int, string> tripleCombination = new Dictionary<int, string>();

            while (i1 <= FLIPCOINTIMES)
            {

                Random rand1 = new Random();
                int flipcoin = random.Next(0, 2);
                Random rand2 = new Random();
                int flipcoin = random.Next(0, 2);
                switch (flipcoin1, flipcoin2);
                {
                     case (Head, TAIL):
                        doubleCombination[i1] = "HT";
                    hhh_counter++;
                    break;
                    case (TAIL, Head,):
                        doubleCombination[i1] = "TH";
                    hht_counter++;
                    break;
                    case (Head, HEAD):
                        doubleCombination[i1] = "HH";
                    htt_counter++;
                    break;
                    default:
                        doubleCombination[i1] = "TT"
                        tt_Counter++;
                    break;

                }
                i1++;
            }
            for (int i2 = 1; i2 <= doubleCombination.count; i2++)
            {
                Console.WriteLine(doubleCombination[i2]);
            }
            Console.WriteLine();
            Console.WriteLine($"Persentage of HHH Single is {(hh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HHT Single is {(tt_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HTT Single is {(ht_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HTH Single is {(th_counter * 100) / FLIPCOINTIMES}");


            Console.ReadLine();
        }
    }
}
            

