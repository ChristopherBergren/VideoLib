using System;
using System.Collections.Generic;
using System.Text;

namespace VideoLib.Domain.Entities
{
    public class MediaFolder : MediaContainer
    {
        public string FullPath { get; set; } = string.Empty;
        public MediaContainer Owner { get; set; } = null!;
    }
}
