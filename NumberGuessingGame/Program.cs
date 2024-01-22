using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int right = 5;
            Random r = new Random();
            int x = r.Next(1, 10);
            repeat:
            if (right > 0)
            {
                Console.WriteLine("You have {0} rights.", right);
                Console.WriteLine("Enter numbers between 1 and 10: ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi > 0 && sayi <= 10) { 
                    if (sayi != x)
                    {
                        Console.WriteLine("Wrong Guess");
                        right--;
                        goto repeat;
                    }
                    else if (sayi == x)
                    {
                        Console.WriteLine("Right Guess");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter numbers between 1 and 10. (including 1 and 10)");
                    goto repeat;
                }
            }
            else if (right == 0)
            {
                Console.WriteLine("You have no rights anymore");
            }
        }
    }
}
