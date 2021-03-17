namespace IntruderLib.Tests.Models.News
{
    using System.Collections.Generic;
    using IntruderLib.Models.News;
    using Xunit;

    public class NewsListFilterTests
    {
        [Fact]
        public void EmptyQuery()
        {
            string query = new NewsListFilter().ToQuery();
            Assert.Equal(string.Empty, query);
        }

        [Fact]
        public void EmptyIEnumerableProperty()
        {
            string query = new NewsListFilter
            {
                Included = new HashSet<Source> { },
            }.ToQuery();
            Assert.Equal(string.Empty, query);
        }

        [Fact]
        public void OnlySetPropertiesIEnumerable()
        {
            string query = new NewsListFilter
            {
                Included = new HashSet<Source> { Source.Custom, Source.Steam },
            }.ToQuery();
            Assert.Equal("Included=Custom&Included=Steam", query);
        }
    }
}
