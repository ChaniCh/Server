using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class JobsProfile : Profile
    {
        public JobsProfile()
        {
            CreateMap<Jobs, JobsViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
                .ReverseMap();
        }
    }
}
