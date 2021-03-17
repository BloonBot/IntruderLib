namespace IntruderLib.Models
{
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;

    /// <summary>
    /// Generic response class.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Gets or sets the <see cref="HttpStatusCode"/>.
        /// </summary>
        [JsonProperty("code")]
        public HttpStatusCode Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }
}
