namespace GameChat.panels
{
    partial class RoomsByGame
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxGamesTab = new System.Windows.Forms.PictureBox();
            this.panelRoomList = new System.Windows.Forms.Panel();
            this.pictureBoxGames = new System.Windows.Forms.PictureBox();
            this.labelRoomList = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.buttonCreateRoom = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelRoom = new System.Windows.Forms.Panel();
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesTab)).BeginInit();
            this.panelRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGames)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.BackColor = System.Drawing.Color.Gray;
            this.panelTitle.Controls.Add(this.textBoxGame);
            this.panelTitle.Controls.Add(this.pictureBoxBack);
            this.panelTitle.Controls.Add(this.pictureBoxGamesTab);
            this.panelTitle.Location = new System.Drawing.Point(1, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(528, 50);
            this.panelTitle.TabIndex = 15;
            this.panelTitle.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::GameChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(10, 13);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(30, 25);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 14;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxGamesTab
            // 
            this.pictureBoxGamesTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxGamesTab.Image = global::GameChat.Properties.Resources.games;
            this.pictureBoxGamesTab.Location = new System.Drawing.Point(175, 16);
            this.pictureBoxGamesTab.Name = "pictureBoxGamesTab";
            this.pictureBoxGamesTab.Size = new System.Drawing.Size(30, 22);
            this.pictureBoxGamesTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGamesTab.TabIndex = 13;
            this.pictureBoxGamesTab.TabStop = false;
            // 
            // panelRoomList
            // 
            this.panelRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRoomList.BackColor = System.Drawing.Color.Gray;
            this.panelRoomList.Controls.Add(this.pictureBoxGames);
            this.panelRoomList.Controls.Add(this.labelRoomList);
            this.panelRoomList.Controls.Add(this.panelRooms);
            this.panelRoomList.Controls.Add(this.buttonCreateRoom);
            this.panelRoomList.Controls.Add(this.textBoxSearch);
            this.panelRoomList.Location = new System.Drawing.Point(1, 51);
            this.panelRoomList.Name = "panelRoomList";
            this.panelRoomList.Size = new System.Drawing.Size(189, 449);
            this.panelRoomList.TabIndex = 16;
            // 
            // pictureBoxGames
            // 
            this.pictureBoxGames.Image = global::GameChat.Properties.Resources.favoriteGames;
            this.pictureBoxGames.Location = new System.Drawing.Point(8, 13);
            this.pictureBoxGames.Name = "pictureBoxGames";
            this.pictureBoxGames.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGames.TabIndex = 16;
            this.pictureBoxGames.TabStop = false;
            // 
            // labelRoomList
            // 
            this.labelRoomList.AutoSize = true;
            this.labelRoomList.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelRoomList.Location = new System.Drawing.Point(32, 11);
            this.labelRoomList.Name = "labelRoomList";
            this.labelRoomList.Size = new System.Drawing.Size(135, 25);
            this.labelRoomList.TabIndex = 15;
            this.labelRoomList.Text = "Список комнат";
            // 
            // panelRooms
            // 
            this.panelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRooms.AutoScroll = true;
            this.panelRooms.Location = new System.Drawing.Point(3, 120);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(183, 326);
            this.panelRooms.TabIndex = 6;
            this.panelRooms.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // buttonCreateRoom
            // 
            this.buttonCreateRoom.Location = new System.Drawing.Point(3, 79);
            this.buttonCreateRoom.Name = "buttonCreateRoom";
            this.buttonCreateRoom.Size = new System.Drawing.Size(152, 35);
            this.buttonCreateRoom.TabIndex = 0;
            this.buttonCreateRoom.Text = "создать свою комнату";
            this.buttonCreateRoom.UseVisualStyleBackColor = true;
            this.buttonCreateRoom.Click += new System.EventHandler(this.buttonCreateRoom_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(3, 44);
            this.textBoxSearch.MaxLength = 30;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(181, 29);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // panelRoom
            // 
            this.panelRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRoom.Location = new System.Drawing.Point(191, 51);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(338, 449);
            this.panelRoom.TabIndex = 17;
            // 
            // textBoxGame
            // 
            this.textBoxGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGame.BackColor = System.Drawing.Color.Gray;
            this.textBoxGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGame.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxGame.Location = new System.Drawing.Point(211, 13);
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.ReadOnly = true;
            this.textBoxGame.Size = new System.Drawing.Size(136, 25);
            this.textBoxGame.TabIndex = 15;
            this.textBoxGame.TabStop = false;
            this.textBoxGame.Text = "Название игры";
            // 
            // RoomsByGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panelRoom);
            this.Controls.Add(this.panelRoomList);
            this.Controls.Add(this.panelTitle);
            this.Name = "RoomsByGame";
            this.Size = new System.Drawing.Size(530, 500);
            this.SizeChanged += new System.EventHandler(this.RoomsByGames_SizeChanged);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesTab)).EndInit();
            this.panelRoomList.ResumeLayout(false);
            this.panelRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelRoomList;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateRoom;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.PictureBox pictureBoxGames;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label labelRoomList;
        public System.Windows.Forms.PictureBox pictureBoxGamesTab;
        public System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.TextBox textBoxGame;
    }
}
