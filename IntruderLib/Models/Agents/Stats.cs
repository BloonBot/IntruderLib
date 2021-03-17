namespace IntruderLib.Models.Agents
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Agent game stats.
    /// </summary>
    public class Stats : LevelStats
    {
        /// <summary>
        /// Gets or sets the internal identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the related agent's internal identifier.
        /// </summary>
        [JsonProperty("agentId")]
        public int AgentId { get; set; }

        /// <summary>
        /// Gets or sets the amount of matches won.
        /// </summary>
        [JsonProperty("matchesWon")]
        public int MatchesWon { get; set; }

        /// <summary>
        /// Gets or sets the amount of matches lost.
        /// </summary>
        [JsonProperty("matchesLost")]
        public int MatchesLost { get; set; }

        /// <summary>
        /// Gets or sets the amount of rounds lost.
        /// </summary>
        [JsonProperty("roundsLost")]
        public int RoundsLost { get; set; }

        /// <summary>
        /// Gets or sets the amount of rounds tied.
        /// </summary>
        [JsonProperty("roundsTied")]
        public int RoundsTied { get; set; }

        /// <summary>
        /// Gets or sets team wins by eliminating the other team.
        /// </summary>
        [JsonProperty("roundsWonElimination")]
        public int RoundsWonElimination { get; set; }

        /// <summary>
        /// Gets or sets team wins by capturing the briefcase.
        /// </summary>
        [JsonProperty("roundsWonCapture")]
        public int RoundsWonCapture { get; set; }

        /// <summary>
        /// Gets or sets team wins by hacking enough networks.
        /// </summary>
        [JsonProperty("roundsWonHack")]
        public int RoundsWonHack { get; set; }

        /// <summary>
        /// Gets or sets team wins by timer ending.
        /// </summary>
        [JsonProperty("roundsWonTimer")]
        public int RoundsWonTimer { get; set; }

        /// <summary>
        /// Gets or sets team wins by custom objective.
        /// </summary>
        [JsonProperty("roundsWonCustom")]
        public int RoundsWonCustom { get; set; }

        /// <summary>
        /// Gets or sets the time played.
        /// </summary>
        [JsonProperty("timePlayed")]
        public int TimePlayed { get; set; }

        /// <summary>
        /// Gets or sets the amount of kills.
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; set; }

        /// <summary>
        /// Gets or sets the amount of team kills.
        /// </summary>
        [JsonProperty("teamKills")]
        public int TeamKills { get; set; }

        /// <summary>
        /// Gets or sets the amount of deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// Gets or sets the amount of arrests performed.
        /// </summary>
        [JsonProperty("arrests")]
        public int Arrests { get; set; }

        /// <summary>
        /// Gets or sets the amount of times the agent was arrested.
        /// </summary>
        [JsonProperty("gotArrested")]
        public int GotArrested { get; set; }

        /// <summary>
        /// Gets or sets the amount of package captures.
        /// </summary>
        [JsonProperty("captures")]
        public int Captures { get; set; }

        /// <summary>
        /// Gets or sets the amount of package pickups.
        /// </summary>
        [JsonProperty("pickups")]
        public int Pickups { get; set; }

        /// <summary>
        /// Gets or sets the amount of network hacks.
        /// </summary>
        [JsonProperty("networkHacks")]
        public int NetworkHacks { get; set; }

        /// <summary>
        /// Gets or sets the amount of matches survived.
        /// </summary>
        [JsonProperty("survivals")]
        public int Survivals { get; set; }

        /// <summary>
        /// Gets or sets the amount of suicides.
        /// </summary>
        [JsonProperty("suicides")]
        public int Suicides { get; set; }

        /// <summary>
        /// Gets or sets the amount of knockdowns performed.
        /// </summary>
        [JsonProperty("knockdowns")]
        public int Knockdowns { get; set; }

        /// <summary>
        /// Gets or sets the amount of times the agent was knocked down.
        /// </summary>
        [JsonProperty("gotKnockedDown")]
        public int GotKnockedDown { get; set; }

        /// <summary>
        /// Gets or sets the amount of team knockdowns.
        /// </summary>
        [JsonProperty("teamKnockdowns")]
        public int TeamKnockdowns { get; set; }

        /// <summary>
        /// Gets or sets the amount of damage inflicted on teammates.
        /// </summary>
        [JsonProperty("teamDamage")]
        public int TeamDamage { get; set; }

        /// <summary>
        /// Gets or sets the last time the agent's stats were updated.
        /// </summary>
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }
    }
}
