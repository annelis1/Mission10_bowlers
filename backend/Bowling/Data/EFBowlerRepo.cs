
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace Bowling.Data
{
    public class EFBowlerRepo : IBowlerRepo
    {
        private BowlerContext _BowlerContext;
        public EFBowlerRepo(BowlerContext temp)
        {
            _BowlerContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _BowlerContext.Bowlers;
        public IEnumerable<Bowler> GetBowlersWithTeam()
        {
            return _BowlerContext.Bowlers.Include(b => b.Team);
        }
    }
}
