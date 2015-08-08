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

        internal void ThrowsException<T>() where T : Exception, new()
        {
            ThrowsException(() => new T());
        }

        internal void ThrowsException<T>(Func<T> exceptionFactory) where T : Exception
        {
            this.exceptionToThrow = exceptionFactory();
        }

        public static implicit operator bool(CheckResult checkResult)
        {
            return checkResult.IsValid;
        }
    }
}
