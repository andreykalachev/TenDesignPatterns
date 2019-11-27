using System;
using TenDesignPatterns.Models.Strategy;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Strategy

            var templatePatternTestStrategy = new TemplatePatternTestStrategy();
            var abstractFactoryPatternTestStrategy = new AbstractFactoryPatternTestStrategy();
            var patternTestStrategyContext = new PatternTestStrategyContext(abstractFactoryPatternTestStrategy);

            patternTestStrategyContext.TestStrategy();
            patternTestStrategyContext.SetStrategy(templatePatternTestStrategy);
            patternTestStrategyContext.TestStrategy();

            #endregion

            Console.ReadKey();
        }
    }
}