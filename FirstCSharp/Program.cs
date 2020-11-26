using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            newFun();
            nextFun();
            lastFun();
        }

        static void newFun()
        {
            Console.WriteLine("Print all values from 1-100");
            for(int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void nextFun()
        {
            Console.WriteLine("Divided by 3 & 5: ");
            for (int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        static void lastFun() 
        {
            Console.WriteLine("Divided by 3 & 5: but change to Fuzz and Buzz: ");
            for(int i=1;i<=100;i++)
            {                               
                string res=(i%3==0&&i%5==0)?"FizzBuzz":(i%5==0)?"Buzz":
                    (i%3==0)?"Fizz":i.ToString();
            Console.WriteLine(res);
            }        
        }
    }
}

