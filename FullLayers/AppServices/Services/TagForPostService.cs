using AppServices.IServices;
using AutoMapper;
using Common.ViewModels;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Services
{
    public class TagForPostService : ITagForPostService
    {
        ITagForPostRepository repository;
        IMapper mapper;

        public TagForPostService(ITagForPostRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddTagForPost(TagForPostViewModel tagForPost)
        {
            repository.Create(mapper.Map<TagForPost>(tagForPost));
        }

        public void DeleteTagForPost(int id)
        {
            repository.Delete(id);
        }

        public TagForPostViewModel GetById(int id)
        {
            TagForPost tagForPost = repository.GetById(id);
            return mapper.Map<TagForPostViewModel>(tagForPost);
        }

        public List<TagForPostViewModel> GetList()
        {
            List<TagForPostViewModel> tagForPostViewModel = new List<TagForPostViewModel>();
            foreach (var tagForPost in GetList())
            {
                tagForPostViewModel.Add(mapper.Map<TagForPostViewModel>(tagForPost));
            }
            return tagForPostViewModel;
        }
    }
}
