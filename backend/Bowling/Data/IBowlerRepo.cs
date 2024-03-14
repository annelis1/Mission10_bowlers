namespace Bowling.Data
{
    public interface IBowlerRepo
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Bowler> GetBowlersWithTeam();

    }
}
