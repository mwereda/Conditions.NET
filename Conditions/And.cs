namespace Conditions
{
    public sealed class And<T>
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

        internal And(T value, bool currentResult)
        {
            this.value = value;
            this.currentResult = currentResult;
        }       
    }
}
