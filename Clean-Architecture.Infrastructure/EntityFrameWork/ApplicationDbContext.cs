using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Clean_Architecture.Core.Entities;

namespace Clean_Architecture.Infrastructure.EntityFrameWork
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Collaborater> Collaboraters { get; set; }
    }
}
