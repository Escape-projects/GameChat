namespace GameChat.userControls
{
    partial class MemberPanel
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
            this.pictureBoxKickOut = new System.Windows.Forms.PictureBox();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKickOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKickOut
            // 
            this.pictureBoxKickOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxKickOut.Image = global::GameChat.Properties.Resources.overrule;
            this.pictureBoxKickOut.Location = new System.Drawing.Point(217, 13);
            this.pictureBoxKickOut.Name = "pictureBoxKickOut";
            this.pictureBoxKickOut.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxKickOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKickOut.TabIndex = 9;
            this.pictureBoxKickOut.TabStop = false;
            this.pictureBoxKickOut.Click += new System.EventHandler(this.pictureBoxKickOut_Click);
            this.pictureBoxKickOut.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.pictureBoxKickOut.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelMemberName.Location = new System.Drawing.Point(49, 13);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(45, 25);
            this.labelMemberName.TabIndex = 8;
            this.labelMemberName.Text = "Ник";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::GameChat.Properties.Resources.avatarStandart;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 7;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(167, 14);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.buttonCancel.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // MemberPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pictureBoxKickOut);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Name = "MemberPanel";
            this.Size = new System.Drawing.Size(250, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKickOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKickOut;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button buttonCancel;
    }
}
