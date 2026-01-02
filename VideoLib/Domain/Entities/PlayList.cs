using System;
using System.Collections.Generic;
using System.Text;
using VideoLib.Domain.Enums;

namespace VideoLib.Domain.Entities
{
    public class PlayList : MediaContainer
    {
        public Category Category { get; set; } = Category.None;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<MediaFile> GetAllFiles()
        {
            var files = MediaFolders.SelectMany(f => f.MediaFiles).ToList();
            files.AddRange(MediaFiles);
            return files;
        }
    }
}
