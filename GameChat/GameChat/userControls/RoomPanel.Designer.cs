namespace GameChat.userControls
{
    partial class RoomPanel
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
            this.labelRoomName = new System.Windows.Forms.Label();
            this.labelMembers = new System.Windows.Forms.Label();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelRoomName.Location = new System.Drawing.Point(26, 12);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(128, 21);
            this.labelRoomName.TabIndex = 16;
            this.labelRoomName.Text = "Название комн...";
            this.labelRoomName.Click += new System.EventHandler(this.RoomPanel_Click);
            this.labelRoomName.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelRoomName.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelMembers
            // 
            this.labelMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMembers.AutoSize = true;
            this.labelMembers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMembers.Location = new System.Drawing.Point(158, 16);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(30, 15);
            this.labelMembers.TabIndex = 17;
            this.labelMembers.Text = "0/10";
            this.labelMembers.Visible = false;
            this.labelMembers.Click += new System.EventHandler(this.RoomPanel_Click);
            this.labelMembers.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelMembers.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::GameChat.Properties.Resources.lockOpen;
            this.pictureBoxPassword.Location = new System.Drawing.Point(2, 10);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassword.TabIndex = 18;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Click += new System.EventHandler(this.RoomPanel_Click);
            this.pictureBoxPassword.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxPassword.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // RoomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.labelMembers);
            this.Controls.Add(this.labelRoomName);
            this.Name = "RoomPanel";
            this.Size = new System.Drawing.Size(190, 45);
            this.SizeChanged += new System.EventHandler(this.RoomPanel_SizeChanged);
            this.Click += new System.EventHandler(this.RoomPanel_Click);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label labelRoomName;
    }
}
