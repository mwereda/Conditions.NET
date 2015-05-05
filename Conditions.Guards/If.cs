namespace Conditions.Guards
{
    public class If<T>
    {
        private readonly T value;
        private string paramName;

        internal If(T value)
        {
            this.value = value;
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
