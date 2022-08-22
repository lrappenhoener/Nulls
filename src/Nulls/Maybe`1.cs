using System;

namespace Nulls
{
    public struct Maybe<T>
    {
        private readonly T _value;

        public Maybe(T value)
        {
            _value = value;
            HasValue = true;
        }

        public T Value { get { if (!HasValue) throw new InvalidOperationException(); return _value; } }

        public bool HasValue { get; internal set; }
    }
}
