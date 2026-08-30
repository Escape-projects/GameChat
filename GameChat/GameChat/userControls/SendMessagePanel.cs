using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ChatGame.panels;
using GameChat.panels;

namespace ChatGame.userControls
{
    public partial class SendMessagePanel : UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        Chat chat;
        ChatRoom chatRoom;
        int row_count;
        bool oneLine;
        int messageIndex;

        public SendMessagePanel(string userName, string message, int messageIndex, DateTime dateTime, Chat chat = null, ChatRoom chatRoom = null)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.chat = chat;
            this.chatRoom = chatRoom;
            this.messageIndex = messageIndex;

            textBoxUserName.Text = userName;
            textBoxUserName.Width = TextRenderer.MeasureText(textBoxUserName.Text, textBoxUserName.Font).Width;

            textBoxMessage.Text = message;

            labelDateTime.Text = dateTime.ToString("MM/dd/yyyy HH:mm");
            labelDateTime.Location = new Point(textBoxUserName.Location.X + textBoxUserName.Width, labelDateTime.Location.Y);

            textBoxUserName.GotFocus += hideCaret;
            textBoxMessage.GotFocus += hideCaret;

            if (chat != null) textBoxMessage.MouseWheel += chat.mouseWheel;
            else if (chatRoom != null) textBoxMessage.MouseWheel += chatRoom.mouseWheel;
        }

        private void hideCaret(object sender, EventArgs e)
        {
            HideCaret(textBoxUserName.Handle);
            HideCaret(textBoxMessage.Handle);
        }

        private void SendMessagePanel_SizeChanged(object sender, EventArgs e)
        {
            if (Width != 0)
            {
                if (TextRenderer.MeasureText(textBoxMessage.Text, textBoxMessage.Font).Width > textBoxMessage.Width + 3 /*|| textBoxMessage.Text.Contains("\r\n")*/)
                {
                    int lineCount = 0;
                    lineCount += TextRenderer.MeasureText(textBoxMessage.Text, textBoxMessage.Font).Width / textBoxMessage.Width;
                    //lineCount += textBoxMessage.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).Length - 1;
                    Height = 58 + (18 * lineCount);
                    oneLine = false;
                    if (chat != null) chat.repositionAllMessages(messageIndex);
                    else if (chatRoom != null) chatRoom.repositionAllMessages(messageIndex);
                }
                else if (TextRenderer.MeasureText(textBoxMessage.Text, textBoxMessage.Font).Width <= textBoxMessage.Width + 3 && !oneLine)
                {
                    Height = 58;
                    oneLine = true;
                    if (chat != null) chat.repositionAllMessages(messageIndex);
                    else if (chatRoom != null) chatRoom.repositionAllMessages(messageIndex);
                }
            }
        }

        private void SendMessagePanel_BackColorChanged(object sender, EventArgs e)
        {
            if (BackColor == Color.DimGray)
            {
                textBoxMessage.BackColor = Color.DimGray;
                textBoxUserName.BackColor = Color.DimGray;
            }
            if (BackColor == Color.Silver)
            {
                textBoxMessage.BackColor = Color.Silver;
                textBoxUserName.BackColor = Color.Silver;
            }
        }
    }
}
