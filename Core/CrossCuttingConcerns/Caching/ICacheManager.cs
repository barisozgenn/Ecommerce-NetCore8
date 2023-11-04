using System;
namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        object Get(string key);
        void Add(string key, object data, int duration);//veri göndereceğiz nekadar süre cache te kalacak onu söyleyeceğiz

        bool IsAdded(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}

