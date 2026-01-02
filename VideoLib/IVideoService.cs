using LibVLCSharp.Shared;

namespace VideoLib
{
    public interface IVideoService
    {
        void Initialize(LibVLC _libVlc, MediaPlayer _mediaPlayer);
        void Jump(int delta);
        void LowerVolume();
        void PlayFirst();
        void PlayNext();
        void RaiseVolume();
    }
}