using Games.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Games.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GamesContext>>()))
            {
                if(context.Game.Any()) 
                {
                    return;
                }
                context.Game.AddRange(
                    new Game
                    {
                        Title = "Witcher",
                        ReleaseDate = "2003",
                        Genre = "RPG,Action",
                        Price = 129
                    },
                    new Game
                    {
                        Title = "Borderlands",
                        ReleaseDate = "2009",
                        Genre = "RPG,Action,Shooter",
                        Price = 199
                    },
                    new Game
                    {
                        Title = "Call of Duty: Warzone 2.0",
                        ReleaseDate = "2022",
                        Genre = "Battle royale, shooter",
                        Price = 0
                    },
                    new Game
                    {
                        Title = "Hogwarts Legacy",
                        ReleaseDate = "2023",
                        Genre = "RPG,Action",
                        Price = 249
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
