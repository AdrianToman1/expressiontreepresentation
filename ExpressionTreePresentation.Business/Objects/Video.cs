using System;

namespace ExpressionTreePresentation.Business.Objects
{
    /// <summary>
    /// YouTube Video Business Object
    /// </summary>
    public class Video
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ChannelName { get; set; }

        public long Views { get; set; }

        public long Likes { get; set; }

        public long Dislikes { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}
