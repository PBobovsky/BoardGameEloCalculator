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
    class PlayerList
    {
        static string path = @"DBFiles/players.json";
        List<Person> players;

        internal List<Person> Players { get => players; set => players = value; }

        internal Person Find(string playername)
        {
            return players.Find(p => p.Name == playername);
        }

        internal void Add(Person person)
        {
            if (players.Find(p => p.Name == person.Name) != null)
                return;
            players.Add(person);
            SaveToFile();
        }

        public PlayerList()
        {
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            string text = "";
            try
            {
                text = System.IO.File.ReadAllText(path);
            }catch(FileNotFoundException e)
            {
                Logger.Log("players.json not found, creating a new one");
            }
            catch (DirectoryNotFoundException ed)
            {
                Directory.CreateDirectory("DBFiles");
                Logger.Log("Directory not found, creating a new one");
            }
            players = FromJson(text);
        }

        private List<Person> FromJson(string text)
        {
            List<Person> players;
            if (!(text == ""))
            {
                 players = JsonConvert.DeserializeObject<List<Person>>(text);
            }
            else
            {
                players = new List<Person>();
            }
            return players;
        }

        public int SaveToFile()
        {
            String output;
            output = ToJson(players);
            System.IO.File.WriteAllText(path, output);
            return 1;
        }

        private string ToJson(List<Person> players)
        {
            var output = JsonConvert.SerializeObject(players);
            return output;
        }
    }
}
