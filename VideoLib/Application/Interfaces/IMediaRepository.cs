using VideoLib.Domain.Entities;

namespace VideoLib.Application.Interfaces
{
    public interface IMediaRepository
    {
        Task<PlayList?> GetPlaylistAsync(int playListId, CancellationToken cancellationToken);
        Task InsertPlaylistAsync(PlayList playList, CancellationToken cancellationToken);
    }
}