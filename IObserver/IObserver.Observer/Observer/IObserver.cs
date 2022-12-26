using IObserver.Observer.Contract;
using IObserver.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IObserver.Observer.Observer
{
    public interface IObserver<TSubject, TContract>
    {
        Task RecieveMessageAsync(TContract message);
        void RecieceMessage(TContract message);
    }
}
