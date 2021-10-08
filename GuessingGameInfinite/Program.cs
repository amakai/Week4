using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            
            bool loopActive = true;


            while(loopActive)

            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine("Palun sisesta number.");
                
                int  cpuRandom = Convert.ToInt32(Console.ReadLine());
                if (cpuRandom == 10)
                {
                    Console.WriteLine("Palju õnne! Oled Mängu võitnud!");
                    loopActive = false;

                }
                else
                {
                    Console.WriteLine("Vale number, proovi uuesti!");

                }
            }
        }
    }
}
