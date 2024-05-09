namespace escuela.Models
{
    public abstract class TennisPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int Luck { get; }

        protected TennisPlayer()
        {
            Luck = new Random().Next(1, 101); // Genera un número aleatorio entre 1 y 100
        }
    }
}
