using System;
using System.Collections.Generic;
using System.Text;

namespace VideoLib.Domain.Entities
{
    public abstract class MediaContainer
    {
        public int Id { get; set; }

        public List<MediaFile> MediaFiles { get; set; } = [];
        public List<MediaFolder> MediaFolders { get; set; } = [];
    }
}
