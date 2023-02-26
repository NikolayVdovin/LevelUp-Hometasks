using System;

namespace Lesson4
{
    internal class SimpleGenericCache <T>
    {
        private readonly Dictionary<string, CachedValue<T>> _cache = new();
        internal void Store(string key, T value, int timeout = 30)
        {
            var CachedValue = new CachedValue<T>
            {
                CreationTime= DateTime.Now,
                Value = value,  
                Timeout = timeout   

            };

            _cache[key] = CachedValue;
        }

        internal CachedValue<T> Fetch(string key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                var timeHasPassed = value.CreationTime + TimeSpan.FromSeconds(value.Timeout);
                if (timeHasPassed >= DateTime.Now)
                { 
                    return value;
                }
                else
                {
                    _cache.Remove(key);
                }                          
            }
            return default;
        }
    }
}
