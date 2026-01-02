using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;



namespace VideoLib
{
    public class VideoService : IVideoService
    {
        private LibVLC? libVlc;
        private MediaPlayer? mediaPlayer;
        private bool isFullscreen = false;
        private List<string> playList = new List<string>();
        private int currentVideoIdx = 0;

        public VideoService()
        {
        }

        public void Initialize(LibVLC _libVlc, MediaPlayer _mediaPlayer) 
        {
            libVlc = _libVlc;
            mediaPlayer = _mediaPlayer;
        }

        public void PlayFirst()
        {
            AddToPlaylist(@"H:\MOVIES\Fantasy\Lord of the Rings Trilogy BluRay Extended 1080p QEBS5 AAC51 PS3 MP4-FASM\Lord of the Rings - Fellowship of the Ring.mp4");
            AddToPlaylist(@"H:\MOVIES\Fantasy\Lord of the Rings Trilogy BluRay Extended 1080p QEBS5 AAC51 PS3 MP4-FASM\Lord_of_the_Rings_Two_towers_Ext_2002_1080p_BluRay_QEBS5_AAC51_PS3_MP4-FASM.mp4");
            AddToPlaylist(@"H:\MOVIES\Fantasy\Lord of the Rings Trilogy BluRay Extended 1080p QEBS5 AAC51 PS3 MP4-FASM\Lord_of_the_Rings_Return_of_the_King_Ext_2003_1080p_BluRay_QEBS5_AAC51_PS3_MP4-FASM.mp4");

            currentVideoIdx = 0;
            Play(GetCurrentVideo());
        }
        public void PlayNext()
        {
            if (playList.Count < 2)
                return;

            Play(GetNextVideo());
        }
        public void RaiseVolume()
        {
            mediaPlayer.Volume = Math.Min(mediaPlayer.Volume + 10, 100);
        }
        public void LowerVolume()
        {
            mediaPlayer.Volume = Math.Max(mediaPlayer.Volume - 10, 0);
        }
        public void Jump(int delta)
        {
            long newTime = mediaPlayer.Time + (delta * 1000L);
            if (newTime < 0)
                newTime = 0;

            mediaPlayer.Time = newTime;
        }
        private void AddToPlaylist(string file)
        {
            playList.Add(file);
        }
        private Media GetVideo(string videoFile)
        {
            var media = new Media(libVlc, videoFile, FromType.FromPath);
            return media;
        }
        private Media GetCurrentVideo() => GetVideo(playList[currentVideoIdx]);
        private Media GetNextVideo() => GetVideo((currentVideoIdx + 1 < playList.Count) ? playList[++currentVideoIdx] : playList[currentVideoIdx = 0]);
        private Media GetPreviousVideo() => GetVideo((currentVideoIdx > 0) ? playList[--currentVideoIdx] : playList[currentVideoIdx = playList.Count - 1]);
        private void Play(Media mediaFile)
        {
            mediaPlayer.Play(mediaFile);
            mediaPlayer.SetVideoTitleDisplay(Position.Top, 3000);
        }
    }
}


