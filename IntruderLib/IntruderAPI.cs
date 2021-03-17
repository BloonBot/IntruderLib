namespace IntruderLib
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using IntruderLib.Models;
    using IntruderLib.Models.Agents;
    using IntruderLib.Models.News;
    using IntruderLib.Models.Rooms;
    using IntruderLib.Models.Tuning;
    using Newtonsoft.Json;

    /// <summary>
    /// Intruder Rest API interface.
    /// </summary>
    public class IntruderAPI
    {
        private readonly HttpClient httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntruderAPI"/> class.
        /// </summary>
        /// <param name="httpClient">Injectable http client instance.</param>
        public IntruderAPI(HttpClient httpClient = null)
        {
            this.httpClient = httpClient ?? new HttpClient();
            this.httpClient.BaseAddress = new Uri("https://api.intruderfps.com");
        }

        /// <summary>
        /// Fetches a single agent's profile and status.
        /// </summary>
        /// <param name="steamId">Agent's SteamId64.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Single agent.</returns>
        public Task<LeveledAgent> GetAgentAsync(ulong steamId) => this.QueryAsync<LeveledAgent>($"/agents/{steamId}");

        /// <summary>
        /// Fetches a list of agent profiles and statuses.
        /// </summary>
        /// <param name="filter">Agent list filter.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Paginated list of agents.</returns>
        public Task<PaginatedResult<LeveledAgent>> GetAgentsAsync(AgentListFilter filter = null) => this.QueryAsync<PaginatedResult<LeveledAgent>>($"/agents?{filter?.ToQuery() ?? string.Empty}");

        /// <summary>
        /// Fetches a single agent's stats.
        /// </summary>
        /// <param name="steamId">Agent's SteamId64.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Single agent's stats.</returns>
        public Task<Stats> GetAgentStatsAsync(ulong steamId) => this.QueryAsync<Stats>($"/agents/{steamId}/stats");

        /// <summary>
        /// Fetches a single agent's vote summaries.
        /// </summary>
        /// <param name="steamId">Agent's SteamId64.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Single agent's vote summaries.</returns>
        public Task<List<VoteSummary>> GetAgentVotesAsync(ulong steamId) => this.QueryAsync<List<VoteSummary>>($"/agents/{steamId}/votes");

        /// <summary>
        /// Fetches a list of recent news posts.
        /// </summary>
        /// <param name="filter">News list filter.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Paginated list of news.</returns>
        public Task<PaginatedResult<News>> GetNewsAsync(NewsListFilter filter = null) => this.QueryAsync<PaginatedResult<News>>($"/news?{filter?.ToQuery() ?? string.Empty}");

        /// <summary>
        /// Fetches a single room.
        /// </summary>
        /// <param name="roomId">Room's id.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Single room.</returns>
        public Task<Room> GetRoomAsync(int roomId) => this.QueryAsync<Room>($"/rooms/{roomId}");

        /// <summary>
        /// Fetches a list of rooms.
        /// </summary>
        /// <param name="filter">Room list filter.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Paginated list of rooms.</returns>
        public Task<PaginatedResult<Room>> GetRoomsAsync(RoomListFilter filter = null) => this.QueryAsync<PaginatedResult<Room>>($"/rooms?{filter?.ToQuery() ?? string.Empty}");

        /// <summary>
        /// Fetches a single room's agents.
        /// </summary>
        /// <param name="roomId">Room's id.</param>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Single room's agents.</returns>
        public Task<List<Agent>> GetRoomAgentsAsync(int roomId) => this.QueryAsync<List<Agent>>($"/rooms/{roomId}/agents");

        /// <summary>
        /// Fetches the current global game tuning.
        /// </summary>
        /// <exception cref="APIException">Thrown when the request fails or the response is invalid.</exception>
        /// <returns>Current global game tuning.</returns>
        public Task<Tuning> GetTuningAsync() => this.QueryAsync<Tuning>("/tuning");

        private async Task<T> QueryAsync<T>(string path)
            where T : class
        {
            try
            {
                HttpResponseMessage response = await this.httpClient.GetAsync(path);
                string content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(content);
                }

                Error error = content.Length > 0
                    ? JsonConvert.DeserializeObject<Error>(content)
                    : new Error
                    {
                        Message = response.ReasonPhrase,
                    };

                throw new APIException(error);
            }
            catch (HttpRequestException e)
            {
                throw new APIException("Failed to query the API", e);
            }
            catch (JsonException e)
            {
                throw new APIException("Unable to parse the response", e);
            }
        }
    }
}
