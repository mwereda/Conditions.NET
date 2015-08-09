using System;

namespace Conditions.Guards
{
    public static class Check
    {
        public static If<T> If<T>(T @object)
        {
            return new If<T>(@object);
        }

        public static If<T> If<T>(T @object, string paramName)
        {
            return new If<T>(@object, paramName);
        }

        public static Throwable<TException> AndThrowWhenFail<TException>() where TException : Exception, new()
        {
            return new Throwable<TException>(() => new TException());
        }

        public static Throwable<TException> AndThrowWhenFail<TException>(Func<TException> exceptionFactory) where TException : Exception
        {
            return new Throwable<TException>(exceptionFactory);
        }
    }
}
