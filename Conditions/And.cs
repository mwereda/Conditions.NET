namespace Conditions
{
    public sealed class And<T> : ComplexCondition<T>
    {
        internal And(T value, bool currentResult) : base(value, currentResult)
        {
        }

        internal override bool CalculateResult(bool externalResult)
        {
            return CurrentResult && externalResult;
        }
    }
}
