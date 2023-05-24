using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Model
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public double AverageAge { get; set; }
        public string TeamName { get; set; }

        public Team()
        {
            Players = new List<FootballPlayer>();
        }

        public void AddPlayer(FootballPlayer player)
        {
            if (Players.Count <= 22)
            {
                Players.Add(player);
                CalculateAverageAge();
            }
            else
            {
                Console.WriteLine("The team is already full. Cannot add more players.");
            }
        }

        private void CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            AverageAge = totalAge / (double)Players.Count;
        }
    }
}
