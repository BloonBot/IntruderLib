namespace IntruderLib.Models.Agents
{
    using Newtonsoft.Json;

    /// <summary>
    /// Agent level stats.
    /// </summary>
    public class LevelStats
    {
        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the progress towards the next level.
        /// </summary>
        [JsonProperty("levelXp")]
        public int LevelXp { get; set; }

        /// <summary>
        /// Gets or sets the required xp value for the next level.
        /// </summary>
        [JsonProperty("levelXpRequired")]
        public int LevelXpRequired { get; set; }

        /// <summary>
        /// Gets or sets the total xp value.
        /// </summary>
        [JsonProperty("totalXp")]
        public int TotalXp { get; set; }
    }
}
