using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<API.Models.Notes> Notes { get; set; }

        public DbSet<API.Models.User> User { get; set; }
    }
}
