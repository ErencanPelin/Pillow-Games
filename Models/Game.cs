using MvcCore.Enums;

namespace PillowGames.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = "none";
        public string Description { get; set; } = "none";
        public double Price { get; set; }
        public GenreEnum Genre { get; set; }
    }
}
