using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //The Strategy interface declares operations common to all supported
    public interface ISortingStrategy
    {
        List<string> PerFormSorting(object data);
    }
}
