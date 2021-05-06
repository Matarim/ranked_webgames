using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RankedGamesWebApp.Models;
using RestSharp;

namespace RankedGamesWebApp.Controllers
{
    public class PlayerController : Controller
    {

        public IEnumerable<Player> Players { get; set; }

        public async Task<IActionResult> Index()
        {
            // Variables for use throughout.
            string[] sysArray = { "psn", "xbl", "battle", "uno", "acti" };
            string url = "https://call-of-duty-modern-warfare.p.rapidapi.com/warzone-matches";
            string line;
            int count = 0;

            // Retrieves the file count to set Array Size Dynamically.
            var filecounter = new System.IO.StreamReader("./PlayerNames.txt").ReadToEnd();
            var lines = filecounter.Split(new char[] { '\n' });
            var counted = lines.Length;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader("./PlayerNames.txt");


            //Make Dynamic to handle file size
            Player[] playersArr = new Player[counted];

            while ((line = file.ReadLine()) != null)
            {
                foreach (string sys in sysArray)
                {
                    // Handles slowing down the API calls.
                    System.Threading.Thread.Sleep(1000);
                    // Creates the URL Structure.
                    var client = new RestClient($"{url}/{line}/{sys}");
                    // Creates the get request.
                    var request = new RestRequest(Method.GET);
                    // Authorization information.
                    request.AddHeader("x-rapidapi-key", "Insert your key here");
                    request.AddHeader("x-rapidapi-host", "call-of-duty-modern-warfare.p.rapidapi.com");
                    // Creates Execute variable.
                    var response = client.Execute(request);

                    // Incase there's just an empty response (I have tried Null and "" to no success).
                    if (response.Content == "{}")
                    {
                        Console.WriteLine("Empty Response!");
                        continue;
                    }
                    else
                    {
                        // Places the players content into a dictionary.
                        Dictionary<string, dynamic> playerDict = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response.Content);

                        // Handles the error response if the user.
                        if (playerDict.ContainsKey("error"))
                        {
                            Console.WriteLine("Broken - 404 Not Found");
                            continue;
                        }
                        // Handles all other cases.
                        else
                        {
                            // Core arrays for the last 7 games.
                            int[] kills = new int[7];
                            int[] deaths = new int[7];
                            int[] score = new int[7];

                            // Loop for iterating through last 7 games.
                            for (int i = 0; i < 7; i++)
                            {
                                kills.SetValue(Convert.ToInt32(playerDict["matches"][i]["playerStats"]["kills"]), i);
                                deaths.SetValue(Convert.ToInt32(playerDict["matches"][i]["playerStats"]["deaths"]), i);
                                score.SetValue(Convert.ToInt32(playerDict["matches"][i]["playerStats"]["score"]), i);
                            }

                            // Creates new arrays containing top 5 values for each.
                            int[] top5kills = kills.OrderByDescending(i => i).Take(5).ToArray();
                            int[] top5deaths = deaths.OrderByDescending(i => i).Take(5).ToArray();
                            int[] top5scores = score.OrderByDescending(i => i).Take(5).ToArray();

                            // Creates instance of the class.
                            Player player = new Player();

                            player.UserName = line;
                           
                            // Sets players stats.
                            player.Kills = top5kills.Sum();
                            player.Deaths = top5deaths.Sum();
                            player.Score = top5scores.Sum();

                            // Sets player in an array for later.
                            playersArr.SetValue(player, count);
                            IEnumerable<Player> playersSorted = playersArr.OrderByDescending(p => p.Kills).ThenBy(o => o.Deaths).ThenByDescending(n => n.Score);

                            // ADD RANK TO PLAYER AFTER SORTING.

                            Players = playersSorted;

                            break;
                        }
                    }
                }
                count++;
            }

            //Handles applying rank after the players are sorted by score.
            int rankedPosition = 1;
            foreach (var p in Players)
            {
                p.Rank = rankedPosition;
                rankedPosition++;
            }

            return View (Players);
        }
    }
}
