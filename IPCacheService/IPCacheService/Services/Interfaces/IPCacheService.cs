using IPCacheService.Models;

namespace IPCacheService.Services.Interfaces
{
    public interface ICacheService
    {
        IPDetails GetFromCache(string ipAddress);
        void AddToCache(string ipAddress, IPDetails details);
    }
}