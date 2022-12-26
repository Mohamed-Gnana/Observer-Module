using IObserver.Observer.Contract;
using System.Threading.Tasks;

namespace IObserver.Observer.Subject
{
    public interface ISubject<TSubject>
        where TSubject : Subject.Subject<TSubject>
    {
        void AddObserver(Observer.Observer<TSubject> observer);

        void RemoveObserver(Observer.Observer<TSubject> observer);

        void NotifyObservers(Contract.Contract contract);

        Task NotifyObserversAsync(Contract.Contract contract);

        void GetObserversFromAssembly();
    }
}
