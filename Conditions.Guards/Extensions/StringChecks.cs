using System;

namespace Conditions.Guards.Extensions
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
                throw new ArgumentNullException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against string that is not GUID.
        /// </summary>        
        public static void IsGuid(this If<string> ifObject)
        {
            if (!ifObject.Value.IsGuid())
            {
                throw new ArgumentException("String is not valid GUID.", ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against string that is not valid email address.
        /// </summary>        
        public static void IsEmailAddress(this If<string> ifObject)
        {
            if (!ifObject.Value.IsEmailAddress())
            {
                throw new ArgumentException("String is not valid email address.", ifObject.ParamName);
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
                throw new ArgumentException(
                    string.Format("String doesn't have expected length ({0} chars)", expectedLength), ifObject.ParamName);
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
                throw new ArgumentException(
                    string.Format("String is too short. Expected length is {0} or longer.", minimalLength),
                    ifObject.ParamName);
            }
        }
    }
}
