using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_1.Interfaces
{
    interface Subject
    {
        public void registerObserver(Observe observer);
        public void removeObserver(Observe observer);
        public void notifyObservers();
    }
}
