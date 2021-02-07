using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Divide : ICalculate
    { 

        public void Calculate(double a, double b)
        {
            Console.WriteLine("a / b = {0}", a / b);
        }
    }
}
