namespace Conditions
{
    public class ConditionResult
    {    
        internal bool Result
        {
            get; private set;
        }   

        private ConditionResult(bool result)
        {
            Result = result;            
        }

        internal static ConditionResult Create(bool result)
        {
            return new ConditionResult(result);
        }

        public static implicit operator bool(ConditionResult conditionResult)
        {
            return conditionResult.Result;
        }
    }
}
