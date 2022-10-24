using StatePatternEFCore.Domains.Order;

namespace StatePatternEFCore.Domains.States
{
    public class InProcessState : OrderState
    {
        public override bool CanCancel() => true;
        public override OrderState Confirm()
        {
            Console.WriteLine("Order is confirmed");
            return new ConfirmState();
        }
        public override OrderState Cancel()
        {
            Console.WriteLine("Order cancelled");
            return new CancelledState();
        }
    }
}
