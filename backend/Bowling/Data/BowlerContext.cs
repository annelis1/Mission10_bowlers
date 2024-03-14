using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace Bowling.Data
{
    public class BowlerContext : DbContext
    {
        //inherit base options of regular dbcontext
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        //create table
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
