using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class JobToUserProfile : Profile
    {
        public JobToUserProfile()
        {
            CreateMap<JobToUser, JobToUserViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(u => u.UserId, ops => ops.MapFrom(u => u.UserId))
                .ForMember(j => j.JobId, ops => ops.MapFrom(j => j.JobId))
                .ReverseMap();
        }
    }
}
