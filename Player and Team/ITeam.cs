using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    internal interface ITeam
    {
         void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        List<Player> GetPlayerByName(string playerName);
       // Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();






    }
}
