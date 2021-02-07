using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args = null)
        {
            var stratedyObj = new object() as ISortingStrategy;
            var sortContext = new SortContext();
            Console.WriteLine("Type sorting type (Normal,Reverse) !!!");
            var input = Console.ReadLine();
            if (input == "Normal")
                stratedyObj  = new NormalStrategy();
            if (input == "Reverse")
                stratedyObj = new ReverseStrategy();

            sortContext.setStrategy(stratedyObj);
            sortContext.DoSortingMachanism();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
    }
}
