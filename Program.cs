using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoGameList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameList = new List<string>
            { "Bloodborne", "Pokemon Gold/ Silver",
              "Final Fantasy X", "God of War", 
              "Warzone", "Elden Ring", "Gears of War", 
              "HellBlade: Senua's Sacrifice",
              "Shadow of the Colossus"};

            IEnumerable<string> gameList = videoGameList.OrderBy(game => game.Length).ToList();

            foreach (string game in gameList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
