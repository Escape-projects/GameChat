using ChatGame.panels;
using System;
using System.Drawing;
using System.Windows.Forms;
using GameChat.Server;
using GameChat.Service2;
using System.ServiceModel;

namespace ChatGame
{
    public partial class Screen : Form, IService2Callback
    {
        Login login;
        Registration reg;
        AccountConfirmation accConf;
        MainScreen mainScreen;
        Account account;
        ServiceClient client;
        Service2Client client2;
        string activeForm;
        public Screen()
        {
            InitializeComponent();
            //replacmentMainScreen("User1@list.ru");
            replacementLoginForm();
        }

        void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activeForm == "MainScreen") client2.Disconnect(account.userName);
        }

        public void SendMessageFriendCallBack(string message, string sender, DateTime dateTime)
        {
            mainScreen.sendMessageFriendCallBack(message, sender, dateTime);
        }

        public void SendMessageInRoomCallBack(int room_id, string sender_name, string message, DateTime dateTime)
        {
            mainScreen.SendMessageInRoomCallBack(room_id, sender_name, message, dateTime);
        }

        public void banCallBack(int room_id, string game)
        {
            mainScreen.banCallBack(room_id, game);
        }

        public void replacementLoginForm()
        {
            MinimumSize = new Size(440 + 16, 290 + 39);
            login = new Login(this);
            login.Size = new Size(Width - 16, Height - 39);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(login);
            activeForm = "LoginForm";
        }

        public void replacementRegistrationForm()
        {
            MinimumSize = new Size(440 + 16, 315 + 39);
            reg = new Registration(this);
            reg.Size = new Size(Width - 16, Height - 39);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(reg);
            activeForm = "RegistrationForm";
        }

        public void replacmentAccountConfirmationForm(string code, Account account)
        {
            MinimumSize = new Size(440 + 16, 207 + 39);
            accConf = new AccountConfirmation(this, code, account);
            accConf.Size = new Size(Width - 16, Height - 39);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(accConf);
            activeForm = "AccountConfirmationForm";
        }

        public void replacmentMainScreen(string Email)
        {
            client = new ServiceClient();
            string Account = client.getAccount(Email);
            if (Account != "ошибка")
            {
                account = new Account(Account.Split()[0], Account.Split()[1], Account.Split()[2]);

                client2 = new Service2Client(new InstanceContext(this));
                client2.Connect(account.userName);

                if (Size.Width < 990 + 16) Size = new Size(990 + 16, Size.Height);
                if (Size.Height < 550 + 39) Size = new Size(Size.Width, 550 + 39);
                MinimumSize = new Size(990 + 16, 550 + 39);
                mainScreen = new MainScreen(this, account, client2);
                mainScreen.Size = new Size(Width - 16, Height - 39);
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(mainScreen);
                activeForm = "MainScreen";
            }
            else
            {
                replacementLoginForm();
                MessageBox.Show(Account);
            }
        }
    }
}
