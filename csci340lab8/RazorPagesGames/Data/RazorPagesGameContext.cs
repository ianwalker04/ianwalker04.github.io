using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesGames.Models;

namespace RazorPagesGame.Data
{
    public class RazorPagesGameContext : DbContext
    {
        public RazorPagesGameContext (DbContextOptions<RazorPagesGameContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesGames.Models.Game> Game { get; set; } = default!;
    }
}
