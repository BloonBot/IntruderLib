namespace IntruderLib.Models.Rooms
{
    using System;
    using System.Collections.Generic;
    using IntruderLib.Models.Agents;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Game room.
    /// </summary>
    public class Room
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

        /// <summary>
        /// Gets or sets the "message of the day".
        /// </summary>
        [JsonProperty("motd")]
        public string Motd { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the room's region.
        /// </summary>
        [JsonProperty("region")]
        public Region Region { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the room is official.
        /// </summary>
        [JsonProperty("official")]
        public bool Official { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the room is ranked.
        /// </summary>
        [JsonProperty("ranked")]
        public bool Ranked { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the game/room version.
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the room list position.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the list of set scores.
        /// Only set if MatchMode is enabled.
        /// </summary>
        [JsonProperty("scores")]
        public List<SetScore> Scores { get; set; }

        /// <summary>
        /// Gets or sets the current map.
        /// </summary>
        [JsonProperty("currentMap")]
        public Map CurrentMap { get; set; }

        /// <summary>
        /// Gets or sets the list of selected maps.
        /// </summary>
        [JsonProperty("maps")]
        public List<Map> Maps { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of agents.
        /// </summary>
        [JsonProperty("maxAgents")]
        public int MaxAgents { get; set; }

        /// <summary>
        /// Gets or sets the current agent count.
        /// </summary>
        [JsonProperty("agentCount")]
        public int AgentCount { get; set; }

        /// <summary>
        /// Gets or sets the amount of spectator slots.
        /// </summary>
        [JsonProperty("spectatorSlots")]
        public int SpectatorSlots { get; set; }

        /// <summary>
        /// Gets or sets the minimum required role to be able to join the room.
        /// </summary>
        [JsonProperty("joinableBy")]
        public Role JoinableBy { get; set; }

        /// <summary>
        /// Gets or sets a list of blacklisted SteamId64s.
        /// </summary>
        [JsonProperty("blacklist")]
        public HashSet<ulong> Blacklist { get; set; }

        /// <summary>
        /// Gets or sets internal identifier of the agent who created the room.
        /// </summary>
        [JsonProperty("creatorId")]
        public int CreatorId { get; set; }

        /// <summary>
        /// Gets or sets the rules.
        /// </summary>
        [JsonProperty("rules")]
        public JObject Rules { get; set; }

        /// <summary>
        /// Gets or sets the tuning.
        /// </summary>
        [JsonProperty("tuning")]
        public JObject Tuning { get; set; }

        /// <summary>
        /// Gets or sets the last time the room details were updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        [JsonProperty("creator")]
        public Agent Creator { get; set; }
    }
}
