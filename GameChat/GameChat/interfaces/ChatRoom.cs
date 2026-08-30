using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System;
using GameChat.userControls;
using GameChat.Server;
using GameChat.Service2;
using ChatGame.userControls;
using ChatGame;
using System.Collections.Generic;
using System.Linq;

namespace GameChat.panels
{
    public partial class ChatRoom : UserControl
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

        ServiceClient client;
        Service2Client client2;
        RoomsByGame roomsByGame;
        RoomPanel roomPanel;
        string user_status, room_name, user_name;
        int room_id;
        bool membersMax, newLine = false, sendMessage = false;

        public ChatRoom(RoomsByGame roomsByGame, RoomPanel roomPanel, int room_id, string room_name, string user_status, Service2Client client2, string user_name)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBoxExit.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));

            this.roomsByGame = roomsByGame;
            this.roomPanel = roomPanel;
            this.client2 = client2;
            this.user_status = user_status;
            this.room_id = room_id;
            this.room_name = room_name;
            this.user_name = user_name;

            textBoxRoomName.Text = room_name;
            textBoxRoomName.GotFocus += hideCaret;
            if (textBoxRoomName.Width > panelRoomName.Width - 90) roomNameChange();

            if (user_status == "создатель") pictureBoxExit.Image = Image.FromFile("icons/settings.png");

            messagesDisplay();
        }

        void messagesDisplay()
        {
            client = new ServiceClient();
            List<string[]> messages = client.getMessagesInRoom(room_id).ToList<string[]>();
            for (int i = 0; i < messages.Count; i++)
            {
                string message = messages[i][1];
                DateTime dateTime = DateTime.Parse(messages[i][2]);

                SendMessagePanel sendMessagePanel = new SendMessagePanel(messages[i][0], message, panelMessages.Controls.Count, dateTime, null, this);
                if (i == 0) sendMessagePanel.Width = panelMessages.Width;
                else sendMessagePanel.Width = panelMessages.Controls[i - 1].Width;
                if (panelMessages.Controls.Count == 0) sendMessagePanel.Location = new Point(0, 0);
                else sendMessagePanel.Location = new Point(0, panelMessages.Controls[panelMessages.Controls.Count - 1].Location.Y +
                                                              panelMessages.Controls[panelMessages.Controls.Count - 1].Height);
                panelMessages.Controls.Add(sendMessagePanel);
            }
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == textBoxMessage)
            {
                lineBreak();
            }
        }

        private void hideCaret(object sender, EventArgs e)
        {
            HideCaret(textBoxRoomName.Handle);
        }

        private void lineBreak()
        {
            if (TextRenderer.MeasureText(textBoxMessage.Text, textBoxMessage.Font).Width + 2 > textBoxMessage.Width && !newLine)
            {
                panelMessages.Height -= textBoxMessage.Height;
                textBoxMessage.Location = new Point(textBoxMessage.Location.X, textBoxMessage.Location.Y - textBoxMessage.Height);
                textBoxMessage.Size = new Size(textBoxMessage.Width, textBoxMessage.Height * 2);
                newLine = true;
            }
            if (TextRenderer.MeasureText(textBoxMessage.Text, textBoxMessage.Font).Width + 2 < textBoxMessage.Width && newLine)
            {
                textBoxMessage.Size = new Size(textBoxMessage.Width, textBoxMessage.Height / 2);
                textBoxMessage.Location = new Point(textBoxMessage.Location.X, textBoxMessage.Location.Y + textBoxMessage.Height);
                panelMessages.Height += textBoxMessage.Height;
                newLine = false;
            }
        }

        private bool spaceStringCheck()
        {
            bool probels = true; //переменная для проверки состоит ли строка сообщения только из пробелов
            for (int i = 0; i < textBoxMessage.Text.Length; i++)
            {
                if (textBoxMessage.Text[i] != ' ')
                {
                    probels = false;
                    break;
                }
            }
            return probels;
        }

        private void quitTextBoxMessage(KeyEventArgs e, bool logout = true)
        {
            e.SuppressKeyPress = true;
            if (logout)
            {
                roomsByGame.mainScreen.emptySpaceClick(null, null);
                textBoxMessage.Text = "Написать";
            }
            else textBoxMessage.Text = null;
            newLine = false;
        }

        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == $"Написать") textBoxMessage.Text = "";
        }

        private void textBoxMessage_Leave(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == "" || textBoxMessage.Text == " ")
            {
                textBoxMessage.Text = "Написать";
                newLine = false;
            }
            else
            {
                bool probels = spaceStringCheck();
                if (probels)
                {
                    textBoxMessage.Text = "Написать";
                    newLine = false;
                }
            }
        }

        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            bool probels = spaceStringCheck();

            if (e.KeyCode == Keys.Enter && probels == false)
            {
                string message = textBoxMessage.Text;
                DateTime dateTime = DateTime.Now;
                string answer = client2.SendMessageInRoom(room_id, user_name, message, dateTime);
                if (answer == "сообщение отправлено")
                {
                    sendMessage = true;
                    SendMessagePanel sendMessagePanel = new SendMessagePanel(user_name, message, panelMessages.Controls.Count, dateTime, null, this);
                    if (panelMessages.Controls.Count == 0) sendMessagePanel.Width = panelMessages.Width;
                    else sendMessagePanel.Width = panelMessages.Controls[panelMessages.Controls.Count - 1].Width;
                    if (panelMessages.Controls.Count == 0) sendMessagePanel.Location = new Point(0, 0);
                    else sendMessagePanel.Location = new Point(0, panelMessages.Controls[panelMessages.Controls.Count - 1].Location.Y +
                                                                  panelMessages.Controls[panelMessages.Controls.Count - 1].Height);
                    panelMessages.Controls.Add(sendMessagePanel);
                    sendMessage = false;
                }
                else if (answer == "ошибка") MessageBox.Show("ошибка, сообщение не отправлено");

                quitTextBoxMessage(e, false);
            }
            else if (e.KeyCode == Keys.Enter && probels)
            {
                quitTextBoxMessage(e);
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                string clipboardText = Clipboard.GetText();
                clipboardText = clipboardText.Replace("\r\n", " ");
                textBoxMessage.AppendText(clipboardText);
            }
        }

        public void getMessage(string user_name, string message, DateTime dateTime)
        {
            SendMessagePanel sendMessagePanel = new SendMessagePanel(user_name, message, panelMessages.Controls.Count, dateTime, null, this);
            if (panelMessages.Controls.Count == 0) sendMessagePanel.Width = panelMessages.Width;
            else sendMessagePanel.Width = panelMessages.Controls[panelMessages.Controls.Count - 1].Width;
            if (panelMessages.Controls.Count == 0) sendMessagePanel.Location = new Point(0, 0);
            else sendMessagePanel.Location = new Point(0, panelMessages.Controls[panelMessages.Controls.Count - 1].Location.Y +
                                                          panelMessages.Controls[panelMessages.Controls.Count - 1].Height);
            panelMessages.Controls.Add(sendMessagePanel);
        }

        private void panelMessages_ControlAdded(object sender, ControlEventArgs e)
        {
            if (sendMessage) panelMessages.ScrollControlIntoView(e.Control);
        }

        public void repositionAllMessages(int messageIndex)
        {
            for (int i = messageIndex + 1; i < panelMessages.Controls.Count; i++)
            {
                panelMessages.Controls[i].Location = new Point(0, panelMessages.Controls[i - 1].Location.Y + panelMessages.Controls[i - 1].Height);
            }
        }

        public void mouseWheel(object sender, MouseEventArgs e)
        {
            if (panelMessages.VerticalScroll.Visible == true)
            {
                if (e.Delta > 0) panelMessages.ScrollUp(-120);
                else if (panelMessages.VerticalScroll.Value < panelMessages.VerticalScroll.Maximum - panelMessages.ClientRectangle.Height + 1) panelMessages.ScrollDown(+120);
            }
        }

        private void ChatRoom_SizeChanged(object sender, EventArgs e)
        {
            if (Width != 0) lineBreak();
        }

        private void roomNameChange()
        {
            for (int i = textBoxRoomName.Width; i > panelRoomName.Width - 90; i++)
            {
                textBoxRoomName.Text = textBoxRoomName.Text.Remove(textBoxRoomName.Text.Length - 1);
                textBoxRoomName.Width = TextRenderer.MeasureText(textBoxRoomName.Text, textBoxRoomName.Font).Width;
                i = textBoxRoomName.Width;
            }
            textBoxRoomName.Text = textBoxRoomName.Text.Remove(textBoxRoomName.Text.Length - 1);
            textBoxRoomName.Text = textBoxRoomName.Text.PadRight(textBoxRoomName.Text.Length + 3, '.');
            textBoxRoomName.Width = TextRenderer.MeasureText(textBoxRoomName.Text, textBoxRoomName.Font).Width;
        }

        private void panelRoomName_SizeChanged(object sender, EventArgs e)
        {
            if (panelRoomName.Width != 0)
            {
                textBoxRoomName.Text = room_name;
                textBoxRoomName.Width = TextRenderer.MeasureText(textBoxRoomName.Text, textBoxRoomName.Font).Width;
                if (textBoxRoomName.Width > panelRoomName.Width - 90) roomNameChange();
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            if (user_status == "участник")
            {
                roomsByGame.panelRoom.Controls.Clear();
                roomPanel.panelClick = false;
                roomPanel.BackColor = Color.Gray;
                membersMax = roomPanel.membersMaxCount;
                client = new ServiceClient();
                string answer = client.roomExit(roomsByGame.mainScreen.account.userName, room_id, membersMax);
                if (answer == "покинул комнату") roomsByGame.mainScreen.roomsDisplay();
                else if (answer == "ошибка") MessageBox.Show(answer);
                roomsByGame.roomsDisplay();
            }
            else
            {
                roomsByGame.replacmentRoomSetting(room_name, room_id, roomPanel.password);
                roomPanel.panelClick = false;
            }
        }
    }

    public static class PanelExtension
    {
        public static void ScrollDown(this Panel p, int pos)
        {
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
            {
                p.ScrollControlIntoView(c);
            }
        }
        public static void ScrollUp(this Panel p, int pos)
        {
            using (Control c = new Control() { Parent = p, Height = 1, Top = pos })
            {
                p.ScrollControlIntoView(c);
            }
        }
    }
}
