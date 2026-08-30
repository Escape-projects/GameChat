using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ChatGame.panels;
using GameChat.forms;
using GameChat.panels;
using GameChat.Server;

namespace GameChat.userControls
{
    public partial class RoomPanel : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        public bool panelClick = false, membersMaxCount = false;
        int room_id;
        public bool password = false;
        string user_name, pass, game_name;
        public string room_name;
        int membersMax = 0, membersCurrent = 0;
        ServiceClient client;
        EnterPassword enterPassword;
        RoomsByGame roomsByGame;
        MainScreen mainScreen;

        public RoomPanel(string user_name, int room_id, string room_name, string password, string members, 
                        string game_name = null, RoomsByGame roomsByGame = null, MainScreen mainScreen = null)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxPassword.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            labelRoomName.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            labelMembers.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            this.roomsByGame = roomsByGame;
            this.mainScreen = mainScreen;
            this.user_name = user_name;
            this.room_id = room_id;
            this.room_name = room_name;
            this.game_name = game_name;
            labelRoomName.Text = room_name;
            if (labelRoomName.Width > Width - 56) roomNameChange();

            if (password != "null")
            {
                pictureBoxPassword.Image = Image.FromFile("icons/lock.png");
                this.password = true;
                pass = password;
            }
            if (members != "null")
            {
                membersMaxCount = true;
                labelMembers.Text = members;
                labelMembers.Visible = true;
                membersCurrent = int.Parse(members.Split('/')[0]);
                membersMax = int.Parse(members.Split('/')[1]);
            }
        }

        private void roomNameChange()
        {
            for (int i = labelRoomName.Width; i > Width - 56; i++)
            {
                labelRoomName.Text = labelRoomName.Text.Remove(labelRoomName.Text.Length - 1);
                i = labelRoomName.Width;
            }
            labelRoomName.Text = labelRoomName.Text.Remove(labelRoomName.Text.Length - 1);
            labelRoomName.Text = labelRoomName.Text.PadRight(labelRoomName.Text.Length + 3, '.');
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            if (!panelClick)
            {
                int hashCode = sender.GetHashCode();

                if (hashCode == this.GetHashCode()) BackColor = Color.Silver;
                if (hashCode == pictureBoxPassword.GetHashCode()) BackColor = Color.Silver;
                if (hashCode == labelRoomName.GetHashCode()) BackColor = Color.Silver;
                if (hashCode == labelMembers.GetHashCode()) BackColor = Color.Silver;
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (!panelClick)
            {
                int hashCode = sender.GetHashCode();

                if (hashCode == this.GetHashCode()) BackColor = Color.Gray;
                if (hashCode == pictureBoxPassword.GetHashCode()) BackColor = Color.Gray;
                if (hashCode == labelRoomName.GetHashCode()) BackColor = Color.Gray;
                if (hashCode == labelMembers.GetHashCode()) BackColor = Color.Gray;
            }
        }

        private void RoomPanel_SizeChanged(object sender, EventArgs e)
        {
            labelRoomName.Text = room_name;
            if (labelRoomName.Width > Width - 56) roomNameChange();
        }

        public void RoomPanel_Click(object sender, EventArgs e)
        {
            if (!panelClick)
            {
                if (roomsByGame != null)
                {
                    client = new ServiceClient();
                    string answer = client.joinRoom(room_id, user_name, true);

                    if (answer == "создатель" || answer == "участник")
                    {
                        openRoom(false, answer);
                    }
                    else if (answer == "забанен") MessageBox.Show("Вас забанили в этой комнате");
                    else if (answer == "не является участником комнаты" && !password)
                    {
                        if (membersMax == 0 || (membersMax != 0 && membersCurrent < membersMax))
                        {
                            openRoom(true, "участник");
                        }
                        else if (membersMax != 0 && membersCurrent == membersMax) MessageBox.Show("Комната переполнена");
                    }
                    else if (answer == "не является участником комнаты" && password)
                    {
                        if (membersMax != 0 && membersCurrent < membersMax)
                        {
                            enterPassword = new EnterPassword(this, room_name, pass);
                            enterPassword.Show();
                            panelClick = true;
                            BackColor = Color.Gray;
                        }
                        else if (membersMax != 0 && membersCurrent == membersMax) MessageBox.Show("Комната переполнена");
                    }
                }
                else 
                {
                    mainScreen.openRoom(game_name, room_name);
                }
            }
        }

        public void openRoom(bool newMember, string user_status)
        {
            roomsByGame.replacmentRoom(room_id, room_name, this, user_status);
            BackColor = Color.Silver;
            panelClick = true;
            if (newMember)
            {
                string answer = client.joinRoom(room_id, user_name, false);
                labelMembers.Text = $"{membersCurrent + 1}/{membersMax}";
                mainScreen.roomsDisplay();
            }
        }
    }
}
