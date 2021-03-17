namespace IntruderLib.Models.News
{
    using System.Collections.Generic;

    /// <summary>
    /// News list filter.
    /// </summary>
    public class NewsListFilter : ListFilter
    {
        /// <summary>
        /// Gets or sets a value indicating whether the sticky property should be ignored.
        /// </summary>
        public bool? IgnoreSticky { get; set; }

        /// <summary>
        /// Gets or sets a list of news post sources to include.
        /// </summary>
        public HashSet<Source> Included { get; set; }
    }
}
