namespace Conditions
{
    public sealed class ConditionResult<T>
    {
        private readonly And<T> andCondition;

        public And<T> And
        {
            get
            {
                return this.andCondition;
            }
        }

        internal bool Result
        {
            get; private set;
        }   

        private ConditionResult(bool result, T value)
        {
            Result = result;
            this.andCondition = new And<T>(value, result); 
        }
        
        internal static ConditionResult<T> Create(bool result, T value)
        {
            return new ConditionResult<T>(result, value);
        }

        public static implicit operator bool(ConditionResult<T> conditionResult)
        {
            return conditionResult.Result;
        }
    }    
}
