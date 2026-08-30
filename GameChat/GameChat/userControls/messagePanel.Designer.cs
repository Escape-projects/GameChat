namespace ChatGame.userControls
{
    partial class messagePanel
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
            this.labelFriendName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelUnreadMessagesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelFriendName.Location = new System.Drawing.Point(45, 12);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(44, 25);
            this.labelFriendName.TabIndex = 3;
            this.labelFriendName.Text = "Ник";
            this.labelFriendName.Click += new System.EventHandler(this.messagePanel_Click);
            this.labelFriendName.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelFriendName.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::GameChat.Properties.Resources.avatarStandart;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.Click += new System.EventHandler(this.messagePanel_Click);
            this.pictureBoxAvatar.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxAvatar.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelUnreadMessagesCount
            // 
            this.labelUnreadMessagesCount.AutoSize = true;
            this.labelUnreadMessagesCount.BackColor = System.Drawing.Color.LightYellow;
            this.labelUnreadMessagesCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUnreadMessagesCount.Location = new System.Drawing.Point(175, 16);
            this.labelUnreadMessagesCount.Name = "labelUnreadMessagesCount";
            this.labelUnreadMessagesCount.Size = new System.Drawing.Size(17, 19);
            this.labelUnreadMessagesCount.TabIndex = 4;
            this.labelUnreadMessagesCount.Text = "0";
            this.labelUnreadMessagesCount.Visible = false;
            this.labelUnreadMessagesCount.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelUnreadMessagesCount.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // messagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.labelUnreadMessagesCount);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Name = "messagePanel";
            this.Size = new System.Drawing.Size(195, 50);
            this.Click += new System.EventHandler(this.messagePanel_Click);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        public System.Windows.Forms.Label labelUnreadMessagesCount;
    }
}
