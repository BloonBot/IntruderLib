namespace IntruderLib.Models.Rooms
{
    /// <summary>
    /// Room list filter.
    /// </summary>
    public class RoomListFilter : ListFilter
    {
        /// <summary>
        /// Gets or sets the (partial) room name filter.
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// Gets or sets the game/server version for which to return rooms.
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Gets or sets the region for which to return rooms.
        /// </summary>
        public Region? Region { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether empty rooms should be returned.
        /// </summary>
        public bool? HideEmpty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether full rooms should be returned.
        /// </summary>
        public bool? HideFull { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether passworded/locked rooms should be returned.
        /// </summary>
        public bool? HidePassworded { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether official rooms should be returned.
        /// </summary>
        public bool? HideOfficial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether custom/unofficial rooms should be returned.
        /// </summary>
        public bool? HideCustom { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether unranked rooms should be returned.
        /// </summary>
        public bool? HideUnranked { get; set; }
    }
}
