namespace escuela.Models
{
    public class TournamentHistory
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int WinnerId { get; set; }
        public DateTime Date { get; set; }

    }
}
