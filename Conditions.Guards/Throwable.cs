using System;

namespace Conditions.Guards
{
    public sealed class Throwable<TException> where TException : Exception
    {
        private readonly Func<TException> exceptionFactory;

        internal Throwable(Func<TException> exceptionFactory)
        {
            Check.If(exceptionFactory).IsNotNull();

            this.exceptionFactory = exceptionFactory;
        }

        internal If<T> If<T>(T @object)
        {
            return If(@object, string.Empty);
        }

        internal If<T> If<T>(T @object, string paramName)
        {
            var ifObject = new If<T>(@object, paramName);
            ifObject.ExceptionConfiguration.ThrowsException(this.exceptionFactory);

            return ifObject;
        }
    }
}