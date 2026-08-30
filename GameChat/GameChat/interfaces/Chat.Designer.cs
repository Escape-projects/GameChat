namespace ChatGame.panels
{
    partial class Chat
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panelFriendName = new System.Windows.Forms.Panel();
            this.textBoxFriendName = new System.Windows.Forms.TextBox();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.panelFriendName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.BackColor = System.Drawing.Color.LightGray;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxMessage.Location = new System.Drawing.Point(27, 448);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(470, 31);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            this.textBoxMessage.Enter += new System.EventHandler(this.textBoxMessage_Enter);
            this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
            this.textBoxMessage.Leave += new System.EventHandler(this.textBoxMessage_Leave);
            // 
            // panelFriendName
            // 
            this.panelFriendName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriendName.BackColor = System.Drawing.Color.Gray;
            this.panelFriendName.Controls.Add(this.textBoxFriendName);
            this.panelFriendName.Controls.Add(this.pictureBoxAvatar);
            this.panelFriendName.Location = new System.Drawing.Point(1, 0);
            this.panelFriendName.Name = "panelFriendName";
            this.panelFriendName.Size = new System.Drawing.Size(528, 50);
            this.panelFriendName.TabIndex = 0;
            this.panelFriendName.Click += new System.EventHandler(this.panelFriendName_Click);
            // 
            // textBoxFriendName
            // 
            this.textBoxFriendName.BackColor = System.Drawing.Color.Gray;
            this.textBoxFriendName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxFriendName.Location = new System.Drawing.Point(52, 13);
            this.textBoxFriendName.Name = "textBoxFriendName";
            this.textBoxFriendName.ReadOnly = true;
            this.textBoxFriendName.Size = new System.Drawing.Size(166, 25);
            this.textBoxFriendName.TabIndex = 4;
            this.textBoxFriendName.TabStop = false;
            this.textBoxFriendName.Text = "Имя пользователя";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::GameChat.Properties.Resources.avatarStandart;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(6, 5);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 2;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // panelMessages
            // 
            this.panelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessages.AutoScroll = true;
            this.panelMessages.Location = new System.Drawing.Point(0, 50);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(530, 390);
            this.panelMessages.TabIndex = 1;
            this.panelMessages.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelMessages_ControlAdded);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelFriendName);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(530, 500);
            this.SizeChanged += new System.EventHandler(this.Chat_SizeChanged);
            this.panelFriendName.ResumeLayout(false);
            this.panelFriendName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Panel panelFriendName;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.TextBox textBoxFriendName;
    }
}
