using System;
using System.Data;

namespace Lab_4_Powers_Tables_VK_GC_April_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runAgain = true;
            //bool Valid = true;
            //int Number;

            while (runAgain)
            {
                double i = 0;
                double total = 0;

                Console.WriteLine("Hello! Please enter an integer. ");
                total = int.Parse(Console.ReadLine());

                //while (Valid == true)
                //{
                    //string Input = Console.ReadLine();

                    //if (int.TryParse(Input, out Number))
                   //{
                        //Valid = true;
                    //}
                   //else
                    //{
                        //Console.WriteLine("Not an integer, please try again.");
                    //}
                //}

                Console.WriteLine("Number");
                for (i = 1; i <= total; i++)
                {

                    Console.WriteLine(i);
                }

                Console.WriteLine("Squared");
                for (i = 1; i <= total; i++)
                {

                    Console.WriteLine(i * i);
                }

                Console.WriteLine("Cubed");
                for (i = 1; i <= total; i++)
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

        
