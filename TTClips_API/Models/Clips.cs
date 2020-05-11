using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTClips_API.Models
{
    public class Clips
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string EmbdedUrl { get; set; }
        public int ViewCount { get; set; }
        public string ThumbnailrUrl { get; set; }

    }
}
