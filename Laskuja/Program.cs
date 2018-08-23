using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskuja
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 4;

            numero += 1;
            numero -= 3;
            numero *= 5;

            Console.WriteLine(numero);

           
            int ika;
            int pisteet;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.WriteLine("Anna ikäsi");
                string rivi = Console.ReadLine();

                if (Int32.TryParse(rivi, out ika))
                {
                    //Pisteen saa viiden vuoden välein  
                    pisteet = 5 - (ika % 5);
                    Console.WriteLine("seuraavaan pisteeseesi on: " + pisteet + " vuotta");
                    isNumber = true;
                }
                else
                    Console.WriteLine("String could not be parsed.");
                Console.WriteLine("Koita uudelleen!.");
            }
        }
    }
}
