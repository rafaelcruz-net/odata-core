using Microsoft.EntityFrameworkCore;
using odatacoresample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odatacoresample.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DataContext() : base()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
