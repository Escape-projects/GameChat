using GameChat.interfaces;
using GameChat.Server;
using GameChat.Service2;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GameChat.userControls
{
    public partial class MemberPanel : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        ServiceClient client;
        Service2Client client2;
        RoomSetting roomSetting;
        string user_name;

        public MemberPanel(RoomSetting roomSetting, string user_name, string user_status, Service2Client client2)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pictureBoxKickOut.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            buttonCancel.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            this.client2 = client2;
            this.roomSetting = roomSetting;
            this.user_name = user_name;
            labelMemberName.Text = user_name;

            if (user_status == "создатель") pictureBoxKickOut.Visible = false;
            else if (user_status == "забанен")
            {
                pictureBoxKickOut.Visible = false;
                buttonCancel.Visible = true;
                labelMemberName.Text += " (забанен)";
            }
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();

            if (hashCode == pictureBoxKickOut.GetHashCode()) BackColor = Color.Silver;
            if (hashCode == buttonCancel.GetHashCode()) BackColor = Color.Silver;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            int hashCode = sender.GetHashCode();

            if (hashCode == pictureBoxKickOut.GetHashCode()) BackColor = Color.DimGray;
            if (hashCode == buttonCancel.GetHashCode()) BackColor = Color.DimGray;
        }

        private void pictureBoxKickOut_Click(object sender, EventArgs e)
        {
            string answer = client2.ban(roomSetting.room_id, user_name, roomSetting.roomsByGame.game_name);
            if (answer == "пользователь забанен")
            {
                roomSetting.membersDisplay(null);
                roomSetting.roomsByGame.roomsDisplay();
                roomSetting.roomsByGame.mainScreen.roomsDisplay();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            client = new ServiceClient();
            string answer = client.roomSetting("разбанить участника", $"{roomSetting.room_id};{user_name}");
            if (answer == "пользователь разбанен")
            {
                roomSetting.membersDisplay(null);
            }
        }
    }
}
