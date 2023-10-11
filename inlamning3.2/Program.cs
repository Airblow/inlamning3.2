using System;
using System.Collections.Concurrent;

namespace inlamning3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            Console.WriteLine("Svara antingen j för Ja eller n för Nej");
            string gym = (Console.ReadLine()).ToLower();

            Console.WriteLine("Hur gammal är du?");
            short age = short.Parse(Console.ReadLine());

            if (gym == "j" && age < 22)
                Console.WriteLine("Vi vill gärna anställa dig!");
            else
                Console.WriteLine("Vi letar tyvär efter annan personal just nu.");

            Console.ReadKey();
            

        }

    }

}
