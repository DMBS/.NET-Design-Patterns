using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    /// <summary>
    /// Subject has some important states and notify observers about his changes
    /// </summary>
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// Subject state
        /// </summary>
        public int State { get; set; } = -0;

        // Attach new observer
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        // Detach current observer
        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer.");
            this._observers.Remove(observer);
        }

        // Notify all observers
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Subject logic. Run method every time when something important is about to happen 
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
