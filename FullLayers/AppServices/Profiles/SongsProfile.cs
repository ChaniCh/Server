using AutoMapper;
using Common.ViewModels;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices.Profiles
{
    public class SongsProfile : Profile
    {
        public SongsProfile()
        {
            CreateMap<Songs, SongsViewModel>()
                .ForMember(i => i.Id, ops => ops.MapFrom(i => i.Id))
                .ForMember(n => n.Name, ops => ops.MapFrom(n => n.Name))
                .ForMember(d => d.Date, ops => ops.MapFrom(d => d.Date))
                .ForMember(p => p.PublicationDate, ops => ops.MapFrom(p => p.PublicationDate))
                .ForMember(c => c.CountLike, ops => ops.MapFrom(c => c.CountLike))
                .ForMember(c => c.CountListening, ops => ops.MapFrom(c => c.CountListening))
                .ForMember(a => a.AlbumId, ops => ops.MapFrom(a => a.AlbumId))
                .ForMember(n => n.NumberInAlbum, ops => ops.MapFrom(n => n.NumberInAlbum))
                .ForMember(t => t.Title, ops => ops.MapFrom(t => t.Title))
                .ForMember(s => s.Subtitle, ops => ops.MapFrom(s => s.Subtitle))
                .ForMember(c => c.Content, ops => ops.MapFrom(c => c.Content))
                .ForMember(s => s.Status, ops => ops.MapFrom(s => s.Status))
                .ForMember(s => s.Song, ops => ops.MapFrom(s => s.Song))
                .ForMember(i => i.Image, ops => ops.MapFrom(i => i.Image))
                .ReverseMap();
        }
    }
}
