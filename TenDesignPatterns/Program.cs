using System;
using TenDesignPatterns.Models;
using TenDesignPatterns.Models.Commands;
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

            //commented out to test command pattern

            //State state = new VolvoLover();
            //var stateContext = new StateContext(state);

            //stateContext.BuySomeCars();
            //stateContext.BuySomeTrucks();
            //stateContext.PrintYourOpinion();

            #endregion

            #region Command

            var goodClientCar = new MercedesCar();
            var averageClientCar = new VolvoCar();
            var badClientCar = new MercedesCar();

            Console.WriteLine($"good: {goodClientCar.Color}\t bad: {badClientCar.Color}\t average: {averageClientCar.Color}");

            var commandForGoodClients = new Paint(goodClientCar, new GoodPainter(), "Orange");
            var commandForBadClients = new Paint(badClientCar, new BadPainter(), "Blue");
            var commandForAverageClients = new PaintInGreen(averageClientCar);

            var invoker = new Invoker(commandForGoodClients, commandForBadClients, commandForAverageClients);
            invoker.PaintCars();

            Console.WriteLine($"\ngood: {goodClientCar.Color}\t bad: {badClientCar.Color}\t average: {averageClientCar.Color}");

            #endregion

            Console.ReadKey();
        }
    }
}