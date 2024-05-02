using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223117.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class mahasiswacontroller : ControllerBase
    {
        private readonly ILogger<mahasiswacontroller> _logger;

        public mahasiswacontroller(ILogger<mahasiswacontroller> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMahasiswa")]

        public IEnumerable<mahasiswa> Get()
        { return Enumerable.Empty<mahasiswa>();
        
        }
    }
}
