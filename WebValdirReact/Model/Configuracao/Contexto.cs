using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebValdirReact.Model.Configuracao
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produto { get; set; }

    }
}
