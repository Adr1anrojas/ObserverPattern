using System.Collections.Generic;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        public void Attach(IObserver observer);
        void AttachRange(List<IObserver> observers);
        public void Detach(IObserver observer);
        public void DetachRange(List<IObserver> observers);
        public void Notify();
    }
}
