using ChuckNorrisApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Data
{
    public class ChuckNorrisContext : DbContext
    {
        public ChuckNorrisContext(DbContextOptions options) : base(options) { }

        public DbSet<ChuckNorris> ChuckNorris { get; set; }
    }

}
