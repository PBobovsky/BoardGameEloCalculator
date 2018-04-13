using BoardGameEloCalculator.Helpers;
using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameEloCalculator
{
    static class Program
    {

        static PlayList playList;
        static GameList gameList;
        static PlayerList playerList;

        internal static PlayList PlayList { get => playList; set => playList = value; }
        internal static PlayerList PlayerList { get => playerList; set => playerList = value; }
        internal static GameList GameList { get => gameList; set => gameList = value; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            playList = new PlayList();
            gameList = new GameList();
            playerList = new PlayerList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
