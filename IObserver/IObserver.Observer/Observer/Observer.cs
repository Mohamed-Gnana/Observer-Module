using IObserver.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObserver.Observer.Observer
{
    public abstract class Observer<TSubject> : IObserver<TSubject, Contract.Contract>
        where TSubject : Subject.Subject<TSubject>
    {
        public abstract void RecieceMessage(Contract.Contract message);

        public abstract Task RecieveMessageAsync(Contract.Contract message);
    }
}
