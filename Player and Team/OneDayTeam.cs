using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    internal class OneDayTeam:ITeam
    {
       // public  List<Player> oneDayTeam = new List<Player>();
        private List<Player> players;
        public OneDayTeam()
        {
            players = new List<Player>();
        }
        public void Add(Player player)
        {
            if(players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player {player.ID} added to the team successfully");
            }
            else
            {
                Console.WriteLine("Playing 11 already filled");
            }
          
        }
        public void Remove(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p=>p.ID==playerId);
            if(playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player{playerToRemove.ID} removed from the team");
            }
            else
            {
                Console.WriteLine("Player not find");
            }
            
        }
        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p=>p.ID==playerId);
            
        }
        public List<Player> GetPlayerByName(string playerName)
        {
            // return players.Where(p => p.Name.Equals(playerName, StringComparsion.OrdinalIgnoreCase)).ToList();
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Player> GetAllPlayers()
        {
            return players.ToList();
        }
    }
    
}
