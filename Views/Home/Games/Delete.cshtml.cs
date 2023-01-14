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
    public class DeleteModel : PageModel
    {
        private readonly PillowGames.Data.GamesContext _context;

        public DeleteModel(PillowGames.Data.GamesContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FirstOrDefaultAsync(m => m.Id == id);

            if (game == null)
            {
                return NotFound();
            }
            else 
            {
                Game = game;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }
            var game = await _context.Games.FindAsync(id);

            if (game != null)
            {
                Game = game;
                _context.Games.Remove(Game);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
