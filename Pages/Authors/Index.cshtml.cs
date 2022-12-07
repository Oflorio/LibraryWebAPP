using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryWebAPP.Data;
using LibraryWebAPP.Models;

namespace LibraryWebAPP.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly LibraryWebAPP.Data.LibraryWebAPPContext _context;

        public IndexModel(LibraryWebAPP.Data.LibraryWebAPPContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
