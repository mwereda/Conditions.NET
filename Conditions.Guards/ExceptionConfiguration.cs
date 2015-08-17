using System;

namespace Conditions.Guards
{
    internal sealed class ExceptionConfiguration
    {
        private Exception exceptionToThrow;
        private bool exceptionOverriden;

        internal bool ExceptionOverriden
        {
            get { return this.exceptionOverriden; }
        }

        internal void Throw()
        {
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
            this.exceptionOverriden = true;
            this.exceptionToThrow = exceptionFactory();
        }
    }
}
