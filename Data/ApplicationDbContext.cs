using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Models;

namespace Songs_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist_Song>()
                .HasOne(b => b.Artists)
                .WithMany(ba => ba.Artist_Songs)
                .HasForeignKey(bi => bi.ArtistId);

            modelBuilder.Entity<Artist_Song>()
              .HasOne(b => b.Songs)
              .WithMany(ba => ba.Artist_Songs)
              .HasForeignKey(bi => bi.SongId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist_Song> Artist_Songs { get; set; }

    }
}
