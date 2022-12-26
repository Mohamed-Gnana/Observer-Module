using System.Collections.Generic;
using System.Threading.Tasks;

namespace IObserver.Observer.Subject
{
    public class Subject<TSubject> : ISubject<TSubject>
        where TSubject : Subject<TSubject>
    {
        private List<Observer.Observer<TSubject>> _observers = new List<Observer.Observer<TSubject>>();
        public List<Observer.Observer<TSubject>> Observers => _observers;
        public void AddObserver(Observer.Observer<TSubject> observer)
        {
            _observers.Add(observer);
        }

        public virtual void GetObserversFromAssembly()
        {
        }

        public void NotifyObservers(Contract.Contract contract)
        {
            foreach (var observer in Observers)
            {
                observer.RecieceMessage(contract);
            }
        }

        public async Task NotifyObserversAsync(Contract.Contract contract)
        {
            var tasks = new List<Task>();
            foreach (var observer in Observers)
            {
                tasks.Add(observer.RecieveMessageAsync(contract));
            }
            await Task.WhenAll(tasks);
        }

        public void RemoveObserver(Observer.Observer<TSubject> observer)
        {
            _observers.Remove(observer);
        }
    }
}
