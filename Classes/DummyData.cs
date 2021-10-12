using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern.Classes
{
    public static class DummyData
    {
        public static List<IObserver> GetObservers(ISubject subject)
        {
            var observers = new List<IObserver>()
            {
                new GroupMember(subject, "Member #1"),
                new GroupMember(subject, "Member #2"),
                new GroupMember(subject, "Member #3"),
                new GroupMember(subject, "Member #4"),
                new GroupMember(subject, "Member #5")
            };
            return observers;
        }
    }
}
