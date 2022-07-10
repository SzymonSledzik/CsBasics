using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int request = r.Next(0, 11);
            byte hand = 11;

            Console.WriteLine("Guess a number from 0 to 10");

            while (request != hand)
            {
                
                hand = Convert.ToByte(Console.ReadLine());

                if (hand > request)
                {
                    Console.WriteLine("Number is too high! Try again...");
                }

                if (hand < request)
                {
                    Console.WriteLine("Number is too low! Try again...");
                }

                if (hand == request)
                {
                    Console.WriteLine("YOU WON!!!");
                }
            }
            Console.WriteLine("Thank you for playing, press any key to quit.");
            Console.ReadKey(true);



        }
    }
}
