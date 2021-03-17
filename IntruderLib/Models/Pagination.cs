namespace IntruderLib.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Pagination base class.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Gets or sets the current pagination page.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets the amount of entries per page.
        /// </summary>
        [JsonProperty("perPage")]
        public int? PerPage { get; set; }
    }
}
