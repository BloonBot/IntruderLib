namespace IntruderLib.Tests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using IntruderLib.Models;
    using IntruderLib.Models.Agents;
    using IntruderLib.Models.News;
    using IntruderLib.Models.Rooms;
    using IntruderLib.Models.Tuning;
    using Xunit;

    public class IntruderAPITests
    {
        private const ulong AgentSteamId = 76561197972342332;

        private readonly IntruderAPI intruderAPI;

        public IntruderAPITests()
        {
            this.intruderAPI = new IntruderAPI();
        }

        [Fact]
        public async void GetAgentAsync()
        {
            LeveledAgent agent = await this.intruderAPI.GetAgentAsync(AgentSteamId);
            Assert.NotNull(agent);
            Assert.Equal(AgentSteamId, agent.SteamId);
        }

        [Fact]
        public async void GetAgentNonExistantAsync()
        {
            APIException exception = await Assert.ThrowsAsync<APIException>(() => this.intruderAPI.GetAgentAsync(AgentSteamId >> 1));
            Assert.Equal("Agent not found", exception.Message);
        }

        [Fact]
        public async void GetAgentsAsync()
        {
            PaginatedResult<LeveledAgent> result = await this.intruderAPI.GetAgentsAsync();
            AssertPaginatedResult(result);
        }

        [Fact]
        public async void GetAgentsWithFilterAsync()
        {
            PaginatedResult<LeveledAgent> result = await this.intruderAPI.GetAgentsAsync(new AgentListFilter
            {
                Q = "Rob Storm",
                PerPage = 1,
            });
            AssertPaginatedResult(result);
            Assert.Single(result.Data, agent => agent.SteamId == AgentSteamId);
        }

        [Fact]
        public async void GetAgentsWithInvalidFilterAsync()
        {
            APIException exception = await Assert.ThrowsAsync<APIException>(() => this.intruderAPI.GetAgentsAsync(new AgentListFilter
            {
                PerPage = 1000,
            }));
            Assert.Equal("Invalid parameters", exception.Message);
            Assert.NotNull(exception.Errors);
            Assert.Collection(exception.Errors, error => Assert.Contains("The field PerPage must be", error));
        }

        [Fact]
        public async void GetAgentsStatsAsync()
        {
            Stats stats = await this.intruderAPI.GetAgentStatsAsync(AgentSteamId);
            Assert.NotNull(stats);
            Assert.True(stats.TimePlayed > 0);
        }

        [Fact]
        public async void GetAgentsVotesAsync()
        {
            List<VoteSummary> summary = await this.intruderAPI.GetAgentVotesAsync(AgentSteamId);
            Assert.NotNull(summary);
            Assert.True(summary.Count > 0);
        }

        [Fact]
        public async void GetNewsAsync()
        {
            PaginatedResult<News> result = await this.intruderAPI.GetNewsAsync();
            AssertPaginatedResult(result);
        }

        [Fact]
        public async void GetNewsWithFilterAsync()
        {
            PaginatedResult<News> result = await this.intruderAPI.GetNewsAsync(new NewsListFilter
            {
                Included = new HashSet<Source> { Source.Steam },
            });
            AssertPaginatedResult(result);
            Assert.All(result.Data, news => Assert.Equal(Source.Steam, news.Source));
        }

        [Fact]
        public async void GetRoomAsync()
        {
            Room room = await this.GetRoomForTestingAsync();
            if (room == null)
            {
                return;
            }

            Room newRoom = await this.intruderAPI.GetRoomAsync(room.Id);
            Assert.NotNull(newRoom);
            Assert.Equal(room.Id, newRoom.Id);
        }

        [Fact]
        public async void GetRoomsAsync()
        {
            await this.GetRoomForTestingAsync();
        }

        [Fact]
        public async void GetRoomsWithFilterAsync()
        {
            await this.GetRoomForTestingAsync(new RoomListFilter
            {
                Region = Region.US,
            });
        }

        [Fact]
        public async void GetRoomAgentsAsync()
        {
            Room room = await this.GetRoomForTestingAsync(new RoomListFilter
            {
                HideEmpty = true,
            });

            if (room == null)
            {
                return;
            }

            List<Agent> agents = await this.intruderAPI.GetRoomAgentsAsync(room.Id);
            Assert.NotNull(agents);
            Assert.True(agents.Count > 0);
        }

        [Fact]
        public async void GetTuningAsync()
        {
            Tuning tuning = await this.intruderAPI.GetTuningAsync();
            Assert.NotNull(tuning);
        }

        private static void AssertPaginatedResult<T>(PaginatedResult<T> result)
            where T : class
        {
            Assert.NotNull(result);
            Assert.Equal(1, result.Page);
            Assert.True(result.PerPage > 0);
            Assert.True(result.TotalCount > 0);
            Assert.True(result.Data.Count <= result.PerPage);
        }

        private async Task<Room> GetRoomForTestingAsync(RoomListFilter filter = null)
        {
            PaginatedResult<Room> result = await this.intruderAPI.GetRoomsAsync(filter);
            AssertPaginatedResult(result);
            if (result.Data.Count == 0)
            {
                return null;
            }

            return result.Data[0];
        }
    }
}
