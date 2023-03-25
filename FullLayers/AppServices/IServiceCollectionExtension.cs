using AppServices.IServices;
using AppServices.Profiles;
using AppServices.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IAlbumsService, AlbumsService>();
            service.AddScoped<IAlbumToSingerService, AlbumToSingerService>();
            service.AddScoped<ICommentsToPostService, CommentsToPostService>();
            service.AddScoped<ICommentsToSongService, CommentsToSongService>();
            service.AddScoped<IConnectionService, ConnectionService>();
            service.AddScoped<ICopyrightReportingService, CopyrightReportingService>();
            service.AddScoped<IFavoriteSongsService, FavoriteSongsService>();
            service.AddScoped<IFollowersService, FollowersService>();
            service.AddScoped<IFollowListeningSongsService, FollowListeningSongsService>();
            service.AddScoped<IFollowViewingPostsService, FollowViewingPostsService>();
            service.AddScoped<IJobsService, JobsService>();
            service.AddScoped<IJobToUserService, JobToUserService>();
            service.AddScoped<IPlaylistService, PlaylistService>();
            service.AddScoped<IPostsService, PostsService>();
            service.AddScoped<ISongsService, SongsService>();
            service.AddScoped<ISongsToPlaylistService, SongsToPlaylistService>();
            service.AddScoped<ISongToSingerService, SongToSingerService>();
            service.AddScoped<ITagForPostService, TagForPostService>();
            service.AddScoped<ITagForSongService, TagForSongService>();
            service.AddScoped<ITagsService, TagsService>();
            service.AddScoped<IUsersService, UsersService>();
            service.AddAutoMapper(typeof(AlbumsProfile));
            service.AddAutoMapper(typeof(ConnectionProfile));
            service.AddAutoMapper(typeof(FavoriteSongsProfile));
            service.AddAutoMapper(typeof(FollowListeningSongsProfile));
            service.AddAutoMapper(typeof(JobsProfile));
            service.AddAutoMapper(typeof(PlaylistProfile));
            service.AddAutoMapper(typeof(SongsToPlaylistProfile));
            service.AddAutoMapper(typeof(SongToSingerProfile));
            service.AddAutoMapper(typeof(TagsProfile));
            service.AddRepositories(configuration);
            return service;
        }
    }
}
