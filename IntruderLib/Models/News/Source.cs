namespace IntruderLib.Models.News
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Source of the news post.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Source
    {
        /// <summary>
        /// Custom post.
        /// </summary>
        Custom = 1,

        /// <summary>
        /// Reddit.
        /// </summary>
        Reddit = 2,

        /// <summary>
        /// Steam.
        /// </summary>
        Steam = 3,
    }
}
