namespace Conditions
{
    public sealed class Or<T> : ComplexCondition<T>
    {
        internal Or(T value, bool currentResult) : base(value, currentResult)
        {
        }

        internal override bool CalculateResult(bool externalResult)
        {
            return CurrentResult || externalResult;
        }
    }
}
