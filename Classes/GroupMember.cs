using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Classes
{
    public class GroupMember : IObserver
    {
        private readonly ISubject _subject;
        public string Name { get; set; }
        public GroupMember(ISubject subject, string name)
        {
            _subject = subject;
            Name = name;
        }

        public void Update()
        {
            var groupChat = _subject as GroupChat;
            var operation = groupChat.LastAction.ToString();
            Console.WriteLine($"Observer - '{Name}': A {nameof(GroupMember)} was '{operation}' with the name '{groupChat.LastObserverName}'");
        }
    }
}
