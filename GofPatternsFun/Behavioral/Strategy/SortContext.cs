using System;
using GofPatternsFun.Behavioral.Strategy.Strategies;

namespace GofPatternsFun.Behavioral.Strategy
{
    class SortContext
    {
        private SortStrategyBase _sortStrategy;

        public void SetSortedStrategy(SortStrategyBase sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort()
        {
            Console.WriteLine("Start sorting.");
            _sortStrategy.SorlList();
        }
    }
}
