using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;
using ChatGame.panels;
using GameChat.Server;
using System.Collections.Generic;

namespace GameChat.userControls
{
    public partial class FriendPanel : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        FriendList friendList;
        ServiceClient client;
        string userNameUser, userNameFriend;

        public FriendPanel(FriendList friendList, string userNameUser, string userNameFriend)
        {
            InitializeComponent();
            this.friendList = friendList;
            this.userNameUser = userNameUser;
            this.userNameFriend = userNameFriend;
            labelFriendName.Text = userNameFriend;

            pictureBoxAccept.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxOverrule.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();

            if (hashCode == GetHashCode()) BackColor = Color.Gray;
            if (hashCode == pictureBoxAvatar.GetHashCode()) BackColor = Color.Gray;
            if (hashCode == labelFriendName.GetHashCode()) BackColor = Color.Gray;
            if (hashCode == pictureBoxAccept.GetHashCode()) BackColor = Color.Gray;
            if (hashCode == pictureBoxOverrule.GetHashCode()) BackColor = Color.Gray;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();

            if (hashCode == GetHashCode()) BackColor = Color.DimGray;
            if (hashCode == pictureBoxAvatar.GetHashCode()) BackColor = Color.DimGray;
            if (hashCode == labelFriendName.GetHashCode()) BackColor = Color.DimGray;
            if (hashCode == pictureBoxAccept.GetHashCode()) BackColor = Color.DimGray;
            if (hashCode == pictureBoxOverrule.GetHashCode()) BackColor = Color.DimGray;
        }

        private void pictureBoxOverrule_Click(object sender, EventArgs e)
        {
            client = new ServiceClient();
            string answer = client.unfriend(userNameUser, userNameFriend);
            if (answer == "ошибка") MessageBox.Show(answer);
            else if (answer == "удалён")
            {
                if (friendList.activePanel == "Online") friendList.replacmentOnline();
                if (friendList.activePanel == "All") friendList.replacmentAll();
                if (friendList.activePanel == "Invitations") friendList.replacmentInvitations();
                if (friendList.activePanel == "FriendAdd") friendList.replacmentFriendAdd();
            }
        }

        private void pictureBoxAccept_Click(object sender, EventArgs e)
        {
            client = new ServiceClient();
            string answer = client.acceptInvation(userNameUser, userNameFriend);
            if (answer == "ошибка") MessageBox.Show(answer);
            else if (answer == "приглашение принято") friendList.replacmentInvitations();
        }

        private void click(object sender, EventArgs e)
        {
            friendList.mainScreen.openChatWithFriend(userNameFriend);
        }
    }
}
