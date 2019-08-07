using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blog.Models;

namespace blog.Models
{
    public class blogContext : DbContext
    {
        public blogContext (DbContextOptions<blogContext> options)
            : base(options)
        {
        }

        public DbSet<blog.Models.Mensagem> Mensagem { get; set; }

        public DbSet<blog.Models.Categoria> Categoria { get; set; }
    }
}
