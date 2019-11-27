using TenDesignPatterns.Models.Strategy.Interfaces;
using static TenDesignPatterns.Experiments;

namespace TenDesignPatterns.Models.Strategy
{
    public class TemplatePatternTestStrategy : IStrategy
    {
        public void Execute()
        {
            TestDeliveryTemplate();
        }
    }
}