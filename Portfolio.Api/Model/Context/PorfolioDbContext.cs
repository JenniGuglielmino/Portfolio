using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porfolio.Api.Model.Context
{
    public class PorfolioDbContext : DbContext
    {
        public PorfolioDbContext(DbContextOptions<PorfolioDbContext> options) : base(options)
        {

        }
        public DbSet<Project> Projects { get; set; }

    }
}
