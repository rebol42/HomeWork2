using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var rand = RandomValue();

            CheckRandomValue(rand);
 
        }
        private static int getValue()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int value))
                {
                    Console.WriteLine("Podana Wartość jest nieprawidłowa, spróbuj ponownie");
                    continue;
                }

                return value;
            }
        }

        private static int RandomValue()
        {
            var random = new Random();

            return random.Next(100);
            
        }

        private static void CheckRandomValue(int randomValue)
        {
            int count = 1;

            while (true)
            {

                Console.WriteLine("Zgadnij liczbę losową");
                var userValue = getValue();

                if (randomValue > userValue)
                {
                    Console.WriteLine("Podana Wartość za mała, spróbuj ponownie!");
                    count++;
                    continue;

                }
                else if (randomValue < userValue)
                {
                    Console.WriteLine("Podana Wartość za duża, spróbuj ponownie!");
                    count++;
                    continue;

                }
                else if (randomValue == userValue)
                {
                    Console.WriteLine("Odgadłeś liczbę po {0} razach", count);
                    Console.ReadLine();
                    break;
                }
            }


             
            
           
        }
    }
}
