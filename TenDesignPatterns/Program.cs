using System;
using TenDesignPatterns.Models.Strategy;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Strategy

            //commented out to test adapter pattern

            //var templatePatternTestStrategy = new TemplatePatternTestStrategy();
            //var abstractFactoryPatternTestStrategy = new AbstractFactoryPatternTestStrategy();
            //var patternTestStrategyContext = new PatternTestStrategyContext(abstractFactoryPatternTestStrategy);

            //patternTestStrategyContext.TestStrategy();
            //patternTestStrategyContext.SetStrategy(templatePatternTestStrategy);
            //patternTestStrategyContext.TestStrategy();

            #endregion

            #region Adapter

            var adapterPatternStrategyTest = new AdapterPatternStrategyTest();
            var patternTestStrategyContext = new PatternTestStrategyContext(adapterPatternStrategyTest);

            patternTestStrategyContext.TestStrategy();

            #endregion

            Console.ReadKey();
        }
    }
}