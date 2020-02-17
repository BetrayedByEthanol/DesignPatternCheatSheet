using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Observer
{
    public class ObserverExample
    {
        public void test()
        {
            ObservableObject observable = new ObservableObject();
            AnObserverType anObserver = new AnObserverType(observable);
            observable.addObserver(anObserver);

            AnObserverType anotherObserver = new AnObserverType(observable);
            observable.addObserver(anotherObserver);
        }
    }
}
