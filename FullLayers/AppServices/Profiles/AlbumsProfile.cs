using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class AlbumsProfile : Profile
    {
        public AlbumsProfile()
        {
            CreateMap<Albums, AlbumsViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
                .ForMember(p => p.PublicationDate, ops => ops.MapFrom(p => p.PublicationDate))
                .ForMember(s => s.Status, ops => ops.MapFrom(s => s.Status))
                .ReverseMap();
        }
    }
}
