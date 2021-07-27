using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.Models.Identity;
using Songs_Manager.Models;

namespace Songs_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist_Song> Artist_Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song_Genre> Song_Genres { get; set; }
        public DbSet<Artist_Genre> Artist_Genres { get; set; }
        public DbSet<LyricsSubmissions> LyricsSubmissions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            modelBuilder.Entity<Artist_Song>()
                .HasOne(b => b.Artists)
                .WithMany(ba => ba.Artist_Songs)
                .HasForeignKey(bi => bi.ArtistId);
            modelBuilder.Entity<Artist_Song>()
              .HasOne(b => b.Songs)
              .WithMany(ba => ba.Artist_Songs)
              .HasForeignKey(bi => bi.SongId);

            modelBuilder.Entity<Song_Genre>()
              .HasOne(b => b.Song)
              .WithMany(ba => ba.Song_Genres)
              .HasForeignKey(bi => bi.SongId);
            modelBuilder.Entity<Song_Genre>()
              .HasOne(b => b.Genre)
              .WithMany(ba => ba.Song_Genres)
              .HasForeignKey(bi => bi.GenreId);

            modelBuilder.Entity<Artist_Genre>()
              .HasOne(b => b.Artists)
              .WithMany(ba => ba.Artist_Genres)
              .HasForeignKey(bi => bi.ArtistId);
            modelBuilder.Entity<Artist_Genre>()
              .HasOne(b => b.Genres)
              .WithMany(ba => ba.Artist_Genres)
              .HasForeignKey(bi => bi.GenreId);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.Entity is ITrackable trackable)
                {
                    var now = DateTime.Now;
                    //var date = Convert.ToDateTime(now.ToString());
                    //var date = DateTime.ParseExact((string)now, "yyyy-MM-dd HH:mm:ss.fffffff", System.Globalization.CultureInfo.InvariantCulture);
                    var user = GetCurrentUser();
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.LastUpdatedAt = now;
                            trackable.LastUpdatedBy = user;
                            break;

                        case EntityState.Added:
                            trackable.CreatedAt = now;
                            trackable.CreatedBy = user;
                            trackable.LastUpdatedAt = now;
                            trackable.LastUpdatedBy = user;
                            break;
                    }
                }
            }
        }

        private string GetCurrentUser()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
                var authenticatedUserName = httpContext.User.Identity.Name;
                //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier) // will give the user's userId
                //var userName = User.FindFirstValue(ClaimTypes.Name) // will give the user's userName
                return authenticatedUserName;
            }
            return string.Empty;
        }

    }
}
