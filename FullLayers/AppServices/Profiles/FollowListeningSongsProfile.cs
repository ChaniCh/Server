using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class FollowListeningSongsProfile : Profile
    {
        public FollowListeningSongsProfile()
        {
            CreateMap<FollowListeningSongs, FollowListeningSongsViewModel>()
               .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
               .ForMember(u => u.UserId, ops => ops.MapFrom(u => u.UserId))
               .ForMember(s => s.SongId, ops => ops.MapFrom(s => s.SongId))
               .ForMember(d => d.Date, ops => ops.MapFrom(d => d.Date))
               .ReverseMap();
        }
    }
}

