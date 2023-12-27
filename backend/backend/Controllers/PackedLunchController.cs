using backend.Models;
using backend.Services.PackedLunch;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PackedLunchController : ControllerBase
    {
        private readonly ILogger<PackedLunchController> _logger;
        private readonly IPackedLunchService service;

        public PackedLunchController(ILogger<PackedLunchController> logger, IPackedLunchService service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet(Name = "GetPackedLunchs")]
        public IEnumerable<PackedLunchEntity> GetPackedLunchs()
        {
            return service.GetPackedLunchs();
        }
    }
}
