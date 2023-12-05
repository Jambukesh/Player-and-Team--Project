using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string again;
            do
            {
                Console.Write("1: to Add player");
                Console.Write("2: To Remove Player by Id ");
                Console.Write("3:to Get Player By Id ");
                Console.Write("4: Get Player by Name ");
                Console.Write("5:Get All Players");
                Console.Write("6:to exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter player id:");
                        int playerID = int.Parse(Console.ReadLine());
                        Console.Write("Please enter player name:");
                        string PlayerName = Console.ReadLine();
                        Console.Write("Please enter player Age:");
                        int playerAge = int.Parse(Console.ReadLine());
                        team.Add(new Player { ID = playerID, Name = PlayerName, Age = playerAge });

                        break;
                        


                    case 2:
                        Console.Write("Please enter player id to Remove:");
                        int playerIDToRemove = int.Parse(Console.ReadLine());
                        team.Remove(playerIDToRemove);
                       
                        break;

                    case 3:
                        Console.Write("Please enter player id to Get details:");
                        int playerIDToGetDetails = int.Parse(Console.ReadLine());
                        Player playerById = team.GetPlayerById(playerIDToGetDetails);
                        if (playerById != null)
                        {
                            Console.Write($"Player found : id :{playerById.ID}, Name :{playerById.Name}, Age :{playerById.Age}");

                        }
                        else
                        {
                            Console.Write("Player not found:");
                        }
                        break;

                    case 4:
                        Console.Write("Please Enter Player Name to get details:");
                        string playerNameToGet = Console.ReadLine();

                        List<Player> playersByName = team.GetPlayerByName(playerNameToGet);
                        if (playersByName.Count > 0)
                        {
                            Console.Write($"Players Found with name '{playerNameToGet}':");
                            foreach (Player player in playersByName)
                            {
                                Console.Write($"Id: {player.ID}, Name: {player.Name}, Age: {player.Age}");
                            }
                        }
                        else
                        {
                            Console.Write($"No players found with name '{playerNameToGet}'.");
                        }
                        break;

                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        Console.Write("All Players:");
                        foreach (Player player in allPlayers)
                        {
                            Console.Write($"Id: {player.ID}, Name: {player.Name}, Age: {player.Age}");
                        }
                        break;

                    case 6:
                        Console.Write("Exiting the program.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Invalid choice. Please try again.");

                        break;

                }
                Console.Write("Do you want to Continue?: Yes/No");
                again = Console.ReadLine();


            }
            while (again.Equals("Yes"));
            Console.ReadKey();
        }
    }
}
