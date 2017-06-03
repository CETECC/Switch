using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Vingardium Leviosa");
            Console.WriteLine("2) Arestum Momentum");
            Console.WriteLine("3) Imobilus");
            Console.WriteLine("4) Alohomora");
            Console.WriteLine("5) Sectumsempra");
            Console.WriteLine("OUTRO) Sair");
            Console.WriteLine();

            bool repetir = true;

            while (repetir == true)
            {
                Console.Write("Escolha seu feitiço:");
                string entrada = Console.ReadLine();
                Console.WriteLine();

                int a = int.Parse(entrada);

                switch (a)
                {
                    case 1:
                        Console.WriteLine("***  Vingardium Leviosa ***");
                        break;
                    case 2:
                        Console.WriteLine("*** Arestum Momentum ***");
                        break;
                    case 3:
                        Console.WriteLine("*** Imobilus ***");
                        break;
                    case 4:
                        Console.WriteLine("*** Alohomora ***");
                        break;
                    case 5:
                        Console.WriteLine("*** Sectumsempra ***");
                        break;
                    default:
                        Console.WriteLine("ADEUS");
                        repetir = false;
                        break;
                }
            }
        }
    }
}
