using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repositories.Models
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlbumToSinger> AlbumToSinger { get; set; }
        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<CommentsToPost> CommentsToPost { get; set; }
        public virtual DbSet<CommentsToSong> CommentsToSong { get; set; }
        public virtual DbSet<Connection> Connection { get; set; }
        public virtual DbSet<CopyrightReporting> CopyrightReporting { get; set; }
        public virtual DbSet<FavoriteSongs> FavoriteSongs { get; set; }
        public virtual DbSet<FollowListeningSongs> FollowListeningSongs { get; set; }
        public virtual DbSet<FollowSelectionSinger> FollowSelectionSinger { get; set; }
        public virtual DbSet<FollowViewingPosts> FollowViewingPosts { get; set; }
        public virtual DbSet<Followers> Followers { get; set; }
        public virtual DbSet<JobToUser> JobToUser { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Playlist> Playlist { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<SongToSinger> SongToSinger { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }
        public virtual DbSet<SongsToPlaylist> SongsToPlaylist { get; set; }
        public virtual DbSet<TagForPost> TagForPost { get; set; }
        public virtual DbSet<TagForSong> TagForSong { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@" Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID=musichani;Password= Sx95JXKF_L~3
");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumToSinger>(entity =>
            {
                entity.ToTable("album_to_singer");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.SingerId).HasColumnName("singerId");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumToSinger)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__album_to___album__2739D489");

                entity.HasOne(d => d.Singer)
                    .WithMany(p => p.AlbumToSinger)
                    .HasForeignKey(d => d.SingerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__albumToSi__singe__6B24EA82");
            });

            modelBuilder.Entity<Albums>(entity =>
            {
                entity.ToTable("albums");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.PublicationDate)
                    .HasColumnName("publicationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CommentsToPost>(entity =>
            {
                entity.ToTable("comments_to_post");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.CommentsToPost)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CommentsT__postI__5629CD9C");
            });

            modelBuilder.Entity<CommentsToSong>(entity =>
            {
                entity.ToTable("comments_to_song");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.CommentsToSong)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__comments___songI__2DE6D218");
            });

            modelBuilder.Entity<Connection>(entity =>
            {
                entity.ToTable("connection");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Connection)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__connectio__userI__73BA3083");
            });

            modelBuilder.Entity<CopyrightReporting>(entity =>
            {
                entity.ToTable("copyright_reporting");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.CopyrightReporting)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__copyright__songI__2FCF1A8A");
            });

            modelBuilder.Entity<FavoriteSongs>(entity =>
            {
                entity.ToTable("favorite_songs");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.FavoriteSongs)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__favorite___songI__2CF2ADDF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FavoriteSongs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FavoriteS__userI__4F7CD00D");
            });

            modelBuilder.Entity<FollowListeningSongs>(entity =>
            {
                entity.ToTable("follow_listening_songs");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.FollowListeningSongs)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__follow_li__songI__2EDAF651");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowListeningSongs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__follow_li__userI__7A672E12");
            });

            modelBuilder.Entity<FollowSelectionSinger>(entity =>
            {
                entity.ToTable("follow_selection_singer");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SingerId).HasColumnName("singerId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Singer)
                    .WithMany(p => p.FollowSelectionSingerSinger)
                    .HasForeignKey(d => d.SingerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__follow_se__singe__0C85DE4D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowSelectionSingerUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__follow_se__userI__0B91BA14");
            });

            modelBuilder.Entity<FollowViewingPosts>(entity =>
            {
                entity.ToTable("follow_viewing_posts");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.FollowViewingPosts)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__follow_vi__postI__7F2BE32F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowViewingPosts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__follow_vi__userI__7E37BEF6");
            });

            modelBuilder.Entity<Followers>(entity =>
            {
                entity.ToTable("followers");

                entity.Property(e => e.SingerId).HasColumnName("singerId");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Singer)
                    .WithMany(p => p.FollowersSinger)
                    .HasForeignKey(d => d.SingerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__followers__singe__778AC167");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowersUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__followers__userI__76969D2E");
            });

            modelBuilder.Entity<JobToUser>(entity =>
            {
                entity.ToTable("job_to_user");

                entity.Property(e => e.JobId).HasColumnName("jobId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobToUser)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobsToUse__jobId__68487DD7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobToUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobsToUse__userI__693CA210");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.ToTable("jobs");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("playlist");

                entity.Property(e => e.CountListening).HasColumnName("countListening");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublicOrPrivate).HasColumnName("publicOrPrivate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.ToTable("posts");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.CountLike).HasColumnName("countLike");

                entity.Property(e => e.CountListening).HasColumnName("countListening");

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.Property(e => e.LastViewingDate)
                    .HasColumnName("lastViewingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subtitle)
                    .HasColumnName("subtitle")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.ToTable("requests");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileLocation)
                    .HasColumnName("fileLocation")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SongToSinger>(entity =>
            {
                entity.ToTable("song_to_singer");

                entity.Property(e => e.SingerId).HasColumnName("singerId");

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.HasOne(d => d.Singer)
                    .WithMany(p => p.SongToSinger)
                    .HasForeignKey(d => d.SingerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_song_to_singer_users");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.SongToSinger)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_song_to_singer_songs");
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.ToTable("songs");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.CountLike).HasColumnName("countLike");

                entity.Property(e => e.CountListening).HasColumnName("countListening");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileLocation)
                    .HasColumnName("fileLocation")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberInAlbum).HasColumnName("numberInAlbum");

                entity.Property(e => e.PublicationDate)
                    .HasColumnName("publicationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subtitle)
                    .HasColumnName("subtitle")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK__songs__albumId__31B762FC");
            });

            modelBuilder.Entity<SongsToPlaylist>(entity =>
            {
                entity.ToTable("songs_to_playlist");

                entity.Property(e => e.PlaylistId).HasColumnName("playlistId");

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.HasOne(d => d.Playlist)
                    .WithMany(p => p.SongsToPlaylist)
                    .HasForeignKey(d => d.PlaylistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SongsToPl__playl__5AEE82B9");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.SongsToPlaylist)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__songs_to___songI__30C33EC3");
            });

            modelBuilder.Entity<TagForPost>(entity =>
            {
                entity.ToTable("tag_for_post");

                entity.Property(e => e.LastTagUpdate).HasColumnType("datetime");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.Property(e => e.TagId).HasColumnName("tagId");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.TagForPost)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TagForPos__postI__4BAC3F29");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagForPost)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TagForPos__tagId__4CA06362");
            });

            modelBuilder.Entity<TagForSong>(entity =>
            {
                entity.ToTable("tag_for_song");

                entity.Property(e => e.LastTagUpdate).HasColumnType("datetime");

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.TagId).HasColumnName("tagId");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.TagForSong)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tag_for_s__songI__2BFE89A6");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagForSong)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TagForSon__tagId__48CFD27E");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.ToTable("tags");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
