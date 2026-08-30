namespace GameChat.panels
{
    partial class Games
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelGamesTab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGamesTab = new System.Windows.Forms.PictureBox();
            this.panelGames = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesTab)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(3, 59);
            this.textBoxSearch.MaxLength = 30;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(524, 29);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // labelGamesTab
            // 
            this.labelGamesTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGamesTab.AutoSize = true;
            this.labelGamesTab.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelGamesTab.Location = new System.Drawing.Point(196, 13);
            this.labelGamesTab.Name = "labelGamesTab";
            this.labelGamesTab.Size = new System.Drawing.Size(173, 25);
            this.labelGamesTab.TabIndex = 12;
            this.labelGamesTab.Text = "Комнаты по играм";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBoxGamesTab);
            this.panel1.Controls.Add(this.labelGamesTab);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 50);
            this.panel1.TabIndex = 14;
            // 
            // pictureBoxGamesTab
            // 
            this.pictureBoxGamesTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxGamesTab.Image = global::GameChat.Properties.Resources.games;
            this.pictureBoxGamesTab.Location = new System.Drawing.Point(160, 16);
            this.pictureBoxGamesTab.Name = "pictureBoxGamesTab";
            this.pictureBoxGamesTab.Size = new System.Drawing.Size(30, 22);
            this.pictureBoxGamesTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGamesTab.TabIndex = 13;
            this.pictureBoxGamesTab.TabStop = false;
            // 
            // panelGames
            // 
            this.panelGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGames.AutoScroll = true;
            this.panelGames.BackColor = System.Drawing.Color.DimGray;
            this.panelGames.Location = new System.Drawing.Point(3, 94);
            this.panelGames.Name = "panelGames";
            this.panelGames.Size = new System.Drawing.Size(524, 403);
            this.panelGames.TabIndex = 15;
            this.panelGames.SizeChanged += new System.EventHandler(this.panelGames_SizeChanged);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panelGames);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "Games";
            this.Size = new System.Drawing.Size(530, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelGamesTab;
        private System.Windows.Forms.PictureBox pictureBoxGamesTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGames;
    }
}
