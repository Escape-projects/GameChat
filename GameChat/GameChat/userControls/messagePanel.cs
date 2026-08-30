using ChatGame.panels;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Server;
using System.Collections.Generic;
using System.Linq;

namespace ChatGame.userControls
{
    public partial class messagePanel : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        MainScreen mainScreen;
        ServiceClient client;
        public string friendName;
        bool panelClick = false;

        public messagePanel(MainScreen mainScreen, string friendName)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            this.friendName = friendName;
            labelFriendName.Text = friendName;

            Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxAvatar.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            labelFriendName.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            lastMessageAndFriendNameRazmer();

            client = new ServiceClient();
            int answer = client.getUnreadMessagesCount(friendName, mainScreen.account.userName);
            if (answer > 0)
            {
                labelUnreadMessagesCount.Text = $"{answer}";
                labelUnreadMessagesCount.Visible = true;
            }
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            if (!panelClick)
            {
                int hashCode = sender.GetHashCode();

                if (hashCode == this.GetHashCode()) BackColor = Color.Silver;
                if (hashCode == pictureBoxAvatar.GetHashCode()) BackColor = Color.Silver;
                if (hashCode == labelFriendName.GetHashCode()) BackColor = Color.Silver;
                if (hashCode == labelUnreadMessagesCount.GetHashCode()) BackColor = Color.Silver;
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (!panelClick)
            {
                int hashCode = sender.GetHashCode();

                if (hashCode == this.GetHashCode()) BackColor = Color.Gray;
                if (hashCode == pictureBoxAvatar.GetHashCode()) BackColor = Color.Gray;
                if (hashCode == labelFriendName.GetHashCode()) BackColor = Color.Gray;
                if (hashCode == labelUnreadMessagesCount.GetHashCode()) BackColor = Color.Gray;
            }
        }

        public void messagePanel_Click(object sender, EventArgs e)
        {
            if (!panelClick)
            {
                client = new ServiceClient();
                List<string[]> messages = client.getMessages(mainScreen.account.userName, friendName).ToList<string[]>();
                mainScreen.replacmentChatFriend(friendName, this, messages);
                panelClick = true;
                BackColor = Color.Silver;
                if (labelUnreadMessagesCount.Visible)
                {
                    labelUnreadMessagesCount.Text = "+0";
                    labelUnreadMessagesCount.Visible = false;
                    client = new ServiceClient();
                    string answer = client.messagesRead(friendName, mainScreen.account.userName);
                }
            }
        }

        public void chatFriendClose()
        {
            panelClick = false;
            BackColor = Color.Gray;
        }

        public void lastMessageAndFriendNameRazmer()
        {
            if (labelFriendName.Width > Width - 45)
            {
                for (int i = labelFriendName.Width; i > Width - 45; i++)
                {
                    labelFriendName.Text = labelFriendName.Text.Remove(labelFriendName.Text.Length - 1);
                    i = labelFriendName.Width;
                }
                labelFriendName.Text = labelFriendName.Text.Remove(labelFriendName.Text.Length - 1);
                labelFriendName.Text = labelFriendName.Text.PadRight(labelFriendName.Text.Length + 3, '.');
            }
        }
    }
}
