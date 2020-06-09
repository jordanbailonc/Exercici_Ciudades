using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FASE 1");
            Console.WriteLine("Escriba Barcelona");
            string Barcelona = Console.ReadLine();
            Console.WriteLine("Escriba Madrid");
            string Madrid = Console.ReadLine();
            Console.WriteLine("Escriba Valencia");
            string Valencia = Console.ReadLine();
            Console.WriteLine("Escriba Malaga");
            string Malaga = Console.ReadLine();
            Console.WriteLine("Escriba Cadiz");
            string Cadiz = Console.ReadLine();
            Console.WriteLine("Escriba Santander");
            string Santander = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Barcelona);
            Console.WriteLine(Madrid);
            Console.WriteLine(Valencia);
            Console.WriteLine(Malaga);
            Console.WriteLine(Cadiz);
            Console.WriteLine(Santander);

            Console.WriteLine("FASE 2");
            string[] citiesArray;
            citiesArray = new string[6];
            
            citiesArray[0] = Barcelona;
            citiesArray[1] = Madrid;
            citiesArray[2] = Valencia;
            citiesArray[3] = Malaga;
            citiesArray[4] = Cadiz;
            citiesArray[5] = Santander;
            
            Console.WriteLine("----------------------------------");
            Array.Sort(citiesArray);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(citiesArray[i]);
            }
            Console.WriteLine("FASE 3");
            Array.Sort(citiesArray);
            for (int i = 0; i < citiesArray.Length; i++)
            {
                citiesArray[i] = citiesArray[i].Replace('a', '4');
                Console.WriteLine(citiesArray[i]);
            }
        }
    }
}
