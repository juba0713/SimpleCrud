using SimpleCrud.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCrud.Data
{
    public class SimpleCrudDbContext : DbContext
    {
        public SimpleCrudDbContext()
        {
        }

        public SimpleCrudDbContext(DbContextOptions<SimpleCrudDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
