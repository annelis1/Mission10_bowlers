using System.ComponentModel.DataAnnotations;

namespace Bowling.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        
    }
}
