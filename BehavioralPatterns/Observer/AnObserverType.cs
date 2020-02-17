using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Observer
{
    public class AnObserverType : IObserver
    {
        public IObservable observable { get; set; }
        public AnObserverType(IObservable observable)
        {
            this.observable = observable;
        }


        public void update()
        {
            Console.WriteLine("got an update " + observable.state);
        }
    }
}
