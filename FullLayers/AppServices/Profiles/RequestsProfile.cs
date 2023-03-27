using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class RequestsProfile : Profile
    {
        public RequestsProfile()
        {
            CreateMap<Requests, RequestsViewModel>()
           .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
           .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
           .ForMember(e => e.Email, ops => ops.MapFrom(e => e.Email))
           .ForMember(f => f.FileLocation, ops => ops.MapFrom(f => f.FileLocation))
           .ForMember(p => p.Phone, ops => ops.MapFrom(p => p.Phone))
           .ForMember(s => s.Status, ops => ops.MapFrom(s => s.Status))
           .ForMember(d => d.Date, ops => ops.MapFrom(d => d.Date))
           .ReverseMap();
        }
    }
}
