namespace Conditions
{
    public abstract class ComplexCondition<T>
    {
        private readonly T value;
        private readonly bool currentResult;

        internal T Value
        {
            get
            {
                return this.value;
            }
        }

        internal bool CurrentResult
        {
            get
            {
                return this.currentResult;
            }
        }

        protected ComplexCondition(T value, bool currentResult)
        {
            this.value = value;
            this.currentResult = currentResult;
        }

        internal abstract bool CalculateResult(bool externalResult);
    }
}
