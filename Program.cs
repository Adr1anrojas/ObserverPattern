using ObserverPattern.Classes;
using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Subject creation
            ISubject subjectOne = new GroupChat("Group Chat #1");
            ISubject subjectTwo = new GroupChat("Group Chat #2");

            // Observer creation
            List<IObserver> observersSubjectOne = DummyData.GetObservers(subjectOne);
            List<IObserver> observersSubjectTwo = DummyData.GetObservers(subjectTwo);

            //Subject one
            subjectOne.AttachRange(observersSubjectOne);
            subjectOne.DetachRange(observersSubjectOne);
            
            //Subject two
            subjectTwo.AttachRange(observersSubjectTwo);
            subjectTwo.DetachRange(observersSubjectTwo);
        }
    }
}
