namespace Nulls
{
    public struct Maybe
    {
        public static Maybe<T> None<T>()
        {
            return new Maybe<T>();
        }

        public static Maybe<T> Some<T>(T value)
        {
            return new Maybe<T>(value);
        }
    }
}
