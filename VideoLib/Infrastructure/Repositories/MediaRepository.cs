using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.Metrics;
using VideoLib.Application.Interfaces;
using VideoLib.Domain.Entities;
using VideoLib.Infrastructure;

namespace VideoLib.Infrastructure.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private readonly AppDbContext _context;

        public MediaRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PlayList?> GetPlaylistAsync(int playListId, CancellationToken cancellationToken)
        {
            var playlist = await _context.Set<PlayList>()
                .Include(p => p.MediaFiles)
                .Include(p => p.MediaFolders)
                .ThenInclude(f => f.MediaFiles)
                .FirstAsync(p => p.Id == playListId, cancellationToken: cancellationToken);
            return playlist;
        }

        public async Task InsertPlaylistAsync(PlayList playList, CancellationToken cancellationToken)
        {
            await _context.PlayList.AddAsync(playList, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
