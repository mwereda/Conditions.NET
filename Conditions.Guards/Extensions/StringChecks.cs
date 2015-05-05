using System;

namespace Conditions.Guards
{
    public static class StringChecks
    {
        public static void IsNotNullOrEmpty(this If<string> ifObject)
        {
            if (string.IsNullOrEmpty(ifObject.Value))
            {
                throw new ArgumentNullException(ifObject.ParamName);
            }
        }
    }
}
