using BoardGameEloCalculator.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Objects
{
    class GameList
    {
        static string path = @"DBFiles/games.json";
        List<Game> games;
        //TODO: finish this with generic types
        //List<Person> players;
        //List<Play> plays;

        //internal void Add<T>(T item) where T : IBoardGameObject
        //{
        //    List<T> listOfItem;
        //    if (item is Game)
        //        listOfItem = games;

        //    if (listOfItem.Contains(item))
        //        return;
        //    games.Add(item);
        //    SaveToFile();
        //}

        internal void Add(Game game)
        {
            if (games.Contains(game))
                return;
            games.Add(game);
            SaveToFile();
        }

        internal List<Game> Games { get => games; set => games = value; }


        public GameList()
        {
            ReadFromFile();

        }
        public void ReadFromFile()
        {
            string text = "";
            try
            {
                 text = System.IO.File.ReadAllText(path);
            }
            catch(FileNotFoundException e)
            {
                Logger.Log("games.json not found, creating a new one");
            }
            catch (DirectoryNotFoundException ed)
            {
                Directory.CreateDirectory("DBFiles");
                Logger.Log("Directory not found, creating a new one");
            }

            Games = FromJson(text);
        }

        private List<Game> FromJson(string text)
        {
            List<Game> games;
            if (!(text == ""))
            {
                games = JsonConvert.DeserializeObject<List<Game>>(text);
            }
            else
            {
                games = new List<Game>();
            }
            return games;
        }

        public int SaveToFile()
        {
            String output;
            output = ToJson(Games);
            System.IO.File.WriteAllText(path, output);
            return 1;
        }

        private string ToJson(List<Game> games)
        {
            string output = JsonConvert.SerializeObject(games);
            return output;
        }

        internal Game Find(string gamename)
        {
            return games.Find(g => g.Name == gamename);
        }
    }
}
