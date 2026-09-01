//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Practice
//{
//    class Tournament
//    {
//        public string TournamentName { get; set; }
//        private List<Match> _list=new List<Match>();
//        public Tournament(string tournamentName)
//        {
//            TournamentName = tournamentName;
//        }
//        public void AddMatch(Match match)
//        {
//            _list.Add(match);
//        }

//    }

//    public class Team
//    {
//        public string TeamId { get; set; }
//        public string TeamName { get; set; }
//        List<Player> players=new List<Player>();
//        public Team(string teamId, string teamName)
//        {
//            TeamId = teamId;
//            TeamName = teamName;
//        }
//        public void AddPlayer(Player player)
//        {
//            players.Add(player);
//        }
//    }

//    class Match
//    {
//        public int MatchId { get; set; }
//        public Team TeamA { get; private set; }
//        public Team TeamB { get; private set; }
//        public MatchFormat Format { get; private set; }
//        public Referee MatchReferee { get; set; }

//        // Encapsulated Scores
//        public int ScoreTeamA { get; private set; }
//        public int ScoreTeamB { get; private set; }
//        public bool IsCompleted { get; private set; }

//        public Match(int matchId, Team teamA, Team teamB, MatchFormat format, Referee referee)
//        {
//            MatchId = matchId;
//            TeamA = teamA;
//            TeamB = teamB;
//            Format = format;
//            MatchReferee = referee;
//            ScoreTeamA = 0;
//            ScoreTeamB = 0;
//            IsCompleted = false;
//        }
//        public void UpdateScore(int scoreA, int scoreB)
//        {
//            if (IsCompleted) return;

//            ScoreTeamA = scoreA;
//            ScoreTeamB = scoreB;
//        }

//        // FIX 3: Complete match action method
//        public Team? CompleteMatch()
//        {
//            IsCompleted = true;
//            return Format.DetermineWinner(ScoreTeamA, ScoreTeamB, TeamA, TeamB);
//        }

//    }

//    public abstract class MatchFormat
//    {
//        public abstract string FormatName { get; }
//        public abstract Team? DetermineWinner(int scoreA, int scoreB, Team teamA, Team teamB);
//    }
    
//    class Knockout: MatchFormat
//    {
//        public override string FormatName => "Knockout";

//        public override Team? DetermineWinner(int scoreA, int scoreB, Team teamA, Team teamB)
//        {
//            if (scoreA == scoreB)
//            {
//                throw new InvalidOperationException("Knockout match cannot end in a draw! Extra time/Penalty needed.");
//            }
//            return scoreA > scoreB ? teamA : teamB;
//        }
//    }

//    class League: MatchFormat
//    {
//        public override string FormatName => "League";

//        public override Team? DetermineWinner(int scoreA, int scoreB, Team teamA, Team teamB)
//        {
//            if (scoreA == scoreB)
//            {
//                return null; // Draw allowed in League match
//            }
//            return scoreA > scoreB ? teamA : teamB;
//        }

//    }

//    class Referee
//    {
//        public string RefereeId { get; set; }
//        public string Name { get; set; }

//        public Referee(string refereeId, string name)
//        {
//            RefereeId = refereeId;
//            Name = name;
//        }

//    }

//    class Result
//    {

//    }

//    public class Player
//    {
//        public string PlayerId { get; set; }
//        public string Name { get; set; }

//        public Player(string playerId, string name)
//        {
//            PlayerId = playerId;
//            Name = name;
//        }

//    }
//    internal class Class3
//    {
//    }
//}
