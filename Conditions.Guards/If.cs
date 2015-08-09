using System;

namespace Conditions.Guards
{
    public sealed class If<T>
    {
        private readonly T value;
        private readonly ExceptionConfiguration exceptionConfiguration;

        private string paramName;
        private bool exceptionOverriden;

        internal If(T value)
        {
            this.value = value;
            this.paramName = string.Empty;
            this.exceptionConfiguration = new ExceptionConfiguration();
        }

        internal If(T value, string paramName)
            : this(value)
        {
            this.paramName = paramName;
        }

        internal T Value
        {
            get { return this.value; }
        }

        internal string ParamName
        {
            get { return this.paramName; }
        }

        internal bool ExceptionOverriden
        {
            get { return this.exceptionOverriden; }
        }

        internal ExceptionConfiguration ExceptionConfiguration
        {
            get { return this.exceptionConfiguration; }
        }

        public If<T> AndThrowWhenFail<TException>() where TException : Exception, new()
        {
            return SetExceptionAndReturnIfObject(() => this.exceptionConfiguration.ThrowsException<TException>());
        }

        public If<T> AndThrowWhenFail<TException>(Func<TException> exceptionFactory) where TException : Exception
        {
            return SetExceptionAndReturnIfObject(() => this.exceptionConfiguration.ThrowsException(exceptionFactory));
        }

        private If<T> SetExceptionAndReturnIfObject(Action setException)
        {
            setException();
            this.exceptionOverriden = true;

            return this;
        }
    }
}
