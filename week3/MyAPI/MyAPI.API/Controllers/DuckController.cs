using Microsoft.AspNetCore.Mvc;
using DuckData.Repo;
using DuckData.Models;

namespace MyAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuckController : ControllerBase
    {
        // Fields
        private readonly ILogger<DuckController> _logger;
        private IRepository _repo;

        // Constructor
        public DuckController(ILogger<DuckController> logger, IRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // Methods
        [HttpGet]
        public List<Duck> GetAllDucks()
        {
            return _repo.LoadAllDucks();
        }

        [HttpGet( "{id}" )]
        public Duck GetDuckById( int id )
        {
            return _repo.GetDuckById( id );
        }

        [HttpPost]
        public Duck CreateDuck( [FromBody] Duck newDuck )
        {
            try
            {
                _repo.SaveDuck( newDuck );
                var ducks = _repo.LoadAllDucks();
                var duck = from d in ducks
                    where newDuck.color == d.color && newDuck.numFeathers == d.numFeathers
                    select d;
                return duck.First();
            }
            catch
            {
                return new Duck();
            }
        }

        [HttpPut]
        public string UpdateDuck()
        {
            return "Update";
        }

        [HttpDelete( "{id}" )]
        public bool DeleteDuck( int id )
        {
            try
            {
                _repo.DeleteDuckById( id );
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}