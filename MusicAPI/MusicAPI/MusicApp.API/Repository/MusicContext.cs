using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicApp.API.Model;
using MusicApp.API.Repository.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.API.Repository
{
    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Music> Music { get; set; }

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new MusicMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new UserFavoriteMusicMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory Logger = LoggerFactory.Create(x => x.AddConsole());
            optionsBuilder.UseLoggerFactory(Logger);

            base.OnConfiguring(optionsBuilder);
        }

    }
}
