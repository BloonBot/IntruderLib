namespace IntruderLib.Models.Agents
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Game player.
    /// </summary>
    public class Agent : SteamProfile
    {
        /// <summary>
        /// Gets or sets the internal identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the agent's role.
        /// </summary>
        [JsonProperty("role")]
        public Role Role { get; set; }

        /// <summary>
        /// Gets or sets the amount of times an agent has logged in.
        /// </summary>
        [JsonProperty("loginCount")]
        public int LoginCount { get; set; }

        /// <summary>
        /// Gets or sets the first login timestamp.
        /// </summary>
        [JsonProperty("firstLogin")]
        public DateTime FirstLogin { get; set; }

        /// <summary>
        /// Gets or sets the last login timestamp.
        /// </summary>
        [JsonProperty("lastLogin")]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Gets or sets the last time the agent details were updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the agent's status.
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}
