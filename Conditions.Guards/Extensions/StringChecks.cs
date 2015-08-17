using System;

// ReSharper disable once CheckNamespace
namespace Conditions.Guards
{
    public static class StringChecks
    {
        /// <summary>
        /// Guards against null or empty string.
        /// </summary>        
        public static void IsNotNullOrEmpty(this If<string> ifObject)
        {
            if (string.IsNullOrEmpty(ifObject.Value))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentNullException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against string that is not GUID.
        /// </summary>        
        public static void IsGuid(this If<string> ifObject)
        {
            if (!ifObject.Value.IsGuid())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException("String is not valid GUID.", ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against string that is not valid email address.
        /// </summary>        
        public static void IsEmailAddress(this If<string> ifObject)
        {
            if (!ifObject.Value.IsEmailAddress())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException("String is not valid email address.", ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against string that's length is not expected.
        /// <param name="expectedLength">Expected length.</param>
        /// </summary>        
        public static void HasLength(this If<string> ifObject, int expectedLength)
        {
            if (!ifObject.Value.HasLength(expectedLength))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(
                    string.Format("String doesn't have expected length ({0} chars)", expectedLength), ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against string that's length is shorter than given length.
        /// </summary>       
        /// <param name="minimalLength">Minimal acceptable length.</param>
        public static void HasLengthAtLeast(this If<string> ifObject, int minimalLength)
        {
            if (!ifObject.Value.HasLengthAtLeast(minimalLength))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(
                        string.Format("String is too short. Expected length is {0} or longer.", minimalLength),
                        ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against string that doesn't match given pattern.
        /// </summary>
        /// <param name="pattern">Pattern that string should match to.</param>
        public static void Matches(this If<string> ifObject, string pattern)
        {
            if (!ifObject.Value.Matches(pattern))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(
                    string.Format(
                        "Given string doesn't match pattern. String: {0}{1}Pattern: {2}",
                        ifObject.Value,
                        Environment.NewLine,
                        pattern),
                    ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }
    }
}
