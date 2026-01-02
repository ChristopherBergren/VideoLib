using System;
using System.Collections.Generic;
using System.Text;

namespace VideoLib.Domain.Entities
{
    public class MediaFile
    {
        public int Id { get; set; }
        public string FullPath { get; set; } = string.Empty;
        public string Filename { get; set; } = string.Empty;
        public MediaContainer Owner { get; set; } = null!;
    }
}
