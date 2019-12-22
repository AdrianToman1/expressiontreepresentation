using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressionTreePresentation.Models
{
    public class VideoDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ChannelTitle { get; set; }

        public long Views { get; set; }

        public long Likes { get; set; }

        public long Dislikes { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}
