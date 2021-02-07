using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args = null)
        {
            double num1, num2;
            Console.WriteLine("Enter first number ?");
            var result1 = double.TryParse(Console.ReadLine(), out num1);
            if (!result1)
            {
                Console.WriteLine("Enter a number !!");
                return;
            }

            Console.WriteLine("Enter second number ?");
            var result2 = double.TryParse(Console.ReadLine(), out num2);
            if (!result2)
            {
                Console.WriteLine("Enter a number !!");
                return;
            }

            Console.WriteLine("Choose calcualtion method (Add/Substract/Divide");
            // Base classs = derive class object
            // Return selected object to execute relevent task  (e.g. Add)
            var calObject = new CalculateFactory().GetCalculation(Console.ReadLine());
            calObject.Calculate(num1, num2);

            Console.ReadLine();
            Console.Clear();

            Main();
        }
    }
}
