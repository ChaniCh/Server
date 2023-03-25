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
    public class TagForSongService : ITagForSongService
    {
        ITagForSongRepository repository;
        IMapper mapper;

        public TagForSongService(ITagForSongRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddTagForSong(TagForSongViewModel tagForSong)
        {
            repository.Create(mapper.Map<TagForSong>(tagForSong));
        }

        public void DeleteTagForSong(int id)
        {
            repository.Delete(id);
        }

        public TagForSongViewModel GetById(int id)
        {
            TagForSong tagForSong = repository.GetById(id);
            return mapper.Map<TagForSongViewModel>(tagForSong);
        }

        public List<TagForSongViewModel> GetList()
        {
            List<TagForSongViewModel> tagForSongViewModel = new List<TagForSongViewModel>();
            foreach (var tagForSong in GetList())
            {
                tagForSongViewModel.Add(mapper.Map<TagForSongViewModel>(tagForSong));
            }
            return tagForSongViewModel;
        }
    }
}
