using SimpleCrud.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Data
{
    public class Group7CRUDDbContext : DbContext
    {
        public Group7CRUDDbContext()
        {
        }

        public Group7CRUDDbContext(DbContextOptions<Group7CRUDDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
    }
}
