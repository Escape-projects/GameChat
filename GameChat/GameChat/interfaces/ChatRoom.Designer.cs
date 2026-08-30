namespace GameChat.panels
{
    partial class ChatRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRoom));
            this.panelRoomName = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.panelRoomName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoomName
            // 
            this.panelRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRoomName.BackColor = System.Drawing.Color.Gray;
            this.panelRoomName.Controls.Add(this.textBoxRoomName);
            this.panelRoomName.Controls.Add(this.pictureBoxExit);
            this.panelRoomName.Controls.Add(this.pictureBoxRoom);
            this.panelRoomName.Location = new System.Drawing.Point(0, 0);
            this.panelRoomName.Name = "panelRoomName";
            this.panelRoomName.Size = new System.Drawing.Size(400, 50);
            this.panelRoomName.TabIndex = 24;
            this.panelRoomName.SizeChanged += new System.EventHandler(this.panelRoomName_SizeChanged);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExit.Image = global::GameChat.Properties.Resources.exit;
            this.pictureBoxExit.Location = new System.Drawing.Point(368, 15);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 15;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoom.Image")));
            this.pictureBoxRoom.Location = new System.Drawing.Point(5, 11);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(49, 29);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoom.TabIndex = 14;
            this.pictureBoxRoom.TabStop = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.BackColor = System.Drawing.Color.LightGray;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxMessage.Location = new System.Drawing.Point(28, 400);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(342, 30);
            this.textBoxMessage.TabIndex = 25;
            this.textBoxMessage.Text = "Написать";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            this.textBoxMessage.Enter += new System.EventHandler(this.textBoxMessage_Enter);
            this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
            this.textBoxMessage.Leave += new System.EventHandler(this.textBoxMessage_Leave);
            // 
            // panelMessages
            // 
            this.panelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessages.AutoScroll = true;
            this.panelMessages.Location = new System.Drawing.Point(0, 50);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(400, 340);
            this.panelMessages.TabIndex = 26;
            this.panelMessages.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelMessages_ControlAdded);
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.BackColor = System.Drawing.Color.Gray;
            this.textBoxRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBoxRoomName.Location = new System.Drawing.Point(51, 13);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.ReadOnly = true;
            this.textBoxRoomName.Size = new System.Drawing.Size(158, 24);
            this.textBoxRoomName.TabIndex = 16;
            this.textBoxRoomName.TabStop = false;
            this.textBoxRoomName.Text = "Название комнаты";
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.panelRoomName);
            this.Name = "ChatRoom";
            this.Size = new System.Drawing.Size(400, 450);
            this.SizeChanged += new System.EventHandler(this.ChatRoom_SizeChanged);
            this.panelRoomName.ResumeLayout(false);
            this.panelRoomName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.Panel panelRoomName;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.TextBox textBoxRoomName;
    }
}
