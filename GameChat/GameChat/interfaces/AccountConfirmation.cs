using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Server;

namespace ChatGame.panels
{
    public partial class AccountConfirmation : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        Screen screen;
        string code;
        Account account;
        ServiceClient client;

        public AccountConfirmation(Screen screen, string code, Account account)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            labelRegistration.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            buttonConfirm.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            this.screen = screen;
            this.code = code;
            this.account = account;
        }

        private void AccountConfirmation_SizeChanged(object sender, EventArgs e)
        {
            panelConfirm.Location = new Point(this.Width / 2 - 220, this.Height / 2 - 103);
        }

        private void textBoxConfirm_TextChanged(object sender, EventArgs e)
        {
            labelErrorCode.Visible = false;
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCode.Text == code)
                {
                    client = new ServiceClient();
                    string reg = client.Reg(account.userName, account.Email, account.password);
                    if (reg == "аккаунт зарегистрирован")
                    {
                        MessageBox.Show("Аккаунт создан");
                        screen.replacementLoginForm();
                    }
                    else
                    {
                        MessageBox.Show("ошибка");
                        screen.replacementRegistrationForm();
                    }
                }
                else
                {
                    labelErrorCode.Text = "Неверный код подтверждения";
                    labelErrorCode.Visible = true;
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
    }
}
