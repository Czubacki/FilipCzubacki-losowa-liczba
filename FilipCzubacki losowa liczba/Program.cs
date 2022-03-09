using System;

namespace FilipCzubackiLiczba
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int zgadnij;
            int liczba;
            int zgadles;

            while (playAgain)
            {
                zgadnij = 0;
                zgadles = 0;
                liczba = random.Next(min, max + 1);

                while (zgadnij != liczba)
                {
                    Console.WriteLine("Zgadnij liczbe " + min + " - " + max + " : ");
                    zgadnij = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Zgadnij: " + zgadnij);

                    if (zgadnij > liczba)
                    {
                        Console.WriteLine(zgadnij + " za wysoka");
                    }
                    else if (zgadnij < liczba)
                    {
                        Console.WriteLine(zgadnij + " za niska");
                    }
                    zgadles++;
                }
                Console.WriteLine("Liczba: " + liczba);
                Console.WriteLine("Udalo ci sie");

            }
        }
    }
}