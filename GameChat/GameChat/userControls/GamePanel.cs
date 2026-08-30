using ChatGame.panels;
using GameChat.Server;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GameChat.userControls
{
    public partial class GamePanel : UserControl
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

        public GamePanel(MainScreen mainScreen, string game_name)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            pictureBoxGame.SizeMode = PictureBoxSizeMode.StretchImage;
            labelGame.Text = game_name;
            labelGame.Location = new Point((Width - labelGame.Width) / 2, labelGame.Location.Y);
            client = new ServiceClient();
            pictureBoxGame.Image = image(client.getImageGame(game_name));
            pictureBoxGame.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
        }

        private Image image(byte[] bytes)
        {
            var ms = new MemoryStream(bytes);
            var image = Image.FromStream(ms);
            return image;
        }

        private void pictureBoxGame_Click(object sender, EventArgs e)
        {
            mainScreen.replacmentRoomsByGame(labelGame.Text);
        }
    }
}
