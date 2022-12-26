using IObserver.Observer.Contract;
using IObserver.Observer.Subject;

namespace IObserver.Console
{
    public class TicketStockService : Observer.Observer.Observer<OrderSubject>
    {
        public override void RecieceMessage(Contract message)
        {
            message.PrintMessage();
        }

        public override async Task RecieveMessageAsync(Contract message)
        {
            Thread.Sleep(1000);
            message.PrintMessage();
        }
    }
}
