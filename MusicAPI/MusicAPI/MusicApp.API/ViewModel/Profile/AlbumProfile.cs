using MusicApp.API.Model;
using MusicApp.API.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.API.ViewModel.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {
        public AlbumProfile()
        {
            CreateMap<MusicRequest, Music>();
            CreateMap<AlbumRequest, Album>();
        }
    }
}
