namespace ChatGame.panels
{
    partial class FriendList
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
            this.labelFriendsTab = new System.Windows.Forms.Label();
            this.pictureBoxFriendsTab = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFriendAdd = new System.Windows.Forms.Label();
            this.label_invitations = new System.Windows.Forms.Label();
            this.labelAll = new System.Windows.Forms.Label();
            this.labelOnline = new System.Windows.Forms.Label();
            this.panelFriendList = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelActivePanel = new System.Windows.Forms.Label();
            this.buttonAddFriend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsTab)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFriendsTab
            // 
            this.labelFriendsTab.AutoSize = true;
            this.labelFriendsTab.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelFriendsTab.Location = new System.Drawing.Point(41, 13);
            this.labelFriendsTab.Name = "labelFriendsTab";
            this.labelFriendsTab.Size = new System.Drawing.Size(73, 25);
            this.labelFriendsTab.TabIndex = 4;
            this.labelFriendsTab.Text = "Друзья";
            // 
            // pictureBoxFriendsTab
            // 
            this.pictureBoxFriendsTab.Image = global::GameChat.Properties.Resources.friends;
            this.pictureBoxFriendsTab.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxFriendsTab.Name = "pictureBoxFriendsTab";
            this.pictureBoxFriendsTab.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxFriendsTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendsTab.TabIndex = 5;
            this.pictureBoxFriendsTab.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelFriendAdd);
            this.panel1.Controls.Add(this.label_invitations);
            this.panel1.Controls.Add(this.labelAll);
            this.panel1.Controls.Add(this.labelOnline);
            this.panel1.Controls.Add(this.labelFriendsTab);
            this.panel1.Controls.Add(this.pictureBoxFriendsTab);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 50);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // labelFriendAdd
            // 
            this.labelFriendAdd.AutoSize = true;
            this.labelFriendAdd.BackColor = System.Drawing.Color.Gray;
            this.labelFriendAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFriendAdd.Location = new System.Drawing.Point(368, 15);
            this.labelFriendAdd.Name = "labelFriendAdd";
            this.labelFriendAdd.Size = new System.Drawing.Size(144, 21);
            this.labelFriendAdd.TabIndex = 8;
            this.labelFriendAdd.Text = "Добавить в друзья";
            this.labelFriendAdd.Click += new System.EventHandler(this.label_click);
            // 
            // label_invitations
            // 
            this.label_invitations.AutoSize = true;
            this.label_invitations.BackColor = System.Drawing.Color.Gray;
            this.label_invitations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_invitations.Location = new System.Drawing.Point(247, 15);
            this.label_invitations.Name = "label_invitations";
            this.label_invitations.Size = new System.Drawing.Size(108, 21);
            this.label_invitations.TabIndex = 7;
            this.label_invitations.Text = "Приглашения";
            this.label_invitations.Click += new System.EventHandler(this.label_click);
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.BackColor = System.Drawing.Color.Gray;
            this.labelAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelAll.Location = new System.Drawing.Point(200, 15);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(34, 21);
            this.labelAll.TabIndex = 7;
            this.labelAll.Text = "Все";
            this.labelAll.Click += new System.EventHandler(this.label_click);
            // 
            // labelOnline
            // 
            this.labelOnline.AutoSize = true;
            this.labelOnline.BackColor = System.Drawing.Color.Gray;
            this.labelOnline.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOnline.Location = new System.Drawing.Point(133, 15);
            this.labelOnline.Name = "labelOnline";
            this.labelOnline.Size = new System.Drawing.Size(54, 21);
            this.labelOnline.TabIndex = 7;
            this.labelOnline.Text = "В сети";
            this.labelOnline.Click += new System.EventHandler(this.label_click);
            // 
            // panelFriendList
            // 
            this.panelFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriendList.Location = new System.Drawing.Point(0, 128);
            this.panelFriendList.Name = "panelFriendList";
            this.panelFriendList.Size = new System.Drawing.Size(530, 372);
            this.panelFriendList.TabIndex = 7;
            this.panelFriendList.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(3, 58);
            this.textBoxSearch.MaxLength = 30;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(524, 29);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // labelActivePanel
            // 
            this.labelActivePanel.AutoSize = true;
            this.labelActivePanel.BackColor = System.Drawing.Color.DimGray;
            this.labelActivePanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelActivePanel.Location = new System.Drawing.Point(8, 102);
            this.labelActivePanel.Name = "labelActivePanel";
            this.labelActivePanel.Size = new System.Drawing.Size(150, 21);
            this.labelActivePanel.TabIndex = 9;
            this.labelActivePanel.Text = "выбранная вкладка";
            // 
            // buttonAddFriend
            // 
            this.buttonAddFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFriend.Location = new System.Drawing.Point(423, 94);
            this.buttonAddFriend.Name = "buttonAddFriend";
            this.buttonAddFriend.Size = new System.Drawing.Size(96, 28);
            this.buttonAddFriend.TabIndex = 10;
            this.buttonAddFriend.Text = "Добавить";
            this.buttonAddFriend.UseVisualStyleBackColor = true;
            this.buttonAddFriend.Visible = false;
            this.buttonAddFriend.Click += new System.EventHandler(this.buttonAddFriend_Click);
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.buttonAddFriend);
            this.Controls.Add(this.labelActivePanel);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panelFriendList);
            this.Controls.Add(this.panel1);
            this.Name = "FriendList";
            this.Size = new System.Drawing.Size(530, 500);
            this.Click += new System.EventHandler(this.emptySpaceClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsTab)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFriendsTab;
        private System.Windows.Forms.PictureBox pictureBoxFriendsTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOnline;
        private System.Windows.Forms.Label label_invitations;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Label labelFriendAdd;
        private System.Windows.Forms.Panel panelFriendList;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelActivePanel;
        private System.Windows.Forms.Button buttonAddFriend;
    }
}
