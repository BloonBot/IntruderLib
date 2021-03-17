namespace IntruderLib.Models.Rooms
{
    using Newtonsoft.Json;

    /// <summary>
    /// Match set score.
    /// </summary>
    public class SetScore
    {
        /// <summary>
        /// Gets or sets the score for the Guards.
        /// </summary>
        [JsonProperty("guards")]
        public int Guards { get; set; }

        /// <summary>
        /// Gets or sets the score for the Intruders.
        /// </summary>
        [JsonProperty("intruders")]
        public int Intruders { get; set; }
    }
}
