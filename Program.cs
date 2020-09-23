using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Detta är min lilla kalkylator. Den är byggd för att träna lite metoder");

            string userChoice = "";

            while (userChoice != "5")
            {
                ShowMenu();
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddNumbers();
                        break;
                    case "2":
                        SubtractNumbers();
                        break;
                    case "3":
                        DivideNumbers();
                        break;
                    case "4":
                        MultiplyNumbers();
                        break;
                    case "5":
                        break;
                }
            }
        }

        private static void MultiplyNumbers()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Summan av dina tal är {tal1 * tal2}");
        }

        private static void DivideNumbers()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Summan av dina tal är {tal1 / tal2}");
        }

        private static void SubtractNumbers()
        {
            Console.WriteLine("Skriv in två tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Summan av dina tal är {tal1 - tal2}");
        }

        private static void AddNumbers()
        {
            Console.WriteLine("Skriv in två tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Summan av dina tal är {tal1 + tal2}");
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Välj ett räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplikation");
        }
    }
}
