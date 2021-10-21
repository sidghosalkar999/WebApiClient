using System;
using System.Net.Http;

namespace WebApiClient
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            CalculatorService calc = new CalculatorService();
            Console.WriteLine($"Addition :{calc.Add(4, 4)}");
            Console.WriteLine($"Substraction :{calc.Substract(4, 4)}");
            Console.WriteLine($"Multiplication :{calc.Multiply(4, 4)}");
            Console.WriteLine($"Division :{calc.Division(4, 4)}");

            Console.ReadLine();
        }
    }
}
