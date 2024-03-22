using System;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public string FizzBuzz(int number)
        {
            string result = "";
            if(number % 3 == 0)
            {
                result = "fizz";
            }
            if(number % 5 == 0)
            {
                result += "buzz";
            }
            return result;
        }
    }
}
