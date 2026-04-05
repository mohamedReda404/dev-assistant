using Microsoft.EntityFrameworkCore;
using DevAssistant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevAssistant.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
