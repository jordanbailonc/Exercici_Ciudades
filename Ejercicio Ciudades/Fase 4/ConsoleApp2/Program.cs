using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
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


            string[] citiesArray;
            citiesArray = new string[6];

            citiesArray[0] = Barcelona;
            citiesArray[1] = Madrid;
            citiesArray[2] = Valencia;
            citiesArray[3] = Malaga;
            citiesArray[4] = Cadiz;
            citiesArray[5] = Santander;

            Console.WriteLine("FASE 4");
            char espacio = ' ';
            string comillas = "";
            for (int i = 0; i < citiesArray.Length; i++)
            {
                char[] letters = new char[citiesArray[i].Length];
                for (int j = 0; j < citiesArray[i].Length; j++)
                {
                    letters[j] = citiesArray[i][j];
                    char citiesAhead = espacio;
                    espacio = letters[j];
                }
                string reves = espacio + comillas;
                Console.WriteLine("La ciudad introducida es " + citiesArray[i]);
                for (int k = citiesArray[i].Length - 2; k >= 0; k--)
                {
                    string citiesAhead = reves;
                    Console.WriteLine(citiesAhead);
                    reves = citiesAhead + letters[k];


                }
                Console.WriteLine(reves);
            }
        }
    }
}
