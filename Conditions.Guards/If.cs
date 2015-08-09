namespace Conditions.Guards
{
    public sealed class If<T>
    {
        private readonly T value;
        private readonly ExceptionConfiguration exceptionConfiguration;
        private readonly string paramName;

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

        internal ExceptionConfiguration ExceptionConfiguration
        {
            get { return this.exceptionConfiguration; }
        }        
    }
}
