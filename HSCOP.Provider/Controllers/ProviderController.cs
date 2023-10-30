using Microsoft.AspNetCore.Mvc;

namespace HSCOP.Provider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProviderController : ControllerBase
    {
       
        private readonly ILogger<ProviderController> _logger;

        public ProviderController(ILogger<ProviderController> logger)
        {
            _logger = logger;
        }
    }
}