namespace GameChat.forms
{
    partial class EnterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPassword));
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxGlaz = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBoxGlaz);
            this.panel.Controls.Add(this.labelPassword);
            this.panel.Controls.Add(this.textBoxPassword);
            this.panel.Controls.Add(this.buttonLogin);
            this.panel.Controls.Add(this.labelRoomName);
            this.panel.Controls.Add(this.labelError);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(321, 155);
            this.panel.TabIndex = 22;
            // 
            // pictureBoxGlaz
            // 
            this.pictureBoxGlaz.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxGlaz.Image = global::GameChat.Properties.Resources.glaz2;
            this.pictureBoxGlaz.Location = new System.Drawing.Point(290, 55);
            this.pictureBoxGlaz.Name = "pictureBoxGlaz";
            this.pictureBoxGlaz.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxGlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGlaz.TabIndex = 34;
            this.pictureBoxGlaz.TabStop = false;
            this.pictureBoxGlaz.Click += new System.EventHandler(this.glaz_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(5, 30);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 21);
            this.labelPassword.TabIndex = 33;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(9, 54);
            this.textBoxPassword.MaxLength = 30;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(303, 23);
            this.textBoxPassword.TabIndex = 32;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightGray;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(81, 109);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(158, 29);
            this.buttonLogin.TabIndex = 30;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelRoomName
            // 
            this.labelRoomName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelRoomName.Location = new System.Drawing.Point(73, 7);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(175, 25);
            this.labelRoomName.TabIndex = 27;
            this.labelRoomName.Text = "Название комнаты";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(17, 80);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(51, 15);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "ошибка";
            this.labelError.Visible = false;
            // 
            // EnterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(344, 179);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnterPassword";
            this.Text = "GameChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterPassword_FormClosed);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Label labelRoomName;
        public System.Windows.Forms.Label labelError;
        public System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxGlaz;
    }
}