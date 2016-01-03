using System;

namespace Conditions
{
    public sealed class Or<T> : ComplexCondition<T>
    {
        internal Or(T value, bool currentResult) : base(value, currentResult)
        {
        }

        internal override bool CalculateResult(Func<T, bool> calculate)
        {
            bool externalResult = calculate(Value);

            return this.currentResult || externalResult;
        }
    }
}
