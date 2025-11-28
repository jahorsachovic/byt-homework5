// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        // Your code goes here... make sure to add this features:
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        //2. Creating the Observer
        //3. Registering the Observer with the Subject
        //4. Removing the Observer from the Subject
        //5. Observer will get a notification from the Subject using the following Method

        private String _userName;
        
        public String UserName
        {
            get => _userName;
            set
            {
                _userName = userName;
            }
        }

        private Dictionary<Subject, string> _subjects = new(); 
        
        public void AddSubject(Subject subject)
        {
            subject.RegisterObserver(this);
            _subjects.Add(subject, subject.GetAvailability());
        }

        public void Update(Subject subject, string availability)
        {
            _subjects.Add(subject, availability);
        }


        public void RemoveSubject(Subject subject)
        {
            subject.RemoveObserver(this);
            _subjects.Remove(subject);
        }
        
        
    }
}
