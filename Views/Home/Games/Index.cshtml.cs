using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PillowGames.Data;
using PillowGames.Models;

namespace PillowGames.Views.Games
{
    public class IndexModel : PageModel
    {
        private readonly PillowGames.Data.GamesContext _context;

        public IndexModel(PillowGames.Data.GamesContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Games != null)
            {
                Game = await _context.Games.ToListAsync();
            }
        }
    }
}
