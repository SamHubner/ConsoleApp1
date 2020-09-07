using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string s1;
            int x;
            Console.WriteLine("Hello World!");

            Console.WriteLine("enter a number");

            s1 = Console.ReadLine();

            num = Convert.ToInt32(s1);

            if (num > 255)
            {
                Console.WriteLine("number is too high");
            } else
            {
                x = (num % 16);
                if (x = 10)
                { }
            }
            
        
        }
    }
}
