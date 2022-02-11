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

            Random rand = new Random();
            int flipcoin = random.Next(0, 2);
            if (flipcoin == Head)
            {
                Console.WriteLine("HEAD");
            }
            else
            {
                Console.WriteLine("TAIL");
            }

            Console.ReadLine();
        }

    }
}

