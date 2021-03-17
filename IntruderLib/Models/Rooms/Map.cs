namespace IntruderLib.Models.Rooms
{
    using System;
    using System.Collections.Generic;
    using IntruderLib.Models.Agents;
    using Newtonsoft.Json;

    /// <summary>
    /// Room map/level.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Gets or sets the Steam workshop identifier.
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        [JsonProperty("author")]
        public SteamProfile Author { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the gamemode.
        /// </summary>
        [JsonProperty("gamemode")]
        public string Gamemode { get; set; }

        /// <summary>
        /// Gets or sets the map thumbnail.
        /// </summary>
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it's a community map.
        /// </summary>
        [JsonProperty("isMapMakerMap")]
        public bool IsMapMakerMap { get; set; }

        /// <summary>
        /// Gets or sets a list of tags.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the last update.
        /// </summary>
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }
    }
}
