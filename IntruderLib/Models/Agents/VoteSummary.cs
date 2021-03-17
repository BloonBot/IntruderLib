namespace IntruderLib.Models.Agents
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Summary of all votes an agent has received.
    /// </summary>
    public class VoteSummary
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
        /// Gets or sets the related attribute's internal identifier.
        /// </summary>
        [JsonProperty("attributeId")]
        public int AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the amount of positive ratings.
        /// </summary>
        [JsonProperty("positive")]
        public int Positive { get; set; }

        /// <summary>
        /// Gets or sets the amount of negative ratings.
        /// </summary>
        [JsonProperty("negative")]
        public int Negative { get; set; }

        /// <summary>
        /// Gets or sets the total amount of received votes.
        /// </summary>
        [JsonProperty("received")]
        public int Received { get; set; }

        /// <summary>
        /// Gets or sets the last time the agent's vote summary was updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the vote summary's attribute.
        /// </summary>
        [JsonProperty("attribute")]
        public VoteAttribute Attribute { get; set; }
    }
}
