using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Hemory
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputContinue;
            do
            {
                Console.WriteLine("Please enter an integer to find its squared and cubed values.");

                int squaredNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Number" + "     " + "Squared" + "       " + "Cubed");
                Console.WriteLine("______" + "     " + "_______" + "       " + "_____");


                int count = 1;
                do
                {

                    Console.WriteLine(count + "             " + count * count + "            "+ count * count * count);
                    count = count + 1;

                } while (count <= squaredNumber);

                Console.WriteLine("Would you like to try another integer? y/n?");
                inputContinue = Console.ReadLine();
            } while (inputContinue == "y");
        }
    }
}



