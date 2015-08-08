using System;

namespace Conditions.Guards
{
    public sealed class CheckResult
    {
        private Exception exceptionToThrow;

        public bool IsValid
        {
            get; private set;
        }

        internal CheckResult(bool isValid)
        {
            IsValid = isValid;
        }

        internal void Throw()
        {
            IsValid = false;
            if (exceptionToThrow.IsNotNull())
            {
                throw exceptionToThrow;
            }
            else
            {
                throw new InvalidOperationException("exceptionToThrow is not configured.");
            }
        }

        internal void ThrowsException<T>(string message = "", string paramName = "") where T : Exception, new()
        {            
        }

        internal void ThrowsException<T>(Func<T> exceptionFactory) where T : Exception
        {
            this.exceptionToThrow = exceptionFactory();
        }
    }
}
