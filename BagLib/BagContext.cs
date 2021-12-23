using BagLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;

namespace BagLib
{
    public partial class BagContext : DbContext
    {
        private readonly string LOG = "D:\\Capgemini\\Bootcamp\\CURSO_NET_AVANZADO\\BagMVC\\LOG.txt";
        private readonly StreamWriter _logStream;

        public DbSet<Country> Country { get; set; }

        public DbSet<Market> Market { get; set; }

        public DbSet<Stock> Stock { get; set; }

        public DbSet<Currency> Currency { get; set; }

        public DbSet<BagUser> BagUser { get; set; }

        public DbSet<MyStock> MyStock { get; set; }

        public BagContext(DbContextOptions<BagContext> options) : base(options)
        {
            
            _logStream = new StreamWriter(LOG, append: true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .LogTo(_logStream.WriteLine)
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BagContextFinal;Trusted_Connection=True;");
            }
        }
    }
}
