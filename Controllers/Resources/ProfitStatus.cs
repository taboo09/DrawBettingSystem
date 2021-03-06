using System;

namespace BetSystem.Controllers.Resources
{
    public class ProfitStatus
    {
        public DateTime Date { get; set; }
        public int MatchesPlayed { get; set; }
        public int Wons { get; set; }
        public double Percentage { get; set; }
        public double MoneyBet { get; set; }
        public double MoneyEarn { get; set; }
        public double Profit { get; set; }
    }
}