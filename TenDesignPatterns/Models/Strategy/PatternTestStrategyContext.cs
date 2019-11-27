using TenDesignPatterns.Models.Strategy.Interfaces;

namespace TenDesignPatterns.Models.Strategy
{
    public class PatternTestStrategyContext
    {
        private IStrategy _strategy;

        public PatternTestStrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void TestStrategy()
        {
            _strategy?.Execute();
        }
    }
}