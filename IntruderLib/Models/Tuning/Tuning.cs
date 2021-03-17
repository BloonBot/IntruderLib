namespace IntruderLib.Models.Tuning
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Current global game tuning.
    /// </summary>
    public class Tuning
    {
        /// <summary>
        /// Gets or sets the internal identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the raw tuning.
        /// </summary>
        [JsonProperty("raw")]
        public JObject Raw { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tuning is live.
        /// </summary>
        [JsonProperty("live")]
        public bool Live { get; set; }
    }
}
