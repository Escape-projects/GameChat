using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Server;
using GameChat.userControls;

namespace ChatGame.panels
{
    public partial class FriendList : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        public MainScreen mainScreen;
        Account account;
        public string activePanel;
        string type;
        ServiceClient client;

        public FriendList(MainScreen mainScreen, Account account)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.mainScreen = mainScreen;
            this.account = account;

            labelOnline.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            labelAll.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            label_invitations.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            labelFriendAdd.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            replacmentOnline();
        }

        private void FriendsListDisplay(List<string> friends)
        {
            panelFriendList.Controls.Clear();
            for (int i = 0; i < friends.Count; i++)
            {
                FriendPanel friend = new FriendPanel(this, account.userName, friends[i]);
                friend.Size = new Size(panelFriendList.Width, 55);
                friend.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                if (type == "полученные приглашения")
                {
                    friend.pictureBoxAccept.Enabled = true;
                    friend.pictureBoxAccept.Visible = true;
                }
                if (i > 0) friend.Location = new Point(panelFriendList.Controls[i - 1].Location.X, panelFriendList.Controls[i - 1].Location.Y + 55);
                panelFriendList.Controls.Add(friend);
            }
        }

        public void replacmentOnline()
        {
            type = "друзья в сети";
            mainScreen.emptySpaceClick(null, null);
            textBoxSearch.Text = "Поиск";
            buttonAddFriend.Visible = false;
            labelActive(labelOnline);
            labelActivePanel.Text = "Друзей в сети";
            panelFriendList.Controls.Clear();

            client = new ServiceClient();
            List<string> friends = client.getFriendList(account.userName, "друзья в сети").ToList<string>();
            FriendsListDisplay(friends);

            labelActivePanel.Text += $" - {panelFriendList.Controls.Count}";
            activePanel = "Online";
        }

        public void replacmentAll()
        {
            type = "все друзья";
            mainScreen.emptySpaceClick(null, null);
            textBoxSearch.Text = "Поиск";
            buttonAddFriend.Visible = false;
            labelActive(labelAll);
            labelActivePanel.Text = "Всего друзей";
            panelFriendList.Controls.Clear();

            client = new ServiceClient();
            List<string> friends = client.getFriendList(account.userName, "все друзья").ToList<string>();
            FriendsListDisplay(friends);

            labelActivePanel.Text += $" - {panelFriendList.Controls.Count}";
            activePanel = "All";
        }

        public void replacmentInvitations()
        {
            type = "полученные приглашения";
            mainScreen.emptySpaceClick(null, null);
            textBoxSearch.Text = "Поиск";
            buttonAddFriend.Visible = false;
            labelActive(label_invitations);
            labelActivePanel.Text = "Приглашений";
            panelFriendList.Controls.Clear();

            client = new ServiceClient();
            List<string> friends = client.getFriendList(account.userName, "полученные приглашения").ToList<string>();
            FriendsListDisplay(friends);

            labelActivePanel.Text += $" - {panelFriendList.Controls.Count}";
            activePanel = "Invitations";
        }

        public void replacmentFriendAdd()
        {
            type = "отправленные приглашения";
            mainScreen.emptySpaceClick(null, null);
            textBoxSearch.Text = "Введите имя пользователя";
            buttonAddFriend.Visible = true;
            labelActive(labelFriendAdd);
            labelActivePanel.Text = "Отправленные приглашения";
            panelFriendList.Controls.Clear();

            client = new ServiceClient();
            List<string> friends = client.getFriendList(account.userName, "отправленные приглашения").ToList<string>();
            FriendsListDisplay(friends);

            labelActivePanel.Text += $" - {panelFriendList.Controls.Count}";
            activePanel = "FriendAdd";
        }

        private void label_click(Object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();

            if (hashCode == labelOnline.GetHashCode() && activePanel != "Online")
            {
                replacmentOnline();
            }
            if (hashCode == labelAll.GetHashCode() && activePanel != "All")
            {
                replacmentAll();
            }
            if (hashCode == label_invitations.GetHashCode() && activePanel != "Invitations")
            {
                replacmentInvitations();
            }
            if (hashCode == labelFriendAdd.GetHashCode() && activePanel != "FriendAdd")
            {
                replacmentFriendAdd();
            }
        }

        private void labelActive(Label label)
        {
            if (label == labelOnline) labelOnline.BackColor = Color.DimGray;
            else labelOnline.BackColor = Color.Gray;

            if (label == labelAll) labelAll.BackColor = Color.DimGray;
            else labelAll.BackColor = Color.Gray;

            if (label == label_invitations) label_invitations.BackColor = Color.DimGray;
            else label_invitations.BackColor = Color.Gray;

            if (label == labelFriendAdd) labelFriendAdd.BackColor = Color.DimGray;
            else labelFriendAdd.BackColor = Color.Gray;
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск" || textBoxSearch.Text == "Введите имя пользователя") textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (activePanel == "FriendAdd")
            {
                if (textBoxSearch.Text == "" || textBoxSearch.Text == " ") textBoxSearch.Text = "Введите имя пользователя";
            }
            else if (textBoxSearch.Text == "" || textBoxSearch.Text == " ") textBoxSearch.Text = "Поиск";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (activePanel != "FriendAdd" && textBoxSearch.Text != "Поиск" && textBoxSearch.Text != "")
            {
                client = new ServiceClient();
                List<string> friendsBefore = client.getFriendList(account.userName, type).ToList<string>();
                List<string> friendsAfter = new List<string>();
                for (int i = 0; i < friendsBefore.Count; i++)
                {
                    if (friendsBefore[i].StartsWith(textBoxSearch.Text))
                    {
                        friendsAfter.Add(friendsBefore[i]);
                    }
                }
                FriendsListDisplay(friendsAfter);
            }
            if (activePanel != "FriendAdd" && textBoxSearch.Text == "" || textBoxSearch.Text == "Поиск")
            {
                client = new ServiceClient();
                List<string> friends = client.getFriendList(account.userName, type).ToList<string>();
                FriendsListDisplay(friends);
            }
        }

        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length < 4) MessageBox.Show("Имя не может содержать менее 4 символов");
            else if (textBoxSearch.Text == account.userName) MessageBox.Show("это ваше имя");
            else
            {
                client = new ServiceClient();
                string answer = client.FriendAdd(account.userName, textBoxSearch.Text);
                if (answer == "приглашение отправлено")
                {
                    textBoxSearch.Text = "Введите имя пользователя";
                    MessageBox.Show(answer);
                    replacmentFriendAdd();
                }
                else MessageBox.Show(answer);
            }
        }

        private void emptySpaceClick(object sender, EventArgs e)
        {
            mainScreen.emptySpaceClick(null, null);
        }
    }
}
