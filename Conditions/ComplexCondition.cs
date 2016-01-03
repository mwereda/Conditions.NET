using System;

namespace Conditions
{
    public abstract class ComplexCondition<T>
    {
        protected readonly bool currentResult;
        private readonly T value;

        internal T Value
        {
            get
            {
                return this.value;
            }
        }

        protected ComplexCondition(T value, bool currentResult)
        {
            this.value = value;
            this.currentResult = currentResult;
        }

        internal abstract bool CalculateResult(Func<T, bool> calculate);
    }
}
