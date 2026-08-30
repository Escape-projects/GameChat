namespace ChatGame.panels
{
    partial class Login
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBoxGlaz = new System.Windows.Forms.PictureBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.labelErrorEmail = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.pictureBoxGlaz);
            this.panelLogin.Controls.Add(this.labelRegistration);
            this.panelLogin.Controls.Add(this.labelQuestion);
            this.panelLogin.Controls.Add(this.labelErrorPassword);
            this.panelLogin.Controls.Add(this.labelErrorEmail);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.labelEmail);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Location = new System.Drawing.Point(155, 55);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(440, 290);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Click += new System.EventHandler(this.ActiveControlNull);
            // 
            // pictureBoxGlaz
            // 
            this.pictureBoxGlaz.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxGlaz.Image = global::GameChat.Properties.Resources.glaz2;
            this.pictureBoxGlaz.Location = new System.Drawing.Point(385, 155);
            this.pictureBoxGlaz.Name = "pictureBoxGlaz";
            this.pictureBoxGlaz.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxGlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlaz.TabIndex = 11;
            this.pictureBoxGlaz.TabStop = false;
            this.pictureBoxGlaz.Click += new System.EventHandler(this.glaz_Click);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRegistration.ForeColor = System.Drawing.Color.DimGray;
            this.labelRegistration.Location = new System.Drawing.Point(155, 247);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(119, 15);
            this.labelRegistration.TabIndex = 10;
            this.labelRegistration.Text = "Зарегистрироваться";
            this.labelRegistration.Click += new System.EventHandler(this.labelRegistration_Click);
            this.labelRegistration.MouseEnter += new System.EventHandler(this.labelRegistration_MouseEnter);
            this.labelRegistration.MouseLeave += new System.EventHandler(this.labelRegistration_MouseLeave);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelQuestion.Location = new System.Drawing.Point(37, 247);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(121, 15);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Нет учётной записи?";
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.BackColor = System.Drawing.Color.White;
            this.labelErrorPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(37, 179);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(49, 13);
            this.labelErrorPassword.TabIndex = 8;
            this.labelErrorPassword.Text = "ошибка";
            this.labelErrorPassword.Visible = false;
            // 
            // labelErrorEmail
            // 
            this.labelErrorEmail.AutoSize = true;
            this.labelErrorEmail.BackColor = System.Drawing.Color.White;
            this.labelErrorEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEmail.Location = new System.Drawing.Point(37, 118);
            this.labelErrorEmail.Name = "labelErrorEmail";
            this.labelErrorEmail.Size = new System.Drawing.Size(49, 13);
            this.labelErrorEmail.TabIndex = 7;
            this.labelErrorEmail.Text = "ошибка";
            this.labelErrorEmail.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightGray;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(34, 202);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(373, 33);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Вход";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(34, 154);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(373, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(29, 131);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 21);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(34, 93);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(373, 23);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelEmail.Location = new System.Drawing.Point(29, 70);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(189, 21);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Адрес электроной почты";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelLogin.Location = new System.Drawing.Point(158, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(125, 25);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Авторизация";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelLogin);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(750, 400);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.Click += new System.EventHandler(this.ActiveControlNull);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Label labelErrorEmail;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.PictureBox pictureBoxGlaz;
    }
}
