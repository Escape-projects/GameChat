using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GameChat.Server;

namespace ChatGame.panels
{
    public partial class Registration : UserControl
    {
        enum IDC
        {
            HAND = 32649,
            // other values omitted
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadCursor(IntPtr hInstance, IDC cursor);

        Screen screen;
        bool Glaz;
        string errorEmail, code;
        ServiceClient client;
        public Registration(Screen screen)
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            labelLogin.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            pictureBoxGlaz.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            buttonRegistration.Cursor = new Cursor(LoadCursor(IntPtr.Zero, IDC.HAND));
            this.screen = screen;
        }

        private void labelLogin_MouseEnter(object sender, EventArgs e)
        {
            labelLogin.Font = new Font(labelLogin.Font, FontStyle.Underline);
        }

        private void labelLogin_MouseLeave(object sender, EventArgs e)
        {
            labelLogin.Font = new Font(labelLogin.Font, FontStyle.Regular);
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            screen.replacementLoginForm();
        }

        private void Registration_SizeChanged(object sender, EventArgs e)
        {
            panelRegistration.Location = new Point(this.Width / 2 - 220, this.Height / 2 - 157);
        }

        private void ActiveControlNull(object sender, EventArgs e)
        {
            screen.ActiveControl = null;
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

        private void SendCode()
        {
            errorEmail = "";
            code = "";
            Random number = new Random();
            for (int i = 0; i < 8; i++) code += number.Next(0, 10).ToString();

            try
            {
                string from = "chat_game@mail.ru";
                string pass = "CJJqepK5rdbJTEFvssAv";
                SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
                client.Credentials = new NetworkCredential(from, pass);
                client.EnableSsl = true;
                MailMessage mess = new MailMessage();
                mess.From = new MailAddress(from);
                mess.To.Add(textBoxEmail.Text.ToString());
                mess.Subject = "Подтверждение регистрации в ChatGame";
                mess.Body = $"Код для подтверждения учётной записи: {code} ";
                client.Send(mess);
            }
            catch (Exception e)
            {
                errorEmail = e.Message;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUserName.Text.Length < 4)
                {
                    labelErrorUserName.Text = "Имя не может содержать менее 4 символов";
                    labelErrorUserName.Visible = true;
                }
                else if (textBoxPassword.Text.Length < 6)
                {
                    labelErrorPassword.Text = "Пароль не может быть меньше 6 символов";
                    labelErrorPassword.Visible = true;
                }
                else
                {
                    client = new ServiceClient();
                    string reg = client.accountCheckForReg(textBoxUserName.Text, textBoxEmail.Text);

                    if (reg == "аккаунта не существует")
                    {
                        SendCode();
                        if (errorEmail == "")
                        {
                            Account account = new Account(textBoxUserName.Text, textBoxEmail.Text, textBoxPassword.Text);
                            screen.replacmentAccountConfirmationForm(code, account);
                        }
                        else
                        {
                            labelErrorEmail.Text = "неверный Email";
                            labelErrorEmail.Visible = true;
                        }
                    }
                    else if (reg == "Имя занято")
                    {
                        labelErrorUserName.Text = reg;
                        labelErrorUserName.Visible = true;
                    }
                    else if (reg == "Email занят")
                    {
                        labelErrorEmail.Text = reg;
                        labelErrorEmail.Visible = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Сервер не работает");
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            labelErrorUserName.Visible = false;
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
