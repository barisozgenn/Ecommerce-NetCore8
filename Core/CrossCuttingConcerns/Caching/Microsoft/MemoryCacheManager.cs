using System;
using System.Text.RegularExpressions;
using Core.Utilities.IoC;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        private IMemoryCache _memoryCache;

        public MemoryCacheManager()
        {
            _memoryCache = ServiceTool.ServiceProvider.GetService<IMemoryCache>();//bunu oluşturduğumuz service tooldan implement edelim
        }

        public void Add(string key, object data, int duration)
        {
            _memoryCache.Set(key: key, value: data, absoluteExpirationRelativeToNow: TimeSpan.FromMinutes(duration));
        }

        public T Get<T>(string key)
        {
            return _memoryCache.Get<T>(key: key);
        }

        public object Get(string key)
        {
            return _memoryCache.Get(key: key);
        }

        public bool IsAdded(string key)
        {
            return _memoryCache.TryGetValue(key: key, out _);//alt çizgi nugetin teknolojisinden geliyor
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key:key);
        }

        public void RemoveByPattern(string pattern)
        {
            var cacheEntriesCollectionDefinition = typeof(MemoryCache).GetProperty("EntriesCollection", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            var cacheEntriescollection = cacheEntriesCollectionDefinition.GetValue(_memoryCache) as dynamic;

            List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheItem in cacheEntriescollection)
            {
                ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);

                cacheCollectionValues.Add(cacheItemValue);
            }

            var regex = new Regex(pattern: pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString())).Select(d => d.Key).ToList();

            foreach (var key in keysToRemove)
            {
                _memoryCache.Remove(key: key);
            }
        }
    }
}

