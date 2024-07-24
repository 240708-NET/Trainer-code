using Microsoft.AspNetCore.Mvc;

namespace MyAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuckController : ControllerBase
    {
        // Fields
        private readonly ILogger<DuckController> _logger;

        // Constructor
        public DuckController(ILogger<DuckController> logger)
        {
            _logger = logger;
        }

        // Methods
        [HttpGet]
        public int GetGreeting()
        {
            return 5555;
        }

        [HttpPost]
        public void CreateDuck()
        {
            
        }

        [HttpPut]
        public string UpdateDuck()
        {
            return "Update";
        }

        [HttpDelete]
        public bool DeleteDuck()
        {
            return true;
        }
    }
}