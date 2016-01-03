using System;

namespace Conditions
{
    public sealed class And<T> : ComplexCondition<T>
    {
        internal And(T value, bool currentResult) : base(value, currentResult)
        {
        }

        internal override bool CalculateResult(Func<T, bool> calculate)
        {
            bool externalResult = calculate(Value);

            return this.currentResult && externalResult;
        }
    }
}
