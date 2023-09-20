using System.Collections;
using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Thompson_Lillian
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Tiny Tina Wonderlands");
            topGames.Add(2, "CS:GO");
            topGames.Add(3, "Halo 3");
            topGames.Add(4, "Elden Rings");
            topGames.Add(5, "Sonic Adverture");
            topGames.Add(6, "Kirby Airride");
            topGames.Add(7, "Donkey Kong 64");
            topGames.Add(8, "Runesape");
            topGames.Add(9, "GTA: San Andreeas");
            topGames.Add(10, "Valorant");

            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My Favorite is {topGames[1]}!");
            }
            string result = "";

            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh positon.");
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Rocket League";
            }

            Console.WriteLine(topGames[5]);

            Hashable hashTable = new Hashable(topGames);

            string favGame = (string)hashTable[1];

            Console.WriteLine($"Fvoerite Game: {favGame}");

            Hashable capitials = new Hashable()
            { "Oklahoma", "Oklahoma city" },
            { "New york", "Albany" },
            { "Texas", "Austin"},
            { "Ohio", "Colombus"}

            foreach (DictionaryEntry kvp in capitials)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            }
         
            capitial.Clear()
            
        } 

}   }            

    