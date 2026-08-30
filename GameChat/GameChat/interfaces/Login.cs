using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Server;

namespace ChatGame.panels
{
    public partial class Login : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        Screen screen;
        bool Glaz = true;
        ServiceClient client;
        
        public Login(Screen screen)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            labelRegistration.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxGlaz.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            buttonLogin.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            this.screen = screen;
        }

        private void labelRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelRegistration.Font = new Font(labelRegistration.Font, FontStyle.Underline);
        }

        private void labelRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelRegistration.Font = new Font(labelRegistration.Font, FontStyle.Regular);
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            screen.replacementRegistrationForm();
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            panelLogin.Location = new Point(this.Width / 2 - 220, this.Height / 2 - 145);
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                client = new ServiceClient();
                string log = client.login(textBoxEmail.Text, textBoxPassword.Text);
                if (log == "вход")
                {
                    screen.replacmentMainScreen(textBoxEmail.Text);
                }
                else if (log == "неверный Email")
                {
                    labelErrorEmail.Text = log;
                    labelErrorEmail.Visible = true;
                }
                else if (log == "неправильный пароль")
                {
                    labelErrorPassword.Text = log;
                    labelErrorPassword.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Сервер не работает");
            }

        }

        private void ActiveControlNull(object sender, EventArgs e)
        {
            screen.ActiveControl = null;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            labelErrorEmail.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelErrorPassword.Visible = false;
        }
    }
}
