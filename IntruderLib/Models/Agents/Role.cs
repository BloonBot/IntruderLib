namespace IntruderLib.Models.Agents
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Agent role.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {
        /// <summary>
        /// Demoted agent.
        /// </summary>
        Demoted = 1,

        /// <summary>
        /// Standard agent.
        /// </summary>
        Agent = 2,

        /// <summary>
        /// Member of the "Advanced User Group".
        /// </summary>
        AUG = 3,

        /// <summary>
        /// Ingame moderator.
        /// </summary>
        Moderator = 4,

        /// <summary>
        /// Superagent.
        /// </summary>
        Developer = 5,
    }
}
