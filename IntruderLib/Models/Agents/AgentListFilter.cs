namespace IntruderLib.Models.Agents
{
    /// <summary>
    /// Agent list filter.
    /// </summary>
    public class AgentListFilter : ListFilter
    {
        /// <summary>
        /// Gets or sets the (partial) agent name or Steam ID filter.
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether only online agents should be retrieved.
        /// </summary>
        public bool? OnlineOnly { get; set; }
    }
}
