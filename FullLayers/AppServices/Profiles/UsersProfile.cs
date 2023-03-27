using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<Users, UsersViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
                .ForMember(e => e.Email, ops => ops.MapFrom(e => e.Email))
                .ForMember(p => p.Password, ops => ops.MapFrom(p => p.Password))
                .ForMember(i => i.Image, ops => ops.MapFrom(i => i.Image))
                .ForMember(s => s.Status, ops => ops.MapFrom(s => s.Status))
                .ReverseMap();
        }
    }
}
