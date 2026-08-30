namespace GameChat.userControls
{
    partial class FriendPanel
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
            this.pictureBoxAccept = new System.Windows.Forms.PictureBox();
            this.pictureBoxOverrule = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverrule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelFriendName.Location = new System.Drawing.Point(49, 15);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(45, 25);
            this.labelFriendName.TabIndex = 5;
            this.labelFriendName.Text = "Ник";
            this.labelFriendName.Click += new System.EventHandler(this.click);
            this.labelFriendName.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelFriendName.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxAccept
            // 
            this.pictureBoxAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAccept.Enabled = false;
            this.pictureBoxAccept.Image = global::GameChat.Properties.Resources.accept;
            this.pictureBoxAccept.Location = new System.Drawing.Point(158, 15);
            this.pictureBoxAccept.Name = "pictureBoxAccept";
            this.pictureBoxAccept.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAccept.TabIndex = 7;
            this.pictureBoxAccept.TabStop = false;
            this.pictureBoxAccept.Visible = false;
            this.pictureBoxAccept.Click += new System.EventHandler(this.pictureBoxAccept_Click);
            this.pictureBoxAccept.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxAccept.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxOverrule
            // 
            this.pictureBoxOverrule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOverrule.Image = global::GameChat.Properties.Resources.overrule;
            this.pictureBoxOverrule.Location = new System.Drawing.Point(195, 15);
            this.pictureBoxOverrule.Name = "pictureBoxOverrule";
            this.pictureBoxOverrule.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxOverrule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOverrule.TabIndex = 6;
            this.pictureBoxOverrule.TabStop = false;
            this.pictureBoxOverrule.Click += new System.EventHandler(this.pictureBoxOverrule_Click);
            this.pictureBoxOverrule.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxOverrule.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::GameChat.Properties.Resources.avatarStandart;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(3, 7);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 4;
            this.pictureBoxAvatar.TabStop = false;
            this.pictureBoxAvatar.Click += new System.EventHandler(this.click);
            this.pictureBoxAvatar.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxAvatar.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // FriendPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pictureBoxAccept);
            this.Controls.Add(this.pictureBoxOverrule);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Name = "FriendPanel";
            this.Size = new System.Drawing.Size(235, 55);
            this.Click += new System.EventHandler(this.click);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverrule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.PictureBox pictureBoxOverrule;
        public System.Windows.Forms.PictureBox pictureBoxAccept;
    }
}
