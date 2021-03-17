namespace IntruderLib.Tests.Models.Agents
{
    using IntruderLib.Models.Agents;
    using Xunit;

    public class AgentListFilterTests
    {
        [Fact]
        public void EmptyQuery()
        {
            string query = new AgentListFilter().ToQuery();
            Assert.Equal(string.Empty, query);
        }

        [Fact]
        public void OnlySetPropertiesBool()
        {
            string query = new AgentListFilter
            {
                OnlineOnly = false,
            }.ToQuery();
            Assert.Equal("OnlineOnly=False", query);
        }
    }
}
