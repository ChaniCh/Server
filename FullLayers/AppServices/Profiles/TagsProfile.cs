using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class TagsProfile : Profile
    {
        public TagsProfile()
        {
            CreateMap<Tags, TagsViewModel>()
           .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
           .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
           .ForMember(s => s.Status, ops => ops.MapFrom(s => s.Status))
           .ReverseMap();
        }
    }
}
