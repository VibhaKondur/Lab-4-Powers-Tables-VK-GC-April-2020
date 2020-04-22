using System;
using System.Data;

namespace Lab_4_Powers_Tables_VK_GC_April_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runAgain = true;

            while (runAgain)
            {
            int number = 0;
            int i = 0;
            Console.WriteLine("Hello! Please enter an integer. ");
                number = int.Parse(Console.ReadLine());

                for (i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
                for (i = 1; i <= number; i++)
                {
                    Console.WriteLine(i * i);
                }
                for (i = 1; i <= number; i++)
                {
                    Console.WriteLine(i * i * i);
                }

                Console.WriteLine("Great job! Continue? y/n");
                string runAgainstring = Console.ReadLine();
                if (runAgainstring == "y")
                {
                    runAgain = true;
                }
                else
                {
                    break;
                }

            }

        }
        
    }
}
