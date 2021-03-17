namespace IntruderLib.Models.Agents
{
    using System;
    using IntruderLib.Models.Rooms;
    using Newtonsoft.Json;

    /// <summary>
    /// Agent status.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Gets or sets the internal identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the related agent's internal identifier.
        /// </summary>
        [JsonProperty("agentId")]
        public int AgentId { get; set; }

        /// <summary>
        /// Gets or sets the related room's internal identifier.
        /// </summary>
        [JsonProperty("roomId")]
        public int? RoomId { get; set; }

        /// <summary>
        /// Gets or sets the last time the agent's status was updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an agent is currently online.
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; set; }

        /// <summary>
        /// Gets or sets the game room the agent is currently in.
        /// </summary>
        [JsonProperty("room")]
        public Room Room { get; set; }
    }
}
