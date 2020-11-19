using Microsoft.EntityFrameworkCore;
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

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new MusicMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
