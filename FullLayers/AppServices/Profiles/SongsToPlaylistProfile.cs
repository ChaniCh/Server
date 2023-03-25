using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class SongsToPlaylistProfile : Profile
    {
        public SongsToPlaylistProfile()
        {
            CreateMap<SongsToPlaylist, SongsToPlaylistViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(p => p.PlaylistId, ops => ops.MapFrom(p => p.PlaylistId))
                .ForMember(s => s.SongId, ops => ops.MapFrom(s => s.SongId))
                .ReverseMap();
        }
    }
}

