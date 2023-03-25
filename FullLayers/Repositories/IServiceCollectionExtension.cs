using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Classes;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IAlbumsRepository, AlbumsRepository>();
            service.AddScoped<IAlbumToSingerRepository, AlbumToSingerRepository>();
            service.AddScoped<ICommentsToPostRepository, CommentsToPostRepository>();
            service.AddScoped<ICommentsToSongRepository, CommentsToSongRepository>();
            service.AddScoped<IConnectionRepository, ConnectionRepository>();
            service.AddScoped<ICopyrightReportingRepository, CopyrightReportingRepository>();
            service.AddScoped<IFavoriteSongsRepository, FavoriteSongsRepository>();
            service.AddScoped<IFollowersRepository, FollowersRepository>();
            service.AddScoped<IFollowListeningSongsRepository, FollowListeningSongsRepository>();
            service.AddScoped<IFollowViewingPostsRepository, FollowViewingPostsRepository>();
            service.AddScoped<IJobsRepository,JobsRepository>();
            service.AddScoped<IJobToUserRepository, JobToUserRepository>();
            service.AddScoped<IPlaylistRepository, PlaylistRepository>();
            service.AddScoped<IPostsRepository, PostsRepository>();
            service.AddScoped<ISongsRepository, SongsRepository>();
            service.AddScoped<ISongsToPlaylistRepository, SongsToPlaylistRepository>();
            service.AddScoped<ISongToSingerRepository, SongToSingerRepository>();
            service.AddScoped<ITagForPostRepository, TagForPostRepository>();
            service.AddScoped<ITagForSongRepository, TagForSongRepository>();
            service.AddScoped<ITagsRepository, TagsRepository>();
            service.AddScoped<IUsersRepository, UsersRepository>();
            service.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MusiChani")));
            //service.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(@"Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID=musichani;Password=Sx95JXKF_L~3"));
            return service;
        }
    }
}
