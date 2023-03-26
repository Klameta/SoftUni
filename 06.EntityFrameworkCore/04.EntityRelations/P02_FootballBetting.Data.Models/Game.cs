using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace P02_FootballBetting.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [ForeignKey("HomeTeam")]
        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        [ForeignKey("AwayTeam")]
        public int AwayTeamId { get; set; }
        public virtual  Team AwayTeam { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public virtual DateTime DateTime { get; set; }
        public double HomeTeamBetRate { get; set; }
        public double AwayTeamBetRate { get; set; }
        public double DrawBetRate { get; set; }
        public double Result { get; set; }

        public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}