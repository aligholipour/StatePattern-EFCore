using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StatePatternEFCore.Domains.Order;

namespace StatePatternEFCore.Data
{
    public class StateConverter : ValueConverter<OrderState, string>
    {
        private static Dictionary<string, Type> _stateTypeMap;

        public StateConverter(IEnumerable<Type> stateTypes) : base(
            v => Serialize(v),
            v => Deserialize(v))
        {
            _stateTypeMap = stateTypes.ToDictionary(
               t => t.Name,
               t => t);
        }

        private static string Serialize(OrderState state)
        {
            if (state == null) return null;
            return state.GetType().Name;
        }

        private static OrderState Deserialize(string value)
        {
            if (value == null) return null;

            return !_stateTypeMap.TryGetValue(value, out Type stateType)
                ? throw new ArgumentException($"Unknown state type '{value}'")
                : Activator.CreateInstance(stateType) as OrderState;
        }
    }
}
