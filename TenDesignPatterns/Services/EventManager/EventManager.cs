using System.Collections.Generic;

namespace TenDesignPatterns.Services.EventManager
{
    public class EventManager
    {
        public string CurrentEventName { get; set; }

        private List<IObserver> _observers;

        public EventManager()
        {
            _observers = new List<IObserver>();;
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Notify(string currentEventName)
        {
            CurrentEventName = currentEventName;
            Notify();
        }
    }
}