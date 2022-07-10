using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_new_language_dot_net_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Biblioteka Math
             * 
            Console.WriteLine(Math.Abs(-500));
            Console.WriteLine(Math.Pow(5, -3));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Round(4.50));
            */

            /* Wypisywanie od środka stringa
             * 
            string zdanie = "Kocham Cie rybko";
            Console.WriteLine(zdanie.Substring(7, 3));
            */

            /*
             * podstawy WriteLine
            int num1, num2;
            num1 = 10;
            num2 = 5;

            Console.WriteLine(num1 + " + " + num2 + " =\" \n" + (num2+num1));
            */

            /* Przyjmowanie wartości
             * 
            Console.WriteLine("Jak masz na imie? ");

            string imie = Console.ReadLine();

            Console.WriteLine("Ile masz lat? ");

            int wiek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masz na imie: " + imie + "  i masz " + wiek + " lat");
            */

            /* Wpisywanie wartości do tablicy w pętli
             * int x = 10;

            int[] tab = new int[x];

            for(int i = 0; i < x; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(tab[i]);
            }*/

            /*Console.WriteLine("Jak masz na imie? ");

            string imie = Console.ReadLine();

            SayHi(imie);
            */
            /*Console.WriteLine("Jaką liczbę podnieść do kwadratu?: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Cube(number));
            */
            /*try 
            { 
            Console.WriteLine("Podaj liczbe: ");
            
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj do której potęgi: ");

            int powNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetPower(baseNum, powNum));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }*/



            Book book1 = new Book("Limes Inferior" , "Janusz Zajdel", 280);


            Console.ReadLine();


        }

        // Pierwsza metoda
        static void SayHi(string imie)
        {
            Console.WriteLine("Hi " + imie);
        }

        static int Cube(int num)
        {
            int result = num * num *num;
            
            return result;
        }
        
        static int GetPower(int baseNum, int powNum)
        {
            int x = baseNum;

            for (int i = 0; i < powNum; i++)
            {
                baseNum *= x;
            }

            return baseNum;
        }

    }
}
