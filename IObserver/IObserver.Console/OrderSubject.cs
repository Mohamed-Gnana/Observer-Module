using IObserver.Observer.Subject;

namespace IObserver.Console
{
    public class OrderSubject: Subject<OrderSubject>
    {
        public void MakeOrder()
        {
            System.Console.WriteLine("Order...........");
            NotifyObservers(new TicketOrderContract
            {
                OrderedTickets = 3,
                OrderId = 3
            });
        }

    }
}
