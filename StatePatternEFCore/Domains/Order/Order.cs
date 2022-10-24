using StatePatternEFCore.Domains.States;

namespace StatePatternEFCore.Domains.Order
{
    public class Order
    {
        public Order(int id, DateTime dateTime)
        {
            Id = id;
            DateTime = dateTime;
            OrderState = new InProcessState();
        }

        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public OrderState OrderState { get; set; }

        public void Cancel()
        {
            if (OrderState.CanCancel())
            {
                OrderState = OrderState.Cancel();
            }
        }

        public void Confirm()
        {
            OrderState = OrderState.Confirm();
        }

        public void Ship()
        {
            OrderState = OrderState.Ship();
        }
    }
}
