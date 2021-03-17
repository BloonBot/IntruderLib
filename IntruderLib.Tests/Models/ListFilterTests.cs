namespace IntruderLib.Tests.Models
{
    using IntruderLib.Models;
    using Xunit;

    public class ListFilterTests
    {
        [Fact]
        public void EmptyQuery()
        {
            string query = new ListFilter().ToQuery();
            Assert.Equal(string.Empty, query);
        }

        [Fact]
        public void OnlySetPropertiesInt()
        {
            string query = new ListFilter
            {
                Page = 1,
                PerPage = 1,
            }.ToQuery();
            Assert.Equal("Page=1&PerPage=1", query);
        }

        [Fact]
        public void OnlySetPropertiesString()
        {
            string query = new ListFilter
            {
                OrderBy = "ordering:position",
            }.ToQuery();
            Assert.Equal("OrderBy=ordering:position", query);
        }
    }
}
