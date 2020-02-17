using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Observer
{
    public class ObservableObject : IObservable
    {
        public string state { get { return state; } private set { state = value; notify(); } }
        public List<IObserver> observers { get; set; }

        public ObservableObject()
        {
            observers = new List<IObserver>();
        }

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notify()
        {
            foreach (IObserver observer in observers) observer.update();
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

    }
}
