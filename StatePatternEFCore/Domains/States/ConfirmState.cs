using StatePatternEFCore.Domains.Order;

namespace StatePatternEFCore.Domains.States
{
    public class ConfirmState : OrderState
    {
        public override OrderState Ship()
        {
            Console.WriteLine("Order Shipped");
            return new ShippedState();
        }
    }
}
