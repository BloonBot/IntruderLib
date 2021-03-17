namespace IntruderLib.Models.Agents
{
    using Newtonsoft.Json;

    /// <summary>
    /// Vote attribute.
    /// </summary>
    public class VoteAttribute
    {
        /// <summary>
        /// Gets or sets the internal identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
