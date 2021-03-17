namespace IntruderLib.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Exception wrapper for the API error response.
    /// </summary>
    public class APIException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIException"/> class.
        /// </summary>
        public APIException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIException"/> class.
        /// </summary>
        /// <param name="error">API error.</param>
        public APIException(Error error)
            : base(error.Message)
        {
            this.Errors = error.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public APIException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        public APIException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Gets or sets a list of errors returned from the API.
        /// </summary>
        public List<string> Errors { get; set; }
    }
}
