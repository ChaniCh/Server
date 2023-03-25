using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class PlaylistProfile : Profile
    {
        public PlaylistProfile()
        {
            CreateMap<Playlist, PlaylistViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
                .ForMember(c => c.CountListening, ops => ops.MapFrom(c => c.CountListening))
                .ForMember(i => i.Image, ops => ops.MapFrom(i => i.Image))
                .ForMember(p => p.PublicOrPrivate, ops => ops.MapFrom(p => p.PublicOrPrivate))
                .ForMember(u => u.UserId, ops => ops.MapFrom(u => u.UserId))
                .ForMember(s => s.Status, ops => ops.MapFrom(s => s.Status))
                .ReverseMap();
        }
    }
}
