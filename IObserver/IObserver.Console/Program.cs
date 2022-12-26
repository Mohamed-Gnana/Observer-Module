

using IObserver.Console;
using IObserver.Observer.Contract;
using IObserver.Observer.Subject;

var orderService = new OrderSubject();
var service = new TicketStockService();
orderService.AddObserver(service);
orderService.MakeOrder();