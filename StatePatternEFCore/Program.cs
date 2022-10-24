using StatePatternEFCore.Domains.Order;

var order = new Order(1, DateTime.Now);
order.Confirm();
order.Ship();

Console.WriteLine(order.OrderState.GetType().Name);

Console.WriteLine("-------------------------------");

var order2 = new Order(2, DateTime.Now);
order2.Cancel();

Console.WriteLine(order2.OrderState.GetType().Name);
