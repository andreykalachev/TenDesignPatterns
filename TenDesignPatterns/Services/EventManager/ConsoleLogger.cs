using System;

namespace TenDesignPatterns.Services.EventManager
{
    public class ConsoleLogger : IObserver
    {
        public void Update(EventManager eventManager)
        {
            Console.WriteLine($"\n-----event: {eventManager.CurrentEventName}-----\n");
        }
    }
}