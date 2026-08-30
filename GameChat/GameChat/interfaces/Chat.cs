using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Service2;
using ChatGame.userControls;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ChatGame.panels
{
    public partial class Chat : UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        MainScreen mainScreen;
        Account account;
        bool sendMessage = false, newLine = false;
        Service2Client client2;
        public string friendName;
        List<string[]> messages;

        public Chat(MainScreen mainScreen, Account account, Service2Client client2, string friendName, List<string[]> messages)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.mainScreen = mainScreen;
            this.account = account;
            this.friendName = friendName;
            this.client2 = client2;
            textBoxMessage.Text = "Написать " + friendName;
            this.messages = messages;

            textBoxFriendName.Text = friendName;
            textBoxFriendName.Width = TextRenderer.MeasureText(textBoxFriendName.Text, textBoxFriendName.Font).Width;
            textBoxFriendName.GotFocus += hideCaret;

            messagesDisplay();
        }

        void messagesDisplay()
        {
            for (int i = 0; i < messages.Count; i++)
            {
                string message = messages[i][1];
                DateTime dateTime = DateTime.Parse(messages[i][2]);

                SendMessagePanel sendMessagePanel = new SendMessagePanel(messages[i][0], message, panelMessages.Controls.Count, dateTime, this);
                if (i == 0) sendMessagePanel.Size = new Size(panelMessages.Width, sendMessagePanel.Height);
                else sendMessagePanel.Size = new Size(panelMessages.Controls[i - 1].Width, sendMessagePanel.Height);
                if (i == 0) sendMessagePanel.Location = new Point(0, 0);
                else sendMessagePanel.Location = new Point(0, panelMessages.Controls[i - 1].Location.Y +
                                                              panelMessages.Controls[i - 1].Height);
                panelMessages.Controls.Add(sendMessagePanel);
            }
        }

        private void hideCaret(object sender, EventArgs e)
        {
            HideCaret(textBoxFriendName.Handle);
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
                mainScreen.emptySpaceClick(null, null);
                textBoxMessage.Text = "Написать " + friendName;
            }
            else textBoxMessage.Text = null;
            newLine = false;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl == textBoxMessage)
            {
                lineBreak();
            }
        }

        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == $"Написать {friendName}") textBoxMessage.Text = "";
        }

        private void textBoxMessage_Leave(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == "" || textBoxMessage.Text == " ")
            {
                textBoxMessage.Text = "Написать " + friendName;
                newLine = false;
            }
            else
            {
                bool probels = spaceStringCheck();
                if (probels)
                {
                    textBoxMessage.Text = "Написать " + friendName;
                    newLine = false;
                }
            }
        }

        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            bool probels = spaceStringCheck();

            if (e.KeyCode == Keys.Enter && probels == false)
            {
                string answer;
                string message = textBoxMessage.Text;
                DateTime dateTime = DateTime.Now;
                answer = client2.SendMessageFriend(message, account.userName, friendName, dateTime);
                if (answer == "сообщение отправлено")
                {
                    sendMessage = true;
                    SendMessagePanel sendMessagePanel = new SendMessagePanel(account.userName, message, panelMessages.Controls.Count, dateTime, this);
                    if (panelMessages.Controls.Count == 0) sendMessagePanel.Size = new Size(panelMessages.Width, sendMessagePanel.Height);
                    else sendMessagePanel.Size = new Size(panelMessages.Controls[panelMessages.Controls.Count - 1].Width, sendMessagePanel.Height);
                    if (panelMessages.Controls.Count == 0) sendMessagePanel.Location = new Point(0, 0);
                    else sendMessagePanel.Location = new Point(0, panelMessages.Controls[panelMessages.Controls.Count - 1].Location.Y + 
                                                                  panelMessages.Controls[panelMessages.Controls.Count - 1].Height);
                    panelMessages.Controls.Add(sendMessagePanel);
                    mainScreen.repositionMessagePanel(friendName);
                    sendMessage = false;
                }
                else if (answer == "ошибка") MessageBox.Show("ошибка, сообщение не отправлено");

                quitTextBoxMessage(e, false);
            }
            else if (e.KeyCode == Keys.Enter && probels)
            {
                quitTextBoxMessage(e);
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                string clipboardText = Clipboard.GetText();
                clipboardText = clipboardText.Replace("\r\n", "").Replace("\n", "");
                textBoxMessage.AppendText(clipboardText);
            }
        }

        public void getMessage(string message, DateTime dateTime)
        {
            SendMessagePanel sendMessagePanel = new SendMessagePanel(friendName, message, panelMessages.Controls.Count, dateTime, this);
            if (panelMessages.Controls.Count == 0) sendMessagePanel.Size = new Size(panelMessages.Width, sendMessagePanel.Height);
            else sendMessagePanel.Size = new Size(panelMessages.Controls[panelMessages.Controls.Count - 1].Width, sendMessagePanel.Height);
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

        private void Chat_SizeChanged(object sender, EventArgs e)
        {
            if (Width != 0) lineBreak();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            lineBreak();
        }

        private void panelFriendName_Click(object sender, EventArgs e)
        {
            mainScreen.emptySpaceClick(null, null);
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
