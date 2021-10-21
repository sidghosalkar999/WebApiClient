using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    public class CalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Division(int a, int b)
        {
            return a % b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
