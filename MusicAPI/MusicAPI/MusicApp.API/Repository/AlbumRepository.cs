using Microsoft.EntityFrameworkCore;
using MusicApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.API.Repository
{
    public class AlbumRepository
    {
        private MusicContext Context { get; set; }
        public AlbumRepository(MusicContext context)
        {
            this.Context = context;
        }

        public async Task<IList<Album>> GetAllAsync()
            => (IList<Album>)await this.Context.Albums.ToListAsync();
    }
}
