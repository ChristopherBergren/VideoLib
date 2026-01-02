using Microsoft.EntityFrameworkCore;
using System.DirectoryServices.ActiveDirectory;
using VideoLib.Domain.Entities;
namespace VideoLib.Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Domain.Entities.PlayList> PlayList => Set<VideoLib.Domain.Entities.PlayList>();
        public DbSet<Domain.Entities.MediaFile> MediaFiles => Set<VideoLib.Domain.Entities.MediaFile>();
        public DbSet<Domain.Entities.MediaFolder> MediaFolder => Set<VideoLib.Domain.Entities.MediaFolder>();
        public DbSet<Domain.Entities.MediaContainer> MediaContainer => Set<VideoLib.Domain.Entities.MediaContainer>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<VideoLib.Domain.Entities.PlayList>()
            //    .HasKey(pl => pl.Id);
            //modelBuilder.Entity<VideoLib.Domain.Entities.MediaFolder>()
            //    .HasKey(lp => lp.Id);
            //modelBuilder.Entity<VideoLib.Domain.Entities.MediaFile>()
            //    .HasKey(lp => lp.Id);
            modelBuilder.Entity<MediaContainer>()
                .HasKey(mc => mc.Id);
            modelBuilder.Entity<MediaContainer>()
                .HasDiscriminator<string>("ContainerType")
                .HasValue<PlayList>("PlayList")
                .HasValue<MediaFolder>("MediaFolder");
            modelBuilder.Entity<MediaContainer>()
                .HasMany(mc => mc.MediaFiles)
                .WithOne(mf => mf.Owner)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<MediaContainer>()
                .HasMany(mc => mc.MediaFolders)
                .WithOne(mf => mf.Owner)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
