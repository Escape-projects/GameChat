namespace ChatGame.panels
{
    partial class MainScreen
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
            this.panelFavoriteGames = new System.Windows.Forms.Panel();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelGames = new System.Windows.Forms.Label();
            this.pictureBoxGames = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMessages = new System.Windows.Forms.Label();
            this.panelFriendsTab = new System.Windows.Forms.Panel();
            this.labelFriendsTab = new System.Windows.Forms.Label();
            this.pictureBoxFriendsTab = new System.Windows.Forms.PictureBox();
            this.panelGamesTab = new System.Windows.Forms.Panel();
            this.labelGamesTab = new System.Windows.Forms.Label();
            this.pictureBoxGamesTab = new System.Windows.Forms.PictureBox();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFavoriteGames.SuspendLayout();
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGames)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelFriendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsTab)).BeginInit();
            this.panelGamesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesTab)).BeginInit();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFavoriteGames
            // 
            this.panelFavoriteGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFavoriteGames.BackColor = System.Drawing.Color.Gray;
            this.panelFavoriteGames.Controls.Add(this.panelRooms);
            this.panelFavoriteGames.Controls.Add(this.labelGames);
            this.panelFavoriteGames.Controls.Add(this.pictureBoxGames);
            this.panelFavoriteGames.Location = new System.Drawing.Point(760, 50);
            this.panelFavoriteGames.Name = "panelFavoriteGames";
            this.panelFavoriteGames.Size = new System.Drawing.Size(230, 500);
            this.panelFavoriteGames.TabIndex = 7;
            this.panelFavoriteGames.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // panelRooms
            // 
            this.panelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRooms.AutoScroll = true;
            this.panelRooms.Controls.Add(this.labelGameName);
            this.panelRooms.Location = new System.Drawing.Point(3, 53);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(224, 443);
            this.panelRooms.TabIndex = 6;
            this.panelRooms.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelGameName.Location = new System.Drawing.Point(3, 4);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(117, 21);
            this.labelGameName.TabIndex = 7;
            this.labelGameName.Text = "Название игры";
            // 
            // labelGames
            // 
            this.labelGames.AutoSize = true;
            this.labelGames.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelGames.Location = new System.Drawing.Point(44, 21);
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(142, 25);
            this.labelGames.TabIndex = 3;
            this.labelGames.Text = "Список комнат";
            // 
            // pictureBoxGames
            // 
            this.pictureBoxGames.Image = global::GameChat.Properties.Resources.favoriteGames;
            this.pictureBoxGames.Location = new System.Drawing.Point(18, 24);
            this.pictureBoxGames.Name = "pictureBoxGames";
            this.pictureBoxGames.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGames.TabIndex = 3;
            this.pictureBoxGames.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.Gray;
            this.panelLeft.Controls.Add(this.panelMessages);
            this.panelLeft.Controls.Add(this.labelMessages);
            this.panelLeft.Controls.Add(this.panelFriendsTab);
            this.panelLeft.Controls.Add(this.panelGamesTab);
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(230, 500);
            this.panelLeft.TabIndex = 5;
            this.panelLeft.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // panelMessages
            // 
            this.panelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMessages.AutoScroll = true;
            this.panelMessages.BackColor = System.Drawing.Color.Gray;
            this.panelMessages.Location = new System.Drawing.Point(5, 156);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(220, 340);
            this.panelMessages.TabIndex = 5;
            this.panelMessages.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMessages.Location = new System.Drawing.Point(7, 134);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(152, 21);
            this.labelMessages.TabIndex = 3;
            this.labelMessages.Text = "Личные сообщения";
            // 
            // panelFriendsTab
            // 
            this.panelFriendsTab.Controls.Add(this.labelFriendsTab);
            this.panelFriendsTab.Controls.Add(this.pictureBoxFriendsTab);
            this.panelFriendsTab.Location = new System.Drawing.Point(5, 77);
            this.panelFriendsTab.Name = "panelFriendsTab";
            this.panelFriendsTab.Size = new System.Drawing.Size(220, 40);
            this.panelFriendsTab.TabIndex = 4;
            this.panelFriendsTab.Click += new System.EventHandler(this.friendList_Click);
            this.panelFriendsTab.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.panelFriendsTab.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelFriendsTab
            // 
            this.labelFriendsTab.AutoSize = true;
            this.labelFriendsTab.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelFriendsTab.Location = new System.Drawing.Point(41, 8);
            this.labelFriendsTab.Name = "labelFriendsTab";
            this.labelFriendsTab.Size = new System.Drawing.Size(73, 25);
            this.labelFriendsTab.TabIndex = 3;
            this.labelFriendsTab.Text = "Друзья";
            this.labelFriendsTab.Click += new System.EventHandler(this.friendList_Click);
            this.labelFriendsTab.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // pictureBoxFriendsTab
            // 
            this.pictureBoxFriendsTab.Image = global::GameChat.Properties.Resources.friends;
            this.pictureBoxFriendsTab.Location = new System.Drawing.Point(11, 8);
            this.pictureBoxFriendsTab.Name = "pictureBoxFriendsTab";
            this.pictureBoxFriendsTab.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxFriendsTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendsTab.TabIndex = 3;
            this.pictureBoxFriendsTab.TabStop = false;
            this.pictureBoxFriendsTab.Click += new System.EventHandler(this.friendList_Click);
            this.pictureBoxFriendsTab.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // panelGamesTab
            // 
            this.panelGamesTab.Controls.Add(this.labelGamesTab);
            this.panelGamesTab.Controls.Add(this.pictureBoxGamesTab);
            this.panelGamesTab.Location = new System.Drawing.Point(5, 26);
            this.panelGamesTab.Name = "panelGamesTab";
            this.panelGamesTab.Size = new System.Drawing.Size(220, 40);
            this.panelGamesTab.TabIndex = 0;
            this.panelGamesTab.Click += new System.EventHandler(this.gameRooms_Click);
            this.panelGamesTab.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.panelGamesTab.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelGamesTab
            // 
            this.labelGamesTab.AutoSize = true;
            this.labelGamesTab.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelGamesTab.Location = new System.Drawing.Point(41, 6);
            this.labelGamesTab.Name = "labelGamesTab";
            this.labelGamesTab.Size = new System.Drawing.Size(173, 25);
            this.labelGamesTab.TabIndex = 3;
            this.labelGamesTab.Text = "Комнаты по играм";
            this.labelGamesTab.Click += new System.EventHandler(this.gameRooms_Click);
            this.labelGamesTab.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // pictureBoxGamesTab
            // 
            this.pictureBoxGamesTab.Image = global::GameChat.Properties.Resources.games;
            this.pictureBoxGamesTab.Location = new System.Drawing.Point(11, 10);
            this.pictureBoxGamesTab.Name = "pictureBoxGamesTab";
            this.pictureBoxGamesTab.Size = new System.Drawing.Size(28, 20);
            this.pictureBoxGamesTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGamesTab.TabIndex = 3;
            this.pictureBoxGamesTab.TabStop = false;
            this.pictureBoxGamesTab.Click += new System.EventHandler(this.gameRooms_Click);
            this.pictureBoxGamesTab.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // panelAccount
            // 
            this.panelAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAccount.BackColor = System.Drawing.Color.Silver;
            this.panelAccount.Controls.Add(this.textBoxUserName);
            this.panelAccount.Controls.Add(this.pictureBoxExit);
            this.panelAccount.Controls.Add(this.pictureBoxAvatar);
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(990, 50);
            this.panelAccount.TabIndex = 4;
            this.panelAccount.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Silver;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxUserName.Location = new System.Drawing.Point(51, 11);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(166, 25);
            this.textBoxUserName.TabIndex = 5;
            this.textBoxUserName.TabStop = false;
            this.textBoxUserName.Text = "Имя пользователя";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExit.Image = global::GameChat.Properties.Resources.exit;
            this.pictureBoxExit.Location = new System.Drawing.Point(949, 11);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::GameChat.Properties.Resources.avatarStandart;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(5, 3);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.DimGray;
            this.panelMain.Location = new System.Drawing.Point(230, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(530, 500);
            this.panelMain.TabIndex = 6;
            this.panelMain.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFavoriteGames);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelAccount);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(990, 550);
            this.panelFavoriteGames.ResumeLayout(false);
            this.panelFavoriteGames.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGames)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelFriendsTab.ResumeLayout(false);
            this.panelFriendsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsTab)).EndInit();
            this.panelGamesTab.ResumeLayout(false);
            this.panelGamesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesTab)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFavoriteGames;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Panel panelGamesTab;
        private System.Windows.Forms.PictureBox pictureBoxGamesTab;
        private System.Windows.Forms.Panel panelFriendsTab;
        private System.Windows.Forms.Label labelFriendsTab;
        private System.Windows.Forms.PictureBox pictureBoxFriendsTab;
        private System.Windows.Forms.Label labelGamesTab;
        private System.Windows.Forms.Label labelGames;
        private System.Windows.Forms.PictureBox pictureBoxGames;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.TextBox textBoxUserName;
    }
}
