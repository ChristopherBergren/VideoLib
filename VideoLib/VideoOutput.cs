using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoLib
{
    public partial class VideoOutput : Form
    {
        private readonly IVideoService _service;
        private LibVLC libVlc;
        private MediaPlayer mediaPlayer;
        private bool isFullscreen = false;

        public VideoOutput(IVideoService videoService)
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Parent = null;

            Core.Initialize();
            libVlc ??= new LibVLC();
            mediaPlayer ??= new MediaPlayer(libVlc);
            _service = videoService;
            _service.Initialize(libVlc, mediaPlayer);

            videoView1.MediaPlayer = mediaPlayer;
            videoView1.KeyUp += VideoView1_KeyUp;
            mediaPlayer.EndReached += MediaPlayer_EndReached; 

            _service.PlayFirst();

        }

        public void MediaPlayer_EndReached(object? sender, EventArgs e)
        {
            _service.PlayNext();
        }
        private void VideoView1_KeyUp(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    this.WindowState = (isFullscreen) ? FormWindowState.Normal : FormWindowState.Maximized;
                    isFullscreen = !isFullscreen;
                    break;
                case Keys.Delete:
                case Keys.Decimal:
                case Keys.Right:
                    _service.Jump(3);
                    break;
                case Keys.Insert:
                case Keys.NumPad0:
                case Keys.Left:
                    _service.Jump(-3);
                    break;
                case Keys.Up:
                    _service.RaiseVolume();
                    break;
                case Keys.Down:
                    _service.LowerVolume();
                    break;
                case Keys.NumPad3:
                    _service.PlayNext();
                    break;
                default:
                    break;
            }
        }
    }
}
