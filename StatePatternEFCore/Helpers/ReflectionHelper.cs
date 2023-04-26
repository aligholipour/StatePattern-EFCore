using StatePatternEFCore.Domains.Order;

namespace StatePatternEFCore.Helpers
{
    public static class ReflectionHelper
    {
        public static Type[] FindOrderStateSubclasses()
        {
            var assembly = typeof(OrderState).Assembly;
            var types = assembly.GetTypes();
            return types.Where(t => t.IsSubclassOf(typeof(OrderState))).ToArray();
        }
    }
}
