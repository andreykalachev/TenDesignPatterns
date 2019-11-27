using System;
using TenDesignPatterns.Models.States;
using TenDesignPatterns.Models.Strategy;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Strategy

            //commented out to test state pattern

            //var templatePatternTestStrategy = new TemplatePatternTestStrategy();
            //var abstractFactoryPatternTestStrategy = new AbstractFactoryPatternTestStrategy();
            //var patternTestStrategyContext = new PatternTestStrategyContext(abstractFactoryPatternTestStrategy);

            //patternTestStrategyContext.TestStrategy();
            //patternTestStrategyContext.SetStrategy(templatePatternTestStrategy);
            //patternTestStrategyContext.TestStrategy();

            #endregion

            #region State


            State state = new VolvoLover();
            var stateContext = new StateContext(state);

            stateContext.BuySomeCars();
            stateContext.BuySomeTrucks();
            stateContext.PrintYourOpinion();

            #endregion

            Console.ReadKey();
        }
    }
}