using System;

namespace Conditions.Guards
{
    public static class Check
    {
        private const string ObsoleteMessage = "Please use AndThrowThisWhenFails method.";

        public static If<T> If<T>(T @object)
        {
            return new If<T>(@object);
        }

        public static If<T> If<T>(T @object, string paramName)
        {
            return new If<T>(@object, paramName);
        }

        [Obsolete(ObsoleteMessage)]
        public static Throwable<TException> AndThrowThisWhenFail<TException>() where TException : Exception, new()
        {
            return AndThrowThisWhenFails<TException>();
        }

        public static Throwable<TException> AndThrowThisWhenFails<TException>() where TException : Exception, new()
        {
            return new Throwable<TException>(() => new TException());
        }

        [Obsolete(ObsoleteMessage)]
        public static Throwable<TException> AndThrowThisWhenFail<TException>(Func<TException> exceptionFactory) where TException : Exception
        {
            return AndThrowThisWhenFails(exceptionFactory);
        }

        public static Throwable<TException> AndThrowThisWhenFails<TException>(Func<TException> exceptionFactory) where TException : Exception
        {
            return new Throwable<TException>(exceptionFactory);
        }
    }
}
