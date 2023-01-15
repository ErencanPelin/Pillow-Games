using MvcCore.Enums;
using PillowGames.Models;

namespace PillowGames.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GamesContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Games.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Game[]
            {
                new Game{Name="Carson",Description="Alexander",Genre=GenreEnum.action, Price=100, },
                new Game{Name="Meredith",Description="Alonso",Genre=GenreEnum.action, Price=22, },
                new Game{Name="Arturo",Description="Anand",Genre=GenreEnum.action, Price=62, },
                new Game{Name="Gytis",Description="Barzdukas",Genre = GenreEnum.action, Price=0, },
                new Game{Name="Yan",Description="Li",Genre = GenreEnum.action, Price=0, },
                new Game{Name="Peggy",Description="Justice",Genre = GenreEnum.action, Price=28, },
                new Game{Name="Laura",Description="Norman",Genre = GenreEnum.action, Price=84, },
                new Game{Name="Nino",Description="Olivetto",Genre = GenreEnum.action, Price=2000, },
            };

            foreach (var s in students)
            {
                context.Games.Add(s);
            }
            context.SaveChanges();
        }
    }
}
