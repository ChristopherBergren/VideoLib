using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using FormsApplication = System.Windows.Forms.Application;
using System;
using VideoLib.Application.Interfaces;
using VideoLib.Infrastructure.Repositories;
using VideoLib.Infrastructure;
namespace VideoLib
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        private static string DbPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AnjunaMoon", "VideoLib", "app.db");
        [STAThread]
        static void Main()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DbPath)!);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var db = ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.EnsureCreated();

            ApplicationConfiguration.Initialize();
            FormsApplication.Run(ServiceProvider.GetRequiredService<Main>());
        }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services
                        .AddTransient<IVideoService, VideoService>()
                        .AddTransient<Main>()
                        .AddTransient<VideoOutput>()
                        .AddTransient<IMediaRepository, MediaRepository>();

                    // Sqlite
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlite($"Data Source={DbPath}"));
                });
        }
    }
}