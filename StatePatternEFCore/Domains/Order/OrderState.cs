using StatePatternEFCore.Domains.States;

namespace StatePatternEFCore.Domains.Order
{
    public abstract class OrderState
    {
        public virtual bool CanCancel() => false;
        public virtual OrderState Cancel() => throw new InvalidOperationException();
        public virtual OrderState Confirm() => throw new InvalidOperationException();
        public virtual OrderState Ship() => throw new InvalidOperationException();
    }
}
