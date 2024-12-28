using Microsoft.AspNetCore.Mvc;
using IPCacheService.Services.Interfaces;
using IPCacheService.Models;

namespace IPCacheService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CacheController : ControllerBase
    {
        private readonly ICacheService _cacheService;

        public CacheController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet("{ipAddress}")]
        public IActionResult GetCachedDetails(string ipAddress)
        {
            var details = _cacheService.GetFromCache(ipAddress);
            if (details == null)
                return NotFound("IP address not found in cache.");
            return Ok(details);
        }

        [HttpPost]
        public IActionResult AddToCache([FromBody] CacheEntry entry)
        {
            _cacheService.AddToCache(entry.IPAddress, entry.Details);
            return Ok("IP address details added to cache.");
        }
    }
}
