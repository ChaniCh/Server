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
    public class TagsService : ITagsService
    {
        private ITagsRepository repository;
        private IMapper mapper;

        public TagsService(ITagsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddTag(TagsViewModel tag)
        {
            repository.Create(mapper.Map<Tags>(tag));
        }

        public void DeleteTag(int id)
        {
            repository.Delete(id);
        }

        public List<TagsViewModel> GetList()
        {
            List<TagsViewModel> tagsViewModels = new List<TagsViewModel>();
            foreach(var tag in repository.GetAll())
            {
                tagsViewModels.Add(mapper.Map<TagsViewModel>(tag));
            }
            return tagsViewModels;
        }
    }
}
