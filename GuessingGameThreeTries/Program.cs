using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on 3 katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            // siis mängu võidab arvuti
            //*programm genereerib juhuslikku numbrit ühte korda.
            Random rnd = new Random();

            bool loopActive = true;
            int i = 0;



            while (i < 3)

            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine("Palun sisesta number.");

                int cpuRandom = Convert.ToInt32(Console.ReadLine());
                if (cpuRandom == 10)
                {
                    Console.WriteLine("Palju õnne! Oled Mängu võitnud!");
                    loopActive = false;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number! {3 - i} katset jäänud!");

                }
            }
        }
    }
}
