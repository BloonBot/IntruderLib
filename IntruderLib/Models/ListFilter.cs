using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("IntruderLib.Tests")]

namespace IntruderLib.Models
{
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Provides a group for commonly used list filters.
    /// </summary>
    public class ListFilter : Pagination
    {
        /// <summary>
        /// Gets or sets the result set ordering using `property:direction`.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Converts the filter to a query string.
        /// </summary>
        /// <returns>Query string.</returns>
        internal virtual string ToQuery() => string.Join(
                '&',
                this.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => p.GetValue(this, null) != null)
                    .Select(p =>
                    {
                        if (typeof(System.Collections.IEnumerable).IsAssignableFrom(p.PropertyType)
                            && !typeof(string).IsAssignableFrom(p.PropertyType))
                        {
                            return string.Join(
                                '&',
                                (p.GetValue(this, null) as System.Collections.IEnumerable)
                                    .Cast<object>()
                                    .Select(v => $"{p.Name}={v}"));
                        }

                        return $"{p.Name}={p.GetValue(this, null)}";
                    }));
    }
}
