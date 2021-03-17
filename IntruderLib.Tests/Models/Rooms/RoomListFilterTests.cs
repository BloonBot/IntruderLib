namespace IntruderLib.Tests.Models.Rooms
{
    using IntruderLib.Models.Rooms;
    using Xunit;

    public class RoomListFilterTests
    {
        [Fact]
        public void EmptyQuery()
        {
            string query = new RoomListFilter().ToQuery();
            Assert.Equal(string.Empty, query);
        }

        [Fact]
        public void OnlySetPropertiesEnum()
        {
            string query = new RoomListFilter
            {
                Region = Region.US,
            }.ToQuery();
            Assert.Equal("Region=US", query);
        }
    }
}
