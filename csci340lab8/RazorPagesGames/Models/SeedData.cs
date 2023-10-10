using Microsoft.EntityFrameworkCore;
using RazorPagesGame.Data;
using RazorPagesGames.Models;

namespace RazorPagesGame.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesGameContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesGameContext>>()))
        {
            if (context == null || context.Game == null)
            {
                throw new ArgumentNullException("Null RazorPagesGameContext");
            }

            // Look for any movies.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }

            context.Game.AddRange(
                new Game
                {
                    Title = "EarthBound",
                    ReleaseDate = DateTime.Parse("1995-6-5"),
                    Genre = "JRPG",
                    Platform = "SNES"
                },

                new Game
                {
                    Title = "MOTHER 3",
                    ReleaseDate = DateTime.Parse("2006-4-20"),
                    Genre = "JRPG",
                    Platform = "GBA"
                },

                new Game
                {
                    Title = "Minecraft",
                    ReleaseDate = DateTime.Parse("2011-11-18"),
                    Genre = "Sandbox",
                    Platform = "All"
                },

                new Game
                {
                    Title = "Touhou 7",
                    ReleaseDate = DateTime.Parse("2003-8-17"),
                    Genre = "Bullet Hell",
                    Platform = "PC"
                },

                new Game
                {
                    Title = "Mahoyo",
                    ReleaseDate = DateTime.Parse("2012-4-12"),
                    Genre = "Visual Novel",
                    Platform = "PC"
                }
            );
            context.SaveChanges();
        }
    }
}