using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SortContext
    {
        //Strategy interface;
        private ISortingStrategy _sortingStrategy;
        public SortContext()  { }

        //Use to change Strategy on runtime
        public void setStrategy(ISortingStrategy sortingStrategy)
        {
            this._sortingStrategy = sortingStrategy;
        }

        public void DoSortingMachanism()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = _sortingStrategy.PerFormSorting(new List<string> { "b", "a", "c", "e", "d" });
            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
