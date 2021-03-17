namespace IntruderLib.Models.Agents
{
    using Newtonsoft.Json;

    /// <summary>
    /// Agent profile with xp/level and rank.
    /// </summary>
    public class LeveledAgent : Agent
    {
        /// <summary>
        /// Gets or sets the agent's level stats.
        /// </summary>
        [JsonProperty("stats")]
        public LevelStats Stats { get; set; }
    }
}
