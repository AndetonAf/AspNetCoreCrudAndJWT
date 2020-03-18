using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Comeia.Models;

namespace Comeia.Data
{
    public class ComeiaContext : DbContext
    {
        public ComeiaContext(DbContextOptions<ComeiaContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoa { get; set; }

    }
}
