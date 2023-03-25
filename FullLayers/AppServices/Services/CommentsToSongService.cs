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
    public class CommentsToSongService : ICommentsToSongService
    {
        ICommentsToSongRepository repository;
        IMapper mapper;

        public CommentsToSongService(ICommentsToSongRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void AddCommentsToSong(CommentsToSongViewModel commentToSong)
        {
            repository.Create(mapper.Map<CommentsToSong>(commentToSong));
        }

        public void DeleteCommentsToSong(int id)
        {
            repository.Delete(id);
        }

        public CommentsToSongViewModel GetById(int id)
        {
            CommentsToSong commentsToSong = repository.GetById(id);
            return mapper.Map<CommentsToSongViewModel>(commentsToSong);
        }

        public List<CommentsToSongViewModel> GetList()
        {
            List<CommentsToSongViewModel> commentsToSongViewModel = new List<CommentsToSongViewModel>();
            foreach(var commentToSong in GetList())
            {
                commentsToSongViewModel.Add(mapper.Map<CommentsToSongViewModel>(commentToSong));
            }
            return commentsToSongViewModel;
        }
    }
}
