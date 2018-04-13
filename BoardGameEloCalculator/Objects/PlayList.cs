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
        static string sessionsPath = @"DBFiles/playSessions.json";
        List<Play> plays;
        List<PlaySession> playSessions;

        internal List<PlaySession> Plays { get => playSessions; set => playSessions = value; }
        internal List<PlaySession> PlaySessions { get => playSessions; set => playSessions = value; }

        public PlayList()
        {
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            string text = "";
            try
            {
                text = System.IO.File.ReadAllText(sessionsPath);

            }catch(FileNotFoundException e )
            {
                Logger.Log("plays.json not found, creating a new one " + e.Message);
            }catch(DirectoryNotFoundException ed)
            {
                Directory.CreateDirectory("DBFiles");
                Logger.Log("Directory not found, creating a new one " + ed.Message);
            }


            PlaySessions = FromJson(text);
        }

        private List<PlaySession> FromJson(string text)
        {
            List<PlaySession> plays;
            if (!(text == ""))
            {
                plays = JsonConvert.DeserializeObject<List<PlaySession>>(text);
            }
            else
            {
                plays = new List<PlaySession>();
            }
            
            return plays;
        }

        public int SaveToFile(List<Play> plays)
        {
            String output;
            output = ToJson(plays);
            System.IO.File.WriteAllText(path, output);
            return 1;
        }

        private string ToJson(List<Play> plays)
        {
            string output = JsonConvert.SerializeObject(plays);
            return output;
        }

        //internal void Add(Play play)
        //{
        //    Plays.Add(play);
        //    SaveToFile(Plays);
        //}

        internal void Add(PlaySession playSession)
        {
            playSessions.Add(playSession);
            SaveToFile(playSessions);
        }

        internal void Form(List<PlaySession> listOfSessions)
        {
            playSessions = listOfSessions;
            SaveToFile(playSessions);
        }

        public int SaveToFile(List<PlaySession> playSessions)
        {
            String output;
            output = ToJson(playSessions);
            System.IO.File.WriteAllText(sessionsPath, output);
            return 1;
        }

        private string ToJson(List<PlaySession> playSessions)
        {
            string output = JsonConvert.SerializeObject(playSessions);
            return output;
        }

    }
}
