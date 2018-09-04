using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDemo
{
    class Program
    {
        // Goto
        static void LoopWithGoto()
        {
            start:
            Console.Write("Hej Fredrik! ");
            goto start;
        }

        // While
        private static void LoopWithWhile()
        {
            // TODO: Säg hej 10 gånger

            int räknare = 0;

            while (räknare < 10)
            {
                Console.WriteLine($"Hej {räknare}! ");
                räknare = räknare + 1;
            }

            //start:
            //if (!(räknare <= 10)) goto slut;
            //Console.WriteLine($"Hej {räknare}! ");
            //räknare = räknare + 1;
            //goto start;
            //slut:

            Console.Write("Klar...");
        }

        // Do While

        private static void LoopWithDoWhile()
        {
            // TODO: Säg hej 10 gånger

            int räknare = 1;

            do
            {
                Console.WriteLine($"Hej {räknare}! ");
                räknare = räknare + 1;
            } while (räknare <= 10);
        }

        // For

        private static void LoopWithFor()
        {
            // TODO: Säg hej 10 gånger

            for (int räknare = 0; räknare < 10; räknare++)
            {
                Console.WriteLine($"Hej {räknare}! ");
            }

        }

        // Foreach
        private static void LoopWithForEach()
        {
            int[] talen = new int[] { 1, 3, 5, 7, 11 };

            foreach (int tal in talen)
            {
                Console.WriteLine(tal);
            }

        }

        // Do/While in menu

        private static void MenuExample()
        {
            bool klar = false;

            do // Upprepa tills avsluta är satt
            {
                PrintMainMenu();
                string choice = GetChoice();
                klar = ProcessChoice(choice);
            } while (!klar);
   
        }

        private static bool ProcessChoice(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine("Gör nåt (Alternativ 1)");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Gör nåt annat (Alternativ 2)");
            }
            else if (choice == "X")
            {
                // Om X, Sätt avsluta till true
                return true;
                Console.WriteLine("Avsluta valt");
            }
            else
            {
                Console.WriteLine("Fel val!");
            }

            return false;
        }

        private static string GetChoice()
        {
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            return choice;
        }

        private static void PrintMainMenu()
        {
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("=========");
            Console.WriteLine("1) Gör nå't");
            Console.WriteLine("2) Gör nå't annat");
            Console.WriteLine("X) Avsluta");
        }

        static void Main(string[] args)
        {
            // LoopWithGoto();
            // LoopWithWhile();
            // LoopWithDoWhile();
            // LoopWithFor();

            // LoopWithForEach();

            // MenuExample();

            // LoopWithBreakAndContinue();

            NestedLoop();

        }

        private static void NestedLoop()
        {
            int[,] board = new int[9, 9]
            {
                { 1,0,0, 0,0,0, 0,0,0 },
                { 0,2,0, 0,0,0, 0,0,0 },
                { 0,0,3, 0,0,0, 0,0,0 },

                { 0,0,0, 4,0,0, 0,0,0 },
                { 0,0,0, 0,5,0, 0,0,0 },
                { 0,0,0, 0,0,6, 0,0,0 },

                { 0,0,0, 0,0,0, 7,0,0 },
                { 0,0,0, 0,0,0, 0,8,0 },
                { 0,0,0, 0,0,0, 0,0,9 }
            };

            Console.WriteLine("+---+---+---+---+---+---+---+---+---+");
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] != 0)
                    {
                        Console.Write($"| {board[row, col]} ");
                    }
                    else
                        Console.Write($"| _ ");
                }
                Console.WriteLine("|");
                Console.WriteLine("+---+---+---+---+---+---+---+---+---+");
            }
        }

        private static void LoopWithBreakAndContinue()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 3 == 0) continue;

                if (i == 7) break;
                
                Console.WriteLine(i);
            }
        }
    }
}
