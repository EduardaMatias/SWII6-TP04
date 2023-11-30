/* Eduarda Vitória e Stefany Tam */
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookCrud.Models;

namespace BookCrud.Data
{
    public class BookCrudContext : DbContext
    {
        public BookCrudContext (DbContextOptions<BookCrudContext> options)
            : base(options)
        {
        }

        public DbSet<BookCrud.Models.Livro> Livro { get; set; } = default!;
    }
}
