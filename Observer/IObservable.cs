using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Observer
{
    public interface IObservable
    {
        string state {get;}
        List<IObserver> observers { get; set; }
        public void addObserver(IObserver observer);
        public void removeObserver(IObserver observer);
        public void notify();
    }
}
