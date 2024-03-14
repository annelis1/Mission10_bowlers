using Bowling.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bowling.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepo _bowlerRepo;
        public BowlerController(IBowlerRepo temp)
        {
            _bowlerRepo = temp;
        }

        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<Bowler> Get() 
        {
            var bowlerData = _bowlerRepo.GetBowlersWithTeam();

            return bowlerData;
        }
    }
}
