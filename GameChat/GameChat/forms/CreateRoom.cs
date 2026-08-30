using GameChat.panels;
using GameChat.Server;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GameChat
{
    public partial class CreateRoom : Form
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        bool Glaz;
        string game, user_name;
        ServiceClient client;
        RoomsByGame roomsByGame;

        public CreateRoom(RoomsByGame roomsByGame, string game, string user_name)
        {
            InitializeComponent();
            this.roomsByGame = roomsByGame;
            this.game = game;
            this.user_name = user_name;
            pictureBoxGlaz.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxRoomName.Text.Length < 4)
            {
                labelErrorRN.Text = "Имя комнаты не может быть меньше 4 символов";
                labelErrorRN.Visible = true;
            }
            else if (checkBoxPassword.Checked && textBoxPassword.Text.Length < 6)
            {
                labelErrorPass.Text = "Пароль не может быть меньше 6 символов";
                labelErrorPass.Visible = true;
            }
            else
            {
                string password = textBoxPassword.Text;
                int members = (int)numUDMembers.Value;
                if (!checkBoxPassword.Checked) password = "null";
                if (!checkBoxMembers.Checked) members = 0;
                client = new ServiceClient();
                string answer = client.createRoom(user_name, game, textBoxRoomName.Text, password, members);
                if (answer == "Имя комнаты уже существует в этой игре")
                {
                    labelErrorRN.Text = answer;
                    labelErrorRN.Visible = true;
                }
                else if (answer == "ошибка") MessageBox.Show(answer);
                else if (answer == "комната создана")
                {
                    roomsByGame.roomsDisplay();
                    roomsByGame.openRoom(textBoxRoomName.Text);
                    roomsByGame.mainScreen.roomsDisplay();
                    Close();
                }
            }
        }

        private void checkBoxMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMembers.Checked)
            {
                numUDMembers.Enabled = true;
                numUDMembers.BackColor = Color.LightGray;
            }
            else
            {
                numUDMembers.Enabled = false;
                numUDMembers.BackColor = Color.WhiteSmoke;
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            labelErrorPass.Visible = false;
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.Enabled = true;
                textBoxPassword.BackColor = Color.LightGray;
                pictureBoxGlaz.Enabled = true;
                pictureBoxGlaz.BackColor = Color.LightGray;
            }
            else
            {
                textBoxPassword.Enabled = false;
                textBoxPassword.BackColor = Color.WhiteSmoke;
                pictureBoxGlaz.Enabled = false;
                pictureBoxGlaz.BackColor = Color.WhiteSmoke;
            }
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

        public void emptySpaceClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void textBoxRoomName_TextChanged(object sender, EventArgs e)
        {
            labelErrorRN.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelErrorPass.Visible = false;
        }

        private void CreateRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            roomsByGame.buttonCreateClick = false;
        }
    }
}
