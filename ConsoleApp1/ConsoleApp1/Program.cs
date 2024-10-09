using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1, cislo2, vysledek, operace, anone;

            while (true)
            {
                Console.WriteLine("pokud chceš zastavit kalkulačku dej 1");
                Console.WriteLine("pokud chceš pokračovat zmáčkni 2");
                anone = int.Parse(Console.ReadLine());

                if (anone == 1) { break; }
                else if (anone == 2)
                {
                    Console.WriteLine("zadej číslo bro");
                    cislo1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("zadej druhé číslo bro");
                    cislo2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Chceš + (1) nebo - (2)");
                    Console.WriteLine("nebo");
                    Console.WriteLine("Chceš x (3) nebo : (4)");
                    operace = int.Parse(Console.ReadLine());

                    if (operace == 1)
                    {
                        vysledek = cislo1 + cislo2;
                        Console.WriteLine("výsledek je:");
                        Console.WriteLine(vysledek);
                    }
                    else if (operace == 2)
                    {
                        vysledek = cislo1 - cislo2;
                        Console.WriteLine("výsledek je:");
                        Console.WriteLine(vysledek);
                    }
                    else if (operace == 3)
                    {
                        vysledek = cislo1 * cislo2;
                        Console.WriteLine("výsledek je:");
                        Console.WriteLine(vysledek);
                    }
                    else if (operace == 4)
                    {
                        vysledek = cislo1 / cislo2;
                        Console.WriteLine("výsledek je:");
                        Console.WriteLine(vysledek);
                    }
                }

                
            }
        }
    }
}
