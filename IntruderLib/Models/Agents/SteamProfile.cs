namespace IntruderLib.Models.Agents
{
    using Newtonsoft.Json;

    /// <summary>
    /// Steam profile data.
    /// </summary>
    public class SteamProfile
    {
        /// <summary>
        /// Gets or sets the SteamID64.
        /// </summary>
        [JsonProperty("steamId")]
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the avatar url.
        /// </summary>
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
    }
}
