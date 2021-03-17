namespace IntruderLib.Models.Rooms
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Room region.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Region
    {
        /// <summary>
        /// Europe (Amsterdam)
        /// </summary>
        EU = 1,

        /// <summary>
        /// US East (Washington)
        /// </summary>
        US = 2,

        /// <summary>
        /// Asia (Singapore)
        /// </summary>
        Asia = 3,

        /// <summary>
        /// Japan (Tokyo)
        /// </summary>
        JP = 4,

        /// <summary>
        /// Australia (Melbourne)
        /// </summary>
        AU = 5,

        /// <summary>
        /// US West (San Jose)
        /// </summary>
        USW = 6,

        /// <summary>
        /// South America (Sao Paulo)
        /// </summary>
        SA = 7,

        /// <summary>
        /// Canada East (Montreal)
        /// </summary>
        CAE = 8,

        /// <summary>
        /// South Korea (Seoul)
        /// </summary>
        KR = 9,

        /// <summary>
        /// India (Chennai)
        /// </summary>
        IN = 10,

        /// <summary>
        /// Russia (Moscow)
        /// </summary>
        RU = 11,
    }
}
