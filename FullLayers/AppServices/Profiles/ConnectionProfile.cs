using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class ConnectionProfile : Profile
    {
        public ConnectionProfile()
        {
            CreateMap<Connection, ConnectionViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(d => d.Date, ops => ops.MapFrom(d => d.Date))
                .ForMember(u => u.UserId, ops => ops.MapFrom(u => u.UserId))
                .ReverseMap();
        }
    }
}
