using ObserverPattern.Enumerations;
using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace ObserverPattern.Classes
{
    public class GroupChat : ISubject
    {
        private readonly List<IObserver> _observers;
        public ActionEnum LastAction { get; private set; }
        public string LastObserverName { get; private set; }
        public string Name { get; set; }
        public GroupChat(string name)
        {
            Name = name;
            _observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            WriteDetails(observer, ActionEnum.Attached);
            Notify();
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);;
            WriteDetails(observer, ActionEnum.Detached);
            Notify();
        }

        public void AttachRange(List<IObserver> observers)
        {
            foreach (IObserver observer in observers)
            {
                Attach(observer);
            }
        }

        public void DetachRange(List<IObserver> observers)
        {
            foreach (IObserver observer in observers)
            {
                Detach(observer);
            }
        }

        public void Notify()
        {
            Console.WriteLine($"Subject - '{Name}': Notifying observers...\n");
            if(_observers.Count == 0)
            {
                Console.WriteLine($"Subject - '{Name}': There aren't observers.\n");
                return;
            }
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
            Console.WriteLine();
        }

        private void WriteDetails(IObserver observer, ActionEnum action)
        {
            LastAction = action;
            LastObserverName = (observer as GroupMember).Name;
            Console.WriteLine($"Subject - '{Name}': was '{LastAction.ToString()}' an observer named '{LastObserverName}'.");
        }
    }
}
