using System;


namespace Lesson4
{
    internal record CachedValue<T>
    {
        public T Value { get; init; }
        public DateTime CreationTime { get; init; }
        public int Timeout { get; init; }
    } 
}
