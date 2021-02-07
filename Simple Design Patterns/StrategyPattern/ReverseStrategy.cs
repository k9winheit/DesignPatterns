using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class ReverseStrategy : ISortingStrategy
    {
        public List<string> PerFormSorting(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
