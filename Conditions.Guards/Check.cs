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
    }
}
