using IObserver.Observer.Contract;

namespace IObserver.Console
{
    public class TicketOrderContract: Contract
    {
        public int OrderedTickets { get; set; }
        public int OrderId { get; set; }

        public override void PrintMessage()
        {
            System.Console.WriteLine(OrderedTickets);
        }
    }
}
