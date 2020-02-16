using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.Observer
{
    public interface IObserver
    {
        IObservable observable { get; set; }
        public void update();
    }
}
