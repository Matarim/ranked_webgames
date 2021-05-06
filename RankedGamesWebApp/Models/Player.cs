using System;
using System.ComponentModel.DataAnnotations;

namespace RankedGamesWebApp.Models
{
    public class Player
    {
        public double Rank
        { get; set; }

        public string UserName
        { get; set; }

        public double Kills
        { get; set; }
        
        public double Deaths
        { get; set; }

        public double Score
        { get; set; }
    }
}
