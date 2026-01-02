using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VideoLib.Application.Interfaces;
using VideoLib.Domain.Entities;

namespace VideoLib
{
    public partial class Main : Form
    {
        private readonly IMediaRepository _mediaRepository;
        public Main(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
            InitializeComponent();
            Task.Run(Initialize);
        }

        private async Task Initialize()
        {
            var cancellationToken = new CancellationToken();
            var files = new List<MediaFile>()
            {
                new()
                {
                    Filename="Lord of the Rings - Fellowship of the Ring.mp4",
                    FullPath = @"H:\MOVIES\Fantasy\Lord of the Rings Trilogy BluRay Extended 1080p QEBS5 AAC51 PS3 MP4-FASM\Lord of the Rings - Fellowship of the Ring.mp4",
                }
            };
            var files2 = new List<MediaFile>()
            {
                new()
                {
                    Filename="Lord of the Rings - Fellowship of the Ring 2.mp4",
                    FullPath = @"H:\MOVIES\Fantasy\Lord of the Rings Trilogy 2 BluRay Extended 1080p QEBS5 AAC51 PS3 MP4-FASM\Lord of the Rings - Fellowship of the Ring.mp4",
                }
            };
            var folders = new List<MediaFolder>()
            {
                new()
                {
                    FullPath = @"H:\MOVIES\Fantasy\Lord of the Rings Trilogy 2 BluRay Extended 1080p QEBS5 AAC51 PS3 MP4-FASM",
                    MediaFiles = files2
                }
            };

            var playlist = new PlayList()
            {
                Name = "Lord of the rings",
                Category = Domain.Enums.Category.Fantasy,
                Description = "LOTR",
                MediaFiles = files,
                MediaFolders = folders
            };

            await _mediaRepository.InsertPlaylistAsync(playlist, cancellationToken);   
            var list = await _mediaRepository.GetPlaylistAsync(1, cancellationToken);
            var f = list?.GetAllFiles().ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var videoOutput = Program.ServiceProvider!.GetRequiredService<VideoOutput>();
            videoOutput.Show();
        }
    }
}
