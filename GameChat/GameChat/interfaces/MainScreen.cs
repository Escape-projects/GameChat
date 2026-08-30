using ChatGame.userControls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Service2;
using System.Collections.Generic;
using GameChat.Server;
using System.Linq;
using GameChat.panels;
using GameChat.userControls;

namespace ChatGame.panels
{
    public partial class MainScreen : UserControl
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

        Screen screen;
        Chat chat;
        Service2Client client2;
        ServiceClient client;
        public Account account;
        messagePanel messagePanel;
        FriendList friendList;
        Games games;
        string activePanelMain;
        bool friendListClick = false, gameRoomsClick = false;
        List<messagePanel> messagePanelList;
        List<string> friendNameList;
        RoomsByGame roomsByGame;
        RoomPanel roomPanel;
        List<string[]> rooms;
        string room_game;
        Label labelGame;
        public MainScreen(Screen screen, Account account, Service2Client client2)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.screen = screen;
            this.account = account;
            this.client2 = client2;
            labelGame = labelGameName;

            textBoxUserName.Text = account.userName;
            textBoxUserName.Width = TextRenderer.MeasureText(textBoxUserName.Text, textBoxUserName.Font).Width;
            textBoxUserName.GotFocus += hideCaret;

            friendsMessagesDisplay();
            roomsDisplay();
        }

        private void hideCaret(object sender, EventArgs e)
        {
            HideCaret(textBoxUserName.Handle);
        }

        public void friendsMessagesDisplay()
        {
            client = new ServiceClient();
            friendNameList = client.getFriendsListWithMessage(account.userName).ToList<string>();
            messagePanelList = new List<messagePanel>();
            if (friendNameList.Count > 0)
            {
                for (int i = 0; i < friendNameList.Count; i++)
                {
                    messagePanel = new messagePanel(this, friendNameList[i]);
                    if (i > 0) messagePanel.Location = new Point(panelMessages.Controls[i - 1].Location.X, panelMessages.Controls[i - 1].Location.Y + 50);
                    panelMessages.Controls.Add(messagePanel);
                    messagePanelList.Add(messagePanel);
                }
            }
            messagePanel = null;
        }

        public void roomsDisplay()
        {
            panelRooms.Controls.Clear();
            client = new ServiceClient();
            rooms = client.getRooms(account.userName, "user").ToList<string[]>();
            if (rooms.Count > 0)
            {
                labelGame.Text = rooms[0][4] + ":";
                panelRooms.Controls.Add(labelGame);
                room_game = rooms[0][4];
                for (int i = 0; i < rooms.Count; i++)
                {
                    roomPanel = new RoomPanel(account.userName, int.Parse(rooms[i][0]), rooms[i][1], rooms[i][2], rooms[i][3], rooms[i][4], null, this);
                    roomPanel.Size = new Size(panelRooms.Width, roomPanel.Height);
                    if (i > 0)
                    {
                        if (room_game == rooms[i][4]) roomPanel.Location = new Point(0, panelRooms.Controls[panelRooms.Controls.Count - 1].Location.Y + 45);
                        else
                        {
                            Label game_name = new Label();
                            game_name.Font = labelGame.Font;
                            game_name.Text = rooms[i][4] + ":";
                            game_name.Location = new Point(3, panelRooms.Controls[panelRooms.Controls.Count - 1].Location.Y + 60);
                            panelRooms.Controls.Add(game_name);

                            roomPanel.Location = new Point(0, panelRooms.Controls[panelRooms.Controls.Count - 1].Location.Y + 26);
                            room_game = rooms[i][4];
                        }
                    }
                    else roomPanel.Location = new Point(0, 30);
                    panelRooms.Controls.Add(roomPanel);
                }
            }
        }

        public void openChatWithFriend(string friend_name)
        {
            bool openChat = false; 
            for (int i = 0; i < messagePanelList.Count; i++)
            {
                if (friend_name == messagePanelList[i].Controls[1].Text)
                {
                    messagePanelList[i].messagePanel_Click(null, null);
                    openChat = true;
                    break;
                }
            }

            if (!openChat)
            {
                allMessagePanelsDown();
                messagePanel = new messagePanel(this, friend_name);
                panelMessages.Controls.Add(messagePanel);
                messagePanelList.Add(messagePanel);
                messagePanel.messagePanel_Click(null, null);
            }
        }

        private void allMessagePanelsDown()
        {
            for (int i = 0; i < panelMessages.Controls.Count; i++)
            {
                panelMessages.Controls[i].Location = new Point(panelMessages.Controls[i].Location.X, panelMessages.Controls[i].Location.Y + 50);
            }
        }

        public void emptySpaceClick(object sender, EventArgs e)
        {
            screen.ActiveControl = null;
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();
            Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            if (hashCode == panelGamesTab.GetHashCode()) panelGamesTab.BackColor = Color.Silver;
            if (hashCode == labelGamesTab.GetHashCode()) panelGamesTab.BackColor = Color.Silver;
            if (hashCode == pictureBoxGamesTab.GetHashCode()) panelGamesTab.BackColor = Color.Silver;

            if (hashCode == panelFriendsTab.GetHashCode()) panelFriendsTab.BackColor = Color.Silver;
            if (hashCode == labelFriendsTab.GetHashCode()) panelFriendsTab.BackColor = Color.Silver;
            if (hashCode == pictureBoxFriendsTab.GetHashCode()) panelFriendsTab.BackColor = Color.Silver;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();
            Cursor = DefaultCursor;

            if (!gameRoomsClick)
            {
                if (hashCode == panelGamesTab.GetHashCode()) panelGamesTab.BackColor = Color.Gray;
                if (hashCode == labelGamesTab.GetHashCode()) panelGamesTab.BackColor = Color.Gray;
                if (hashCode == pictureBoxGamesTab.GetHashCode()) panelGamesTab.BackColor = Color.Gray;
            }
            if (!friendListClick)
            {
                if (hashCode == panelFriendsTab.GetHashCode()) panelFriendsTab.BackColor = Color.Gray;
                if (hashCode == labelFriendsTab.GetHashCode()) panelFriendsTab.BackColor = Color.Gray;
                if (hashCode == pictureBoxFriendsTab.GetHashCode()) panelFriendsTab.BackColor = Color.Gray;
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            screen.replacementLoginForm();
            client2.Disconnect(account.userName);
        }

        private void friendList_Click(object sender, EventArgs e)
        {
            if (!friendListClick)
            {
                replacmentFriendsList();
                panelFriendsTab.BackColor = Color.Silver;
                friendListClick = true;
            }
        }

        private void gameRooms_Click(object sender, EventArgs e)
        {
            if (!gameRoomsClick)
            {
                replacmentGameRooms(false);
                panelGamesTab.BackColor = Color.Silver;
                gameRoomsClick = true;
            }
        }

        public void replacmentChatFriend(string friend_name, messagePanel messagePanel, List<string[]> messages)
        {
            formReplacment();
            if (this.messagePanel == null) this.messagePanel = messagePanel;
            else
            {
                this.messagePanel.chatFriendClose();
                this.messagePanel = messagePanel;
            }
            chat = new Chat(this, account, client2, friend_name, messages);
            chat.Size = new Size(panelMain.Width, panelMain.Height);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(chat);
            activePanelMain = "ChatFriend";
        }

        private void replacmentFriendsList()
        {
            formReplacment();
            friendList = new FriendList(this, account);
            friendList.Size = new Size(panelMain.Width, panelMain.Height);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(friendList);
            activePanelMain = "FriendList";
        }

        public void replacmentGameRooms(bool back)
        {
            if (!back) formReplacment();
            games = new Games(this);
            games.Size = new Size(panelMain.Width, panelMain.Height);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(games);
            activePanelMain = "GameRooms";
        }

        public void replacmentRoomsByGame(string game_name)
        {
            roomsByGame = new RoomsByGame(this, game_name, client2);
            roomsByGame.Size = new Size(panelMain.Width, panelMain.Height);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(roomsByGame);
            activePanelMain = "GameRooms";
        }

        private void formReplacment()
        {
            if (activePanelMain == "ChatFriend")
            {
                messagePanel.chatFriendClose();
                messagePanel = null;
            }
            else if (activePanelMain == "FriendList")
            {
                friendListClick = false;
                panelFriendsTab.BackColor = Color.Gray;
            }
            else if (activePanelMain == "GameRooms")
            {
                gameRoomsClick = false;
                panelGamesTab.BackColor = Color.Gray;
            }
        }

        public void openRoom(string game_name, string room_name)
        {
            formReplacment();
            replacmentRoomsByGame(game_name);
            roomsByGame.openRoom(room_name);
            panelGamesTab.BackColor = Color.Silver;
            gameRoomsClick = true;
        }

        public void repositionMessagePanel(string friend_name, bool newMessage = false)
        {
            Point pos = new Point();
            for (int i = 0; i < panelMessages.Controls.Count; i++) 
                panelMessages.Controls[i].Location = new Point(panelMessages.Controls[i].Location.X, panelMessages.Controls[i].Location.Y + 50);

            for (int i = 0; i < messagePanelList.Count; i++)
            {
                if (messagePanelList[i].friendName == friend_name)
                {
                    pos = messagePanelList[i].Location;
                    messagePanelList[i].Location = new Point(0,0);
                    if (newMessage)
                    {
                        int newMessageCount = int.Parse(messagePanelList[i].labelUnreadMessagesCount.Text);
                        messagePanelList[i].labelUnreadMessagesCount.Text = $"{newMessageCount + 1}";
                        messagePanelList[i].labelUnreadMessagesCount.Visible = true;
                    }
                }
            }

            for (int i = 0; i < panelMessages.Controls.Count; i++)
                if (panelMessages.Controls[i].Location.Y > pos.Y) 
                    panelMessages.Controls[i].Location = new Point(panelMessages.Controls[i].Location.X, panelMessages.Controls[i].Location.Y - 50);
        }

        public void sendMessageFriendCallBack(string message, string sender, DateTime dateTime)
        {
            if (activePanelMain == "ChatFriend" && chat.friendName == sender)
            {
                chat.getMessage(message, dateTime);
                repositionMessagePanel(sender);
                client = new ServiceClient();
                string answer = client.messagesRead(sender, account.userName);
            }
            else
            {
                bool newSender = true;
                for (int i = 0; i < messagePanelList.Count; i++)
                {
                    if (messagePanelList[i].friendName == sender)
                    {
                        newSender = false;
                        break;
                    }
                }

                if (newSender)
                {
                    messagePanel = new messagePanel(this, sender);
                    if (panelMessages.Controls.Count > 0)
                    {
                        Point location = panelMessages.Controls[0].Location;
                        for (int i = 0; i < panelMessages.Controls.Count; i++)
                            if (location.Y < panelMessages.Controls[i].Location.Y) location = panelMessages.Controls[i].Location;
                        messagePanel.Location = new Point(0, location.Y + 50);
                    }
                    else messagePanel.Location = new Point(0, 0);
                    panelMessages.Controls.Add(messagePanel);
                    messagePanelList.Add(messagePanel);
                    repositionMessagePanel(sender);
                }
                else repositionMessagePanel(sender, true);
            }
        }

        public void banCallBack(int room_id, string game)
        {
            roomsDisplay();
            try
            {
                roomsByGame.banCallBack(room_id, game);
            }
            catch { }
        }

        public void SendMessageInRoomCallBack(int room_id, string user_name, string message, DateTime dateTime)
        {
            if (activePanelMain == "GameRooms")
            {
                try
                {
                    roomsByGame.SendMessageInRoomCallBack(room_id, user_name, message, dateTime);
                }
                catch { }
            } 
        }
    }
}
