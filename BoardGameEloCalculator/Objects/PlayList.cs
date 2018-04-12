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
    class PlayList
    {
        static string path = @"DBFiles/plays.json";
        List<Play> plays;

        internal List<Play> Plays { get => plays; set => plays = value; }

        public PlayList()
        {
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            string text = "";
            try
            {
                text = System.IO.File.ReadAllText(path);

            }catch(FileNotFoundException e )
            {
                Logger.Log("plays.json not found, creating a new one");
            }catch(DirectoryNotFoundException ed)
            {
                Directory.CreateDirectory("DBFiles");
                Logger.Log("Directory not found, creating a new one");
            }


            Plays = FromJson(text);
        }

        private List<Play> FromJson(string text)
        {
            List<Play> plays;
            if (!(text == ""))
            {
                plays = JsonConvert.DeserializeObject<List<Play>>(text);
            }
            else
            {
                plays = new List<Play>();
            }
            
            return plays;
        }

        public int SaveToFile()
        {
            String output;
            output = ToJson(Plays);
            System.IO.File.WriteAllText(path, output);
            return 1;
        }

        private string ToJson(List<Play> plays)
        {
            string output = JsonConvert.SerializeObject(plays);
            return output;
        }

        internal void Add(Play play)
        {
            Plays.Add(play);
            SaveToFile();
        }
    }
}
