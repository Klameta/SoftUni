using Microsoft.EntityFrameworkCore;
using MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data
{
    public class MusicHubDbContext : DbContext
    {
        public MusicHubDbContext()
        {
            
        }
        public MusicHubDbContext(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        {
            
        }
        public DbSet<Album> Albums{ get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Producer> Producers{ get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongPerformer> SongPerformers { get; set; }
        public DbSet<Writer> Writers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\PLUTON;Database=MusicHub;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongPerformer>()
                .HasKey(sp => new { sp.SongId, sp.PerformerId });

        }
    }
}
