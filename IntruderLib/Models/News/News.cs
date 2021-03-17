namespace IntruderLib.Models.News
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// News post.
    /// </summary>
    public class News
    {
        /// <summary>
        /// Gets a value indicating whether the post is live.
        /// </summary>
        [JsonIgnore]
        public static bool Live => true;

        /// <summary>
        /// Gets or sets the internal identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier used by the source.
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the source of the news post.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the link text.
        /// </summary>
        [JsonProperty("linkText")]
        public string LinkText { get; set; }

        /// <summary>
        /// Gets or sets the link url.
        /// </summary>
        [JsonProperty("linkUrl")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail url.
        /// </summary>
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the video url.
        /// </summary>
        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the post should be stickied.
        /// </summary>
        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        /// <summary>
        /// Gets or sets the news post's creation timestamp.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
