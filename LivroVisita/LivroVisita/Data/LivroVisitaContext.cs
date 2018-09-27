using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LivroVisita.Models
{
    public class LivroVisitaContext : DbContext
    {
        public LivroVisitaContext (DbContextOptions<LivroVisitaContext> options)
            : base(options)
        {
        }

        public DbSet<LivroVisita.Models.Visitante> Visitante { get; set; }
    }
}
