namespace Conditions.Guards
{
    public sealed class If<T>
    {
        private readonly T value;
        private string paramName;

        internal If(T value)
        {
            this.value = value;
            this.paramName = string.Empty;
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
    }
}
