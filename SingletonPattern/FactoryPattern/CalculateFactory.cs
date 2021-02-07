using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class CalculateFactory
    {
        //Factory Logic implementation
       public ICalculate GetCalculation(string type)
        {
            ICalculate calculate = null;
            switch (type)
            {
                case "Add":
                    calculate = new Add();
                    break;
                case "Substract":
                    calculate = new Substract();
                    break;
                case "Divide":
                    calculate = new Divide();
                    break;
                default:
                    break;
            }
            return calculate;
        }
    }
}
