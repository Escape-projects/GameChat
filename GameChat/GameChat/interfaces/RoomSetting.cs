using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;
using GameChat.panels;
using GameChat.Server;
using System.Collections.Generic;
using System.Linq;
using GameChat.userControls;
using GameChat.Service2;

namespace GameChat.interfaces
{
    public partial class RoomSetting : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        public RoomsByGame roomsByGame;
        ServiceClient client;
        Service2Client client2;
        MemberPanel memberPanel;
        bool Glaz = true;
        string room_name;
        public int room_id;
        List<string[]> members;

        public RoomSetting(RoomsByGame roomsByGame, string room_name, int room_id, bool password, Service2Client client2)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            buttonChangePassword.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            buttonDeleteRoom.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxGlaz.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxBack.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            this.roomsByGame = roomsByGame;
            this.client2 = client2;
            this.room_name = room_name;
            this.room_id = room_id;
            labelRoomName.Text = room_name;
            if (labelRoomName.Width > panelRoomName.Width - 90) roomNameChange();
            if (!password)
            {
                labelChangePassword.Visible = false;
                textBoxPassword.Visible = false;
                pictureBoxGlaz.Visible = false;
                buttonChangePassword.Visible = false;
            }

            client = new ServiceClient();
            members = client.getMembers(room_id).ToList<string[]>();
            membersDisplay(members);
        }

        public void membersDisplay(List<string[]> members)
        { 
            panelMembers.Controls.Clear();
            if (members == null) 
            {
                client = new ServiceClient();
                this.members = client.getMembers(room_id).ToList<string[]>();
                members = this.members;
            }
            for (int i = 0; i < members.Count; i++)
            {
                memberPanel = new MemberPanel(this, members[i][0], members[i][1], client2);
                memberPanel.Size = new Size(panelMembers.Width, memberPanel.Height);
                if (i > 0) memberPanel.Location = new Point(panelMembers.Controls[i - 1].Location.X, panelMembers.Controls[i - 1].Location.Y + 50);
                panelMembers.Controls.Add(memberPanel);
            }
        }

        private void roomNameChange()
        {
            for (int i = labelRoomName.Width; i > panelRoomName.Width - 90; i++)
            {
                labelRoomName.Text = labelRoomName.Text.Remove(labelRoomName.Text.Length - 1);
                i = labelRoomName.Width;
            }
            labelRoomName.Text = labelRoomName.Text.Remove(labelRoomName.Text.Length - 1);
            labelRoomName.Text = labelRoomName.Text.PadRight(labelRoomName.Text.Length + 3, '.');
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "Поиск" && textBoxSearch.Text != "")
            {
                List<string[]> membersSearch = new List<string[]>();
                for (int i = 0; i < members.Count; i++)
                {
                    if (members[i][0].StartsWith(textBoxSearch.Text))
                    {
                        membersSearch.Add(members[i]);
                    }
                }
                membersDisplay(membersSearch);
            }
            else membersDisplay(members);
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск") textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "" || textBoxSearch.Text == " ") textBoxSearch.Text = "Поиск";
        }

        private void glaz_Click(object sender, EventArgs e)
        {
            if (Glaz)
            {
                pictureBoxGlaz.Image = Image.FromFile("icons/glaz.png");
                Glaz = false;
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBoxGlaz.Image = Image.FromFile("icons/glaz2.png");
                Glaz = true;
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            roomsByGame.openRoom(room_name);
        }

        private void RoomSetting_SizeChanged(object sender, EventArgs e)
        {
            if (Width > 0)
            {
                labelRoomName.Text = room_name;
                if (labelRoomName.Width > panelRoomName.Width - 90) roomNameChange();
            }
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            client = new ServiceClient();
            string answer = client.roomSetting("удалить комнату", room_id.ToString());
            if (answer == "комната удалена")
            {
                roomsByGame.panelRoom.Controls.Clear();
                roomsByGame.roomsDisplay();
                roomsByGame.mainScreen.roomsDisplay();
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length > 5)
            {
                client = new ServiceClient();
                string answer = client.roomSetting("сменить пароль", $"{room_id.ToString()};{textBoxPassword.Text}");
                if (answer == "пароль изменён")
                {
                    textBoxPassword.Text = "";
                    MessageBox.Show(answer);
                }
            }
            else
            {
                labelError.Text = "пароль меньше 6 символов";
                labelError.Visible = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        void emptySpaceClick(object sender, EventArgs e)
        {
            roomsByGame.mainScreen.emptySpaceClick(null, null);
        }
    }
}
