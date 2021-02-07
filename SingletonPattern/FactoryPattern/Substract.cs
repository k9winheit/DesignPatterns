using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Substract : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a - b = {0}", a - b);
        }
    }
}
