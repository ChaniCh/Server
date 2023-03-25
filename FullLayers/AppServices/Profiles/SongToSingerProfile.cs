using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class SongToSingerProfile : Profile
    {
        public SongToSingerProfile()
        {
            CreateMap<SongToSinger, SongToSingerViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(s => s.SongId, ops => ops.MapFrom(s => s.SongId))
                .ForMember(s => s.SingerId, ops => ops.MapFrom(s => s.SingerId))
                .ReverseMap();
        }
    }
}

