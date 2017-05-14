using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporRedisPub1
{
    public class TeamCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ioc { get; set; }
        public string Iso { get; set; }
    }

    public class HomeTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public TeamCountry TeamCountry { get; set; }
    }

    public class TeamCountry2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ioc { get; set; }
        public string Iso { get; set; }
    }

    public class AwayTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public TeamCountry2 TeamCountry { get; set; }
    }

    public class CategorySport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object CategoryList { get; set; }
    }

    public class TournamentCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object TournamentList { get; set; }
        public CategorySport CategorySport { get; set; }
    }

    public class TournamentSeason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class TournamentCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ioc { get; set; }
        public string Iso { get; set; }
    }

    public class MatchTournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TournamentCategory TournamentCategory { get; set; }
        public TournamentSeason TournamentSeason { get; set; }
        public int TournamentOrder { get; set; }
        public int TournamentGroupOrder { get; set; }
        public TournamentCountry TournamentCountry { get; set; }
    }

    public class MatchReferee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class MatchStadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class LiveScore
    {
        public int Id { get; set; }
        public string DateOfMatch { get; set; }
        public string CurrentPeriodStart { get; set; }
        public string IddaaMatchId { get; set; }
        public HomeTeam HomeTeam { get; set; }
        public AwayTeam AwayTeam { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int HomeTeamRedCardCount { get; set; }
        public int AwayTeamRedCardCount { get; set; }
        public MatchTournament MatchTournament { get; set; }
        public int StatusCodeId { get; set; }
        public string StatusCodeDetail { get; set; }
        public string ScoreStatus { get; set; }
        public int Winner { get; set; }
        public int AggregatedWinner { get; set; }
        public MatchReferee MatchReferee { get; set; }
        public MatchStadium MatchStadium { get; set; }
        public bool IsMatchActive { get; set; }
        public string DisplayDate { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsPostponed { get; set; }
        public int? Minutes { get; set; }
        public bool IsMinutesPlus { get; set; }
    }
}
