using System;
using Microsoft.EntityFrameworkCore;

namespace Server.Data
{
    public class EntryDbContext : DbContext
    {
        public DbSet<Models.Entry> Entries { get; set; }

        public DbSet<Models.Person> People { get; set; }

        public EntryDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

