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
            const int TAIL = 2;
            const int FLIPCOINTIMES = 20;

            //VARIABLES
            int i1 = 1;
            int hhh_counter = 0;
            int hht_counter = 0;
            int htt_counter = 0;
            int hth_counter = 0;
            int ttt_counter = 0;
            int thh_counter = 0;
            int tht_counter = 0;
            int tth_counter = 0;
            IDictionary<int, string> tripleCombination = new Dictionary<int, string>();

            while (i1 <= FLIPCOINTIMES)
            {
                Random random1 = new Random();
                int flipcoin1 = random.Next(0, 2);
                Random random2 = new Random();
                int flipcoin2 = random2.Next(0, 2);
                Random random3 = new Random();
                int flicoin3 = random3.Next(0, 2);
                switch (flipcoin1, flipcoin2, flipcoin3)
                {
                    case (Head, Head, Head):
                        tripleCombination[i1] = "HHH";
                        hhh_counter++;
                        break;
                    case (Head, Head, TAIL):
                        tripleCombination[i1] = "HHT";
                        hht_counter++;
                        break;
                    case (Head, TAIL, TAIL):
                        tripleCombination[i1] = "HTT";
                        htt_counter++;
                        break;
                    case (Head, TAIL, Head):
                        tripleCombination[i1] = "HTH";
                        hth_counter++;
                        break;
                    case (TAIL, TAIL, TAIL):
                        tripleCombination[i1] = "TTT";
                        ttt_counter++;
                        break;
                    case (TAIL, Head, Head):
                        tripleCombination[i1] = "THH";
                        thh_counter++;
                        break;
                    case (TAIL, Head, TAIL):
                        tripleCombination[i1] = "THT";
                        hhh_counter++;
                        break;
                    default:
                        tripleCombination[i1] = "TTH";
                        tth_counter++;
                        break;


                }
                i1++;
            }
            for (int i2 = 1; i2 <= tripleCombination; i2++)
            {
                Console.WriteLine(tripleCombination[i2]);
            }
            Console.WriteLine();
            Console.WriteLine($"Persentage of HHH Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HHT Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HTT Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of HTH Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of TTT Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of THH Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of THT Single is {(hhh_counter * 100) / FLIPCOINTIMES}");
            Console.WriteLine($"Persentage of TTH Single is {(hhh_counter * 100) / FLIPCOINTIMES}");

            Console,ReadLine();
        }

    }
}
