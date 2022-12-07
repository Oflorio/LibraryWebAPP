using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryWebAPP.Models;

namespace LibraryWebAPP.Data
{
    public class LibraryWebAPPContext : DbContext
    {
        public LibraryWebAPPContext (DbContextOptions<LibraryWebAPPContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryWebAPP.Models.Book> Book { get; set; } = default!;

        public DbSet<LibraryWebAPP.Models.Author> Author { get; set; } = default!;
    }
}
