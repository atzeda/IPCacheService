using IPCacheService.Models;
using IPCacheService.Services.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace IPCacheService.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IPDetails GetFromCache(string ipAddress)
        {
            _cache.TryGetValue(ipAddress, out IPDetails details);
            return details;
        }

        public void AddToCache(string ipAddress, IPDetails details)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
            };
            _cache.Set(ipAddress, details, cacheEntryOptions);
        }
    }
}
