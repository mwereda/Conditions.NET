namespace Conditions
{
    public class ConditionResult<T>
    {    
        public T And
        {
            get;
        }

        internal bool Result
        {
            get; private set;
        }   

        private ConditionResult(bool result)
        {
            Result = result;            
        }
        
        internal static ConditionResult<T> Create(bool result)
        {
            return new ConditionResult<T>(result);
        }

        public static implicit operator bool(ConditionResult<T> conditionResult)
        {
            return conditionResult.Result;
        }
    }
}
