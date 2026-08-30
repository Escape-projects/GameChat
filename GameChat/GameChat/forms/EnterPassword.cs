using System;
using System.Windows.Forms;
using System.Drawing;
using GameChat.panels;
using GameChat.userControls;
using System.Runtime.InteropServices;

namespace GameChat.forms
{
    public partial class EnterPassword : Form
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        string password;
        bool Glaz;
        RoomPanel roomPanel;

        public EnterPassword(RoomPanel roomPanel, string room_name, string password)
        {
            InitializeComponent();
            this.roomPanel = roomPanel;
            this.password = password;
            labelRoomName.Text = room_name;
            labelRoomName.Location = new Point((panel.Width - labelRoomName.Width) / 2, labelRoomName.Location.Y);
            pictureBoxGlaz.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
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

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void EnterPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBoxPassword.Text != password) roomPanel.panelClick = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == password)
            {
                roomPanel.openRoom(true, "участник");
                Close();
            }
            else
            {
                labelError.Text = "неверный пароль";
                labelError.Visible = true;
            }
        }
    }
}
