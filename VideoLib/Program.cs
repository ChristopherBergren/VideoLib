using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;
using System.Windows.Navigation;
using VideoLib.Application.Interfaces;
using VideoLib.Application.Models;
using VideoLib.Application.Services;
using VideoLib.Infrastructure;
using VideoLib.Infrastructure.Repositories;
using VideoLib.Views;
using FormsApplication = System.Windows.Forms.Application;
namespace VideoLib
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        private static string DbPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AnjunaMoon", "VideoLib", "app.db");

        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            
            Directory.CreateDirectory(Path.GetDirectoryName(DbPath)!);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var db = ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.EnsureCreated();

            ApplicationConfiguration.Initialize();
            host.RunAsync();
            // FormsApplication.Run(ServiceProvider.GetRequiredService<Main>());
            FormsApplication.Run();
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


                    // App Host
                    services.AddHostedService<ApplicationHostService>();

                    services.AddSingleton<IPageService, PageService>();
                    services.AddSingleton<INavigationService, VideoLib.Application.Services.NavigationService>();

                    // Views
                    services.AddTransient<IShellWindow, ShellWindow>();

                    services.AddTransient<GridControlPage>();

                    services.AddTransient<GroupBarPage>();

                    services.AddTransient<MainPage>();

                    services.AddTransient<MulticolumnTreeViewPage>();

                    services.AddTransient<NavigationDrawerPage>();

                    services.AddTransient<TabControlPage>();
                    services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));
                    // Sqlite
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlite($"Data Source={DbPath}"));
                });
        }
    }
}