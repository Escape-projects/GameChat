namespace GameChat
{
    partial class CreateRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoom));
            this.labelRoomName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelErrorRN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGlaz = new System.Windows.Forms.PictureBox();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.numUDMembers = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxMembers = new System.Windows.Forms.CheckBox();
            this.labelMembers = new System.Windows.Forms.Label();
            this.labelErrorPass = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelRoomName.Location = new System.Drawing.Point(10, 48);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(145, 21);
            this.labelRoomName.TabIndex = 16;
            this.labelRoomName.Text = "Название комнаты";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(10, 125);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 21);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Пароль";
            // 
            // labelErrorRN
            // 
            this.labelErrorRN.AutoSize = true;
            this.labelErrorRN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelErrorRN.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRN.Location = new System.Drawing.Point(20, 98);
            this.labelErrorRN.Name = "labelErrorRN";
            this.labelErrorRN.Size = new System.Drawing.Size(51, 15);
            this.labelErrorRN.TabIndex = 20;
            this.labelErrorRN.Text = "ошибка";
            this.labelErrorRN.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxGlaz);
            this.panel1.Controls.Add(this.textBoxRoomName);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.numUDMembers);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.checkBoxMembers);
            this.panel1.Controls.Add(this.labelMembers);
            this.panel1.Controls.Add(this.labelErrorPass);
            this.panel1.Controls.Add(this.checkBoxPassword);
            this.panel1.Controls.Add(this.labelRoomName);
            this.panel1.Controls.Add(this.labelErrorRN);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 325);
            this.panel1.TabIndex = 21;
            this.panel1.Click += new System.EventHandler(this.emptySpaceClick);
            // 
            // pictureBoxGlaz
            // 
            this.pictureBoxGlaz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxGlaz.Enabled = false;
            this.pictureBoxGlaz.Image = global::GameChat.Properties.Resources.glaz2;
            this.pictureBoxGlaz.Location = new System.Drawing.Point(277, 150);
            this.pictureBoxGlaz.Name = "pictureBoxGlaz";
            this.pictureBoxGlaz.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxGlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlaz.TabIndex = 33;
            this.pictureBoxGlaz.TabStop = false;
            this.pictureBoxGlaz.Click += new System.EventHandler(this.glaz_Click);
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.BackColor = System.Drawing.Color.LightGray;
            this.textBoxRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoomName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoomName.Location = new System.Drawing.Point(14, 72);
            this.textBoxRoomName.MaxLength = 30;
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(285, 23);
            this.textBoxRoomName.TabIndex = 32;
            this.textBoxRoomName.TextChanged += new System.EventHandler(this.textBoxRoomName_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(14, 149);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(285, 23);
            this.textBoxPassword.TabIndex = 31;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.LightGray;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(71, 271);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(158, 29);
            this.buttonCreate.TabIndex = 30;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // numUDMembers
            // 
            this.numUDMembers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numUDMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUDMembers.Enabled = false;
            this.numUDMembers.Location = new System.Drawing.Point(14, 231);
            this.numUDMembers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUDMembers.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUDMembers.Name = "numUDMembers";
            this.numUDMembers.Size = new System.Drawing.Size(285, 20);
            this.numUDMembers.TabIndex = 29;
            this.numUDMembers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTitle.Location = new System.Drawing.Point(63, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 25);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Создание комнаты";
            // 
            // checkBoxMembers
            // 
            this.checkBoxMembers.AutoSize = true;
            this.checkBoxMembers.Location = new System.Drawing.Point(186, 213);
            this.checkBoxMembers.Name = "checkBoxMembers";
            this.checkBoxMembers.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMembers.TabIndex = 25;
            this.checkBoxMembers.UseVisualStyleBackColor = true;
            this.checkBoxMembers.CheckedChanged += new System.EventHandler(this.checkBoxMembers_CheckedChanged);
            // 
            // labelMembers
            // 
            this.labelMembers.AutoSize = true;
            this.labelMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMembers.Location = new System.Drawing.Point(10, 207);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(179, 21);
            this.labelMembers.TabIndex = 23;
            this.labelMembers.Text = "Количество участников";
            // 
            // labelErrorPass
            // 
            this.labelErrorPass.AutoSize = true;
            this.labelErrorPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelErrorPass.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPass.Location = new System.Drawing.Point(20, 175);
            this.labelErrorPass.Name = "labelErrorPass";
            this.labelErrorPass.Size = new System.Drawing.Size(51, 15);
            this.labelErrorPass.TabIndex = 22;
            this.labelErrorPass.Text = "ошибка";
            this.labelErrorPass.Visible = false;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(70, 131);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 21;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(360, 375);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateRoom";
            this.Text = "GameChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateRoom_FormClosed);
            this.Click += new System.EventHandler(this.emptySpaceClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelRoomName;
        public System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.Label labelErrorRN;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelErrorPass;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxMembers;
        public System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.NumericUpDown numUDMembers;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxGlaz;
    }
}