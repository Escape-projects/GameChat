namespace ChatGame.panels
{
    partial class Registration
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
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.pictureBoxGlaz = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelErrorEmail = new System.Windows.Forms.Label();
            this.labelErrorUserName = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.glaz = new System.Windows.Forms.PictureBox();
            this.panelRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glaz)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistration
            // 
            this.panelRegistration.BackColor = System.Drawing.Color.White;
            this.panelRegistration.Controls.Add(this.pictureBoxGlaz);
            this.panelRegistration.Controls.Add(this.labelLogin);
            this.panelRegistration.Controls.Add(this.labelErrorPassword);
            this.panelRegistration.Controls.Add(this.textBoxPassword);
            this.panelRegistration.Controls.Add(this.labelPassword);
            this.panelRegistration.Controls.Add(this.labelQuestion);
            this.panelRegistration.Controls.Add(this.labelErrorEmail);
            this.panelRegistration.Controls.Add(this.labelErrorUserName);
            this.panelRegistration.Controls.Add(this.buttonRegistration);
            this.panelRegistration.Controls.Add(this.textBoxEmail);
            this.panelRegistration.Controls.Add(this.labelEmail);
            this.panelRegistration.Controls.Add(this.textBoxUserName);
            this.panelRegistration.Controls.Add(this.labelUserName);
            this.panelRegistration.Controls.Add(this.labelRegistration);
            this.panelRegistration.Location = new System.Drawing.Point(155, 43);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(440, 315);
            this.panelRegistration.TabIndex = 1;
            this.panelRegistration.Click += new System.EventHandler(this.ActiveControlNull);
            // 
            // pictureBoxGlaz
            // 
            this.pictureBoxGlaz.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxGlaz.Image = global::GameChat.Properties.Resources.glaz2;
            this.pictureBoxGlaz.Location = new System.Drawing.Point(385, 202);
            this.pictureBoxGlaz.Name = "pictureBoxGlaz";
            this.pictureBoxGlaz.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxGlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlaz.TabIndex = 12;
            this.pictureBoxGlaz.TabStop = false;
            this.pictureBoxGlaz.Click += new System.EventHandler(this.glaz_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.labelLogin.Location = new System.Drawing.Point(180, 287);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 15);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Войти";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            this.labelLogin.MouseEnter += new System.EventHandler(this.labelLogin_MouseEnter);
            this.labelLogin.MouseLeave += new System.EventHandler(this.labelLogin_MouseLeave);
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.BackColor = System.Drawing.Color.White;
            this.labelErrorPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(35, 226);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(49, 13);
            this.labelErrorPassword.TabIndex = 13;
            this.labelErrorPassword.Text = "ошибка";
            this.labelErrorPassword.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(34, 201);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(373, 23);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(30, 178);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 21);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Пароль";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelQuestion.Location = new System.Drawing.Point(38, 287);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(147, 15);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Уже есть учётная записи?";
            // 
            // labelErrorEmail
            // 
            this.labelErrorEmail.AutoSize = true;
            this.labelErrorEmail.BackColor = System.Drawing.Color.White;
            this.labelErrorEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEmail.Location = new System.Drawing.Point(35, 164);
            this.labelErrorEmail.Name = "labelErrorEmail";
            this.labelErrorEmail.Size = new System.Drawing.Size(49, 13);
            this.labelErrorEmail.TabIndex = 8;
            this.labelErrorEmail.Text = "ошибка";
            this.labelErrorEmail.Visible = false;
            // 
            // labelErrorUserName
            // 
            this.labelErrorUserName.AutoSize = true;
            this.labelErrorUserName.BackColor = System.Drawing.Color.White;
            this.labelErrorUserName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorUserName.Location = new System.Drawing.Point(35, 100);
            this.labelErrorUserName.Name = "labelErrorUserName";
            this.labelErrorUserName.Size = new System.Drawing.Size(49, 13);
            this.labelErrorUserName.TabIndex = 7;
            this.labelErrorUserName.Text = "ошибка";
            this.labelErrorUserName.Visible = false;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.LightGray;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(34, 244);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(373, 33);
            this.buttonRegistration.TabIndex = 6;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(34, 139);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(373, 23);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelEmail.Location = new System.Drawing.Point(30, 116);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(198, 21);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Адрес электронной почты";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.Location = new System.Drawing.Point(34, 75);
            this.textBoxUserName.MaxLength = 30;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(373, 23);
            this.textBoxUserName.TabIndex = 2;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUserName.Location = new System.Drawing.Point(30, 52);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(142, 21);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Имя пользователя";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelRegistration.Location = new System.Drawing.Point(102, 16);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(236, 25);
            this.labelRegistration.TabIndex = 0;
            this.labelRegistration.Text = "Создание учётной записи";
            // 
            // glaz
            // 
            this.glaz.Location = new System.Drawing.Point(0, 0);
            this.glaz.Name = "glaz";
            this.glaz.Size = new System.Drawing.Size(100, 50);
            this.glaz.TabIndex = 0;
            this.glaz.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelRegistration);
            this.Name = "Registration";
            this.Size = new System.Drawing.Size(750, 400);
            this.SizeChanged += new System.EventHandler(this.Registration_SizeChanged);
            this.Click += new System.EventHandler(this.ActiveControlNull);
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelErrorEmail;
        private System.Windows.Forms.Label labelErrorUserName;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.PictureBox glaz;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxGlaz;
    }
}
