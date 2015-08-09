﻿using System;

namespace Conditions.Guards
{
    public sealed class ExceptionConfiguration
    {
        private Exception exceptionToThrow;

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
            this.exceptionToThrow = exceptionFactory();
        }
    }
}