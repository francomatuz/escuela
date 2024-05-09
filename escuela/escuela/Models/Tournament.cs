
using escuela.Enums;
using System.Reflection;

namespace escuela.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public Gender TournamentGender { get; set; }
        public List<TennisPlayer> Players { get; internal set; }
    }

}
