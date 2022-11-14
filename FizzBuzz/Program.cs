using System;

namespace FizzBuzz
{
    public class Program
    {
        static string FizzBuzz(int x)
        {
            return (x % 5 == 0 && x % 3 == 0) ? "fizbuzz" : (x % 5 == 0) ? "buzz" : (x % 3 == 0) ? "fizz" : null;

            //if(x % 5 == 0 && x%3 == 0)
            //{
            //    return "fizbuzz";
            //}
            //else if(x % 5 == 0)
            //{
            //    return "buzz";
            //}
            //else if(x % 3 == 0)
            //{
            //    return "fizz";
            //}
            //else
            //{
            //    return null;
            
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(FizzBuzz(15));
            Console.WriteLine(FizzBuzz(10));
            Console.WriteLine(FizzBuzz(6));
            Console.WriteLine(FizzBuzz(7));
            

        }
    }
}
