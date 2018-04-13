using BoardGameEloCalculator.Helpers;
using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameEloCalculator
{
    public partial class Form1 : Form
    {
        List<GroupBox> newPlayerList = new List<GroupBox>();
        Rectangle originalPlayerLocation;
        public List<GroupBox> NewPlayerList { get => newPlayerList; set => newPlayerList = value; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Program.GameList.Games.Select(n => n.Name).ToList();
            addPlayerComboBox.DataSource = Program.PlayerList.Players.Select(n => n.Name).ToList();
            PopulateRichTextBox();
            originalPlayerLocation = Player.Bounds;
        }

        private void PopulateRichTextBox()
        {
            String text = "";
            String eloText = ""; 
            foreach (Person player in Program.PlayerList.Players)
            {
                text += player.Name + "\n";
                eloText += Math.Round(player.getLatestElo(),2) + "\n";
            }

            richTextBox1.Text = text;
            richTextBox2.Text = eloText;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gamename = (string)comboBox1.SelectedValue;
            DateTime date = monthCalendar1.SelectionRange.Start;
            if (LogPlay.Log(gamename, date)==1)
            {
                foreach(GroupBox newplayer in newPlayerList)
                {
                    newplayer.Dispose();
                }
                Player.SetBounds(originalPlayerLocation.X, originalPlayerLocation.Y, originalPlayerLocation.Width, originalPlayerLocation.Height);
            }
            PopulateRichTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int confirmation = LogPlay.AddPerson((string)addPlayerComboBox.SelectedValue, (int)positionNumeric.Value);

            if (confirmation == 1)
            {
                GroupBox newPlayerBox = new GroupBox
                {
                    Parent = addPlayerComboBox.Parent.Parent,
                    Bounds = new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height)
                };
                newPlayerList.Add(newPlayerBox);

                Button newPlayerButton = new Button
                {
                    Parent = newPlayerBox,
                    Text = "delet dis",
                    Bounds = new Rectangle(180, 10, 100, 30),
                    TabIndex = 2
                };

                Label newplayer = new Label
                {
                    Parent = newPlayerBox,
                    Text = addPlayerComboBox.SelectedValue.ToString() + " " + positionNumeric.Value,
                    Name = addPlayerComboBox.SelectedValue.ToString(),
                    Bounds = new Rectangle(10, 20, 200, 30),
                    TabIndex = 1
                };

                
                newPlayerButton.Click += new System.EventHandler(ButtonDeleteClick);

                //if (listOfPlayers == null)
                //    listOfPlayers = new List<Label>();
                Player.SetBounds(Player.Location.X, Player.Location.Y + 50, Player.Width, Player.Height);
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameManager.AddGame(textBox1.Text);
            textBox1.Text="";
            comboBox1.DataSource = Program.GameList.Games.Select(n => n.Name).ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayerManager.Add(textBox1.Text);
            textBox1.Text = "";
            addPlayerComboBox.DataSource = Program.PlayerList.Players.Select(n => n.Name).ToList();
            PopulateRichTextBox();
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            LogPlay.RemovePerson(button.Parent.GetChildAtPoint(new Point(10, 20)).Name);
            button.Parent.Dispose();
            Player.SetBounds(Player.Location.X, Player.Location.Y - 50, Player.Width, Player.Height);
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //TODO figure out scrollbars
            //panel1.VerticalScroll.Value = vScrollBar1.Value;
            //panel1.Controls.Add(vScrollBar1);
        }

        private void Recalculate_Click(object sender, EventArgs e)
        {
            Recalculator.Recalculate();
            PopulateRichTextBox();
        }
    }
}
