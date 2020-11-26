using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicApp.API.Model
{
    public class UserFavoriteMusic
    {
        public Guid Id { get; set; }
        public Guid MusicId { get; set; }
        public Guid UserId { get; set; }
        public Music Music { get; set; }
        [JsonIgnore] // adiciona devido a referencia circular para não ficar em loop
        public User User { get; set; }


    }
}
