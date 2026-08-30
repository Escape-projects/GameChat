using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;
using GameChat.Server;
using System.Linq;
using GameChat.userControls;
using ChatGame.panels;
using System.Runtime.InteropServices;
using GameChat.interfaces;
using GameChat.Service2;
using System.Web;

namespace GameChat.panels
{
    public partial class RoomsByGame : UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        CreateRoom createRoom;
        List<string[]> rooms;
        List<RoomPanel> roomsPanels = new List<RoomPanel>();
        ServiceClient client;
        Service2Client client2;
        RoomPanel roomPanel;
        ChatRoom chatRoom;
        RoomSetting roomSetting;
        public MainScreen mainScreen;
        public string game_name;
        public bool buttonCreateClick = false;
        int room_id;

        public RoomsByGame(MainScreen mainScreen, string game_name, Service2Client client2)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.mainScreen = mainScreen;
            this.client2 = client2;
            this.game_name = game_name;
            textBoxGame.Text = game_name;
            textBoxGame.Width = TextRenderer.MeasureText(textBoxGame.Text, textBoxGame.Font).Width;
            textBoxGame.Location = new Point( (panelTitle.Width - textBoxGame.Width) / 2 + 15, textBoxGame.Location.Y);
            textBoxGame.GotFocus += hideCaret;
            pictureBoxGamesTab.Location = new Point(textBoxGame.Location.X - 35, pictureBoxGamesTab.Location.Y);
            pictureBoxBack.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            roomsDisplay();
            roomPanel = null;
        }

        public void roomsDisplay()
        {
            panelRooms.Controls.Clear();
            client = new ServiceClient();
            rooms = client.getRooms(game_name, "game").ToList<string[]>();
            if (rooms.Count > 0)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    roomPanel = new RoomPanel(mainScreen.account.userName, int.Parse(rooms[i][0]), rooms[i][1], rooms[i][2], rooms[i][3], null, this, mainScreen);
                    roomPanel.Size = new Size(panelRooms.Width, roomPanel.Height);
                    if (i > 0) roomPanel.Location = new Point(panelRooms.Controls[i - 1].Location.X, panelRooms.Controls[i - 1].Location.Y + 45);
                    panelRooms.Controls.Add(roomPanel);
                    roomsPanels.Add(roomPanel);
                }
            }
        }

        private void buttonCreateRoom_Click(object sender, EventArgs e)
        {
            if (!buttonCreateClick)
            {
                createRoom = new CreateRoom(this, textBoxGame.Text, mainScreen.account.userName);
                createRoom.Show();
                buttonCreateClick = true;
            }
        }

        public void replacmentRoom(int room_id, string room_name, RoomPanel roomPanel, string user_status)
        {
            this.room_id = room_id;
            if (this.roomPanel == null) this.roomPanel = roomPanel;
            else
            {
                this.roomPanel.BackColor = Color.Gray;
                this.roomPanel.panelClick = false;
                this.roomPanel = roomPanel;
            }

            chatRoom = new ChatRoom(this, roomPanel, room_id, room_name, user_status, client2, mainScreen.account.userName);
            chatRoom.Size = new Size(panelRoom.Width, panelRoom.Height);
            panelRoom.Controls.Clear();
            panelRoom.Controls.Add(chatRoom);
        }

        public void replacmentRoomSetting(string room_name, int room_id, bool password)
        {
            roomSetting = new RoomSetting(this, room_name, room_id, password, client2);
            roomSetting.Size = new Size(panelRoom.Width, panelRoom.Height);
            panelRoom.Controls.Clear();
            panelRoom.Controls.Add(roomSetting);
        }

        private void RoomsByGames_SizeChanged(object sender, EventArgs e)
        {
            if (Width != 0)
            {
                if (Width >= 800)
                {
                    panelRoomList.Width = 299;
                    panelRoom.Location = new Point(301, panelRoom.Location.Y);
                    panelRoom.Width = Width - panelRoomList.Width - 3;
                }
                else if (Width < 800)
                {
                    panelRoomList.Width = 189;
                    panelRoom.Location = new Point(191, panelRoom.Location.Y);
                    panelRoom.Width = Width - panelRoomList.Width - 3;
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            mainScreen.replacmentGameRooms(true);
        }

        private void hideCaret(object sender, EventArgs e)
        {
            HideCaret(textBoxGame.Handle);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "Поиск" && textBoxSearch.Text != "")
            {
                List <string[]> roomsAfter = new List<string[]>();
                for (int i = 0; i < rooms.Count; i++)
                {
                    if (rooms[i][1].StartsWith(textBoxSearch.Text))
                    {
                        roomsAfter.Add(rooms[i]);
                    }
                }
                roomsSearchDisplay(roomsAfter);
            }
            else roomsDisplay();
        }

        private void roomsSearchDisplay(List<string[]> rooms)
        {
            panelRooms.Controls.Clear();
            for (int i = 0; i < rooms.Count; i++)
            {
                roomPanel = new RoomPanel(mainScreen.account.userName, int.Parse(rooms[i][0]), rooms[i][1], rooms[i][2], rooms[i][3], null, this);
                roomPanel.Size = new Size(panelRooms.Width, roomPanel.Height);
                if (i > 0) roomPanel.Location = new Point(panelRooms.Controls[i - 1].Location.X, panelRooms.Controls[i - 1].Location.Y + 45);
                panelRooms.Controls.Add(roomPanel);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск") textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "" || textBoxSearch.Text == " ") textBoxSearch.Text = "Поиск";
        }

        public void openRoom(string room_name)
        {
            for (int i = 0; i < roomsPanels.Count; i++)
            {
                if (roomsPanels[i].room_name == room_name) roomsPanels[i].RoomPanel_Click(null, null);
            }
        }

        void emptySpaceClick(object sender, EventArgs e)
        {
            mainScreen.emptySpaceClick(null, null);
        }

        public void banCallBack(int room_id, string game)
        {
            if (game_name == game)
            {
                roomsDisplay();
                if (room_id == this.room_id)
                {
                    panelRoom.Controls.Clear();
                    MessageBox.Show("Вас забанили");
                }
            }
        }

        public void SendMessageInRoomCallBack(int room_id, string user_name, string message, DateTime dateTime)
        {
            if (room_id == this.room_id)
            {
                chatRoom.getMessage(user_name, message, dateTime);
            }
        }
    }
}
