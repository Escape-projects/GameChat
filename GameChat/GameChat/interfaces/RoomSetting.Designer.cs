namespace GameChat.interfaces
{
    partial class RoomSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomSetting));
            this.labelError = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.panelMembers = new System.Windows.Forms.Panel();
            this.labelMembers = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxGlaz = new System.Windows.Forms.PictureBox();
            this.panelRoomName = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).BeginInit();
            this.panelRoomName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.DimGray;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelError.ForeColor = System.Drawing.Color.LightPink;
            this.labelError.Location = new System.Drawing.Point(130, 389);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(49, 13);
            this.labelError.TabIndex = 36;
            this.labelError.Text = "ошибка";
            this.labelError.Visible = false;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePassword.Location = new System.Drawing.Point(308, 362);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(81, 25);
            this.buttonChangePassword.TabIndex = 35;
            this.buttonChangePassword.Text = "Сменить";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelChangePassword.Location = new System.Drawing.Point(8, 362);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(127, 21);
            this.labelChangePassword.TabIndex = 33;
            this.labelChangePassword.Text = "Сменить пароль";
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(131, 413);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(138, 29);
            this.buttonDeleteRoom.TabIndex = 32;
            this.buttonDeleteRoom.Text = "Удалить комнату";
            this.buttonDeleteRoom.UseVisualStyleBackColor = true;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // panelMembers
            // 
            this.panelMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMembers.AutoScroll = true;
            this.panelMembers.BackColor = System.Drawing.Color.DimGray;
            this.panelMembers.Location = new System.Drawing.Point(12, 117);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(376, 237);
            this.panelMembers.TabIndex = 31;
            this.panelMembers.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // labelMembers
            // 
            this.labelMembers.AutoSize = true;
            this.labelMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMembers.Location = new System.Drawing.Point(8, 58);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(88, 21);
            this.labelMembers.TabIndex = 30;
            this.labelMembers.Text = "Участники:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(12, 82);
            this.textBoxSearch.MaxLength = 30;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ShortcutsEnabled = false;
            this.textBoxSearch.Size = new System.Drawing.Size(376, 29);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(133, 363);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(169, 23);
            this.textBoxPassword.TabIndex = 38;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // pictureBoxGlaz
            // 
            this.pictureBoxGlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGlaz.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxGlaz.Image = global::GameChat.Properties.Resources.glaz2;
            this.pictureBoxGlaz.Location = new System.Drawing.Point(280, 364);
            this.pictureBoxGlaz.Name = "pictureBoxGlaz";
            this.pictureBoxGlaz.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxGlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlaz.TabIndex = 37;
            this.pictureBoxGlaz.TabStop = false;
            this.pictureBoxGlaz.Click += new System.EventHandler(this.glaz_Click);
            // 
            // panelRoomName
            // 
            this.panelRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRoomName.BackColor = System.Drawing.Color.Gray;
            this.panelRoomName.Controls.Add(this.pictureBoxBack);
            this.panelRoomName.Controls.Add(this.labelRoomName);
            this.panelRoomName.Controls.Add(this.pictureBoxRoom);
            this.panelRoomName.Location = new System.Drawing.Point(0, 0);
            this.panelRoomName.Name = "panelRoomName";
            this.panelRoomName.Size = new System.Drawing.Size(400, 50);
            this.panelRoomName.TabIndex = 39;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.Image = global::GameChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(368, 15);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 15;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelRoomName.Location = new System.Drawing.Point(51, 13);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(167, 25);
            this.labelRoomName.TabIndex = 14;
            this.labelRoomName.Text = "Название комнаты";
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
            // RoomSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panelRoomName);
            this.Controls.Add(this.pictureBoxGlaz);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panelMembers);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelChangePassword);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.labelMembers);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "RoomSetting";
            this.Size = new System.Drawing.Size(400, 450);
            this.SizeChanged += new System.EventHandler(this.RoomSetting_SizeChanged);
            this.Click += new System.EventHandler(this.emptySpaceClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).EndInit();
            this.panelRoomName.ResumeLayout(false);
            this.panelRoomName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonChangePassword;
        public System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Panel panelMembers;
        public System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxGlaz;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelRoomName;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        public System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
    }
}
