using GameChat.userControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using GameChat.Server;
using System.Linq;
using ChatGame.panels;

namespace GameChat.panels
{
    public partial class Games : UserControl
    {
        GamePanel gamePanel;
        ServiceClient client;
        MainScreen mainScreen;
        List<string> games;

        public Games(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            panelGames.Click += emptySpaceClick;

            client = new ServiceClient();
            games = client.getGames().ToList<string>();
            GamesTabDisplay(games);
        }

        private void GamesTabDisplay(List<string> games)
        {
            panelGames.Controls.Clear();
            for (int i = 0; i < games.Count; i++)
            {
                gamePanel = new GamePanel(mainScreen, games[i]);
                if (i > 0 && panelGames.Width - (panelGames.Controls[i - 1].Location.X + 200) > 200)
                    gamePanel.Location = new Point(panelGames.Controls[i - 1].Location.X + 207, panelGames.Controls[i - 1].Location.Y);
                else if (i > 0 && panelGames.Width - (panelGames.Controls[i - 1].Location.X + 200) <= 200)
                    gamePanel.Location = new Point(7, panelGames.Controls[i - 1].Location.Y + 150);
                panelGames.Controls.Add(gamePanel);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "Поиск" && textBoxSearch.Text != "")
            {
                List<string> gamesBefore = games;
                List<string> gamesAfter = new List<string>();
                for (int i = 0; i < gamesBefore.Count; i++)
                {
                    if (gamesBefore[i].StartsWith(textBoxSearch.Text))
                    {
                        gamesAfter.Add(gamesBefore[i]);
                    }
                }
                GamesTabDisplay(gamesAfter);
            }
            else GamesTabDisplay(games);
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск") textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "" || textBoxSearch.Text == " ") textBoxSearch.Text = "Поиск";
        }

        private void emptySpaceClick(object sender, EventArgs e)
        {
            mainScreen.emptySpaceClick(null, null);
        }

        private void panelGames_SizeChanged(object sender, EventArgs e)
        {
            GamesTabDisplay(games);
        }

        public void banCallBack()
        {
            try
            {
                
            }
            catch { }
        }
    }
}
