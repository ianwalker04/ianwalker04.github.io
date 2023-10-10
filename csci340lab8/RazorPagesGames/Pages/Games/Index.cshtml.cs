using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesGame.Data;
using RazorPagesGames.Models;

namespace RazorPagesGames.Pages_Games
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesGame.Data.RazorPagesGameContext _context;

        public IndexModel(RazorPagesGame.Data.RazorPagesGameContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? GameGenre { get; set; }

        public async Task OnGetAsync()
{
    // Use LINQ to get list of genres.
    IQueryable<string> genreQuery = from m in _context.Game
                                    orderby m.Genre
                                    select m.Genre;

    var games = from m in _context.Game
                 select m;

    if (!string.IsNullOrEmpty(SearchString))
    {
        games = games.Where(s => s.Title.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(GameGenre))
    {
        games = games.Where(x => x.Genre == GameGenre);
    }
    Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
    Game = await games.ToListAsync();
}
    }
}
