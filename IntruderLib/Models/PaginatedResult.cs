namespace IntruderLib.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Paginated data response.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    public class PaginatedResult<T> : Pagination
        where T : class
    {
        /// <summary>
        /// Gets or sets the total amount of data entries.
        /// </summary>
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the list of returned entries of type <typeparamref name="T"/>.
        /// </summary>
        [JsonProperty("data")]
        public List<T> Data { get; set; }
    }
}
