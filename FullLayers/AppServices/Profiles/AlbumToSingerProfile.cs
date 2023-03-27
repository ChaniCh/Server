using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class AlbumToSingerProfile : Profile
    {
        public AlbumToSingerProfile()
        {
            CreateMap<AlbumToSinger, AlbumToSingerViewModel>()
            .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
            .ForMember(s => s.SingerId, ops => ops.MapFrom(s => s.SingerId))
            .ForMember(a => a.AlbumId, ops => ops.MapFrom(a => a.AlbumId))
            .ReverseMap();
        }
    }
}
