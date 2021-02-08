using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args = null)
        {
            // Dictionary to maintain stratgies
            var strategyDictionary = new Dictionary<string, ISortingStrategy>();
            strategyDictionary.Add("Normal", new NormalStrategy());
            strategyDictionary.Add("Reverse", new ReverseStrategy());

            var stratedyObj = new object() as ISortingStrategy;
            var sortContext = new SortContext();
           
            Console.WriteLine("Type sorting type (Normal,Reverse) !!!");
            var input = Console.ReadLine();

            //Set strategy on runtime
            sortContext.setStrategy(strategyDictionary[input]);
            sortContext.DoSortingMachanism();

            Console.ReadLine();
            Console.Clear();
            Main();
        }
    }
}
