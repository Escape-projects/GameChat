namespace ChatGame.panels
{
    partial class AccountConfirmation
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
            this.panelConfirm = new System.Windows.Forms.Panel();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelErrorCode = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.panelConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfirm
            // 
            this.panelConfirm.BackColor = System.Drawing.Color.White;
            this.panelConfirm.Controls.Add(this.labelRegistration);
            this.panelConfirm.Controls.Add(this.labelQuestion);
            this.panelConfirm.Controls.Add(this.labelErrorCode);
            this.panelConfirm.Controls.Add(this.buttonConfirm);
            this.panelConfirm.Controls.Add(this.textBoxCode);
            this.panelConfirm.Controls.Add(this.labelCode);
            this.panelConfirm.Controls.Add(this.labelConfirm);
            this.panelConfirm.Location = new System.Drawing.Point(155, 97);
            this.panelConfirm.Name = "panelConfirm";
            this.panelConfirm.Size = new System.Drawing.Size(440, 207);
            this.panelConfirm.TabIndex = 1;
            this.panelConfirm.Click += new System.EventHandler(this.ActiveControlNull);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRegistration.ForeColor = System.Drawing.Color.DimGray;
            this.labelRegistration.Location = new System.Drawing.Point(156, 170);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(166, 15);
            this.labelRegistration.TabIndex = 10;
            this.labelRegistration.Text = "Зарегистрироваться ещё раз";
            this.labelRegistration.Click += new System.EventHandler(this.labelRegistration_Click);
            this.labelRegistration.MouseEnter += new System.EventHandler(this.labelRegistration_MouseEnter);
            this.labelRegistration.MouseLeave += new System.EventHandler(this.labelRegistration_MouseLeave);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelQuestion.Location = new System.Drawing.Point(38, 170);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(121, 15);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Не пришло письмо?";
            // 
            // labelErrorCode
            // 
            this.labelErrorCode.AutoSize = true;
            this.labelErrorCode.BackColor = System.Drawing.Color.White;
            this.labelErrorCode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelErrorCode.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCode.Location = new System.Drawing.Point(38, 104);
            this.labelErrorCode.Name = "labelErrorCode";
            this.labelErrorCode.Size = new System.Drawing.Size(49, 13);
            this.labelErrorCode.TabIndex = 7;
            this.labelErrorCode.Text = "ошибка";
            this.labelErrorCode.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.LightGray;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(34, 130);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(373, 33);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.LightGray;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.Location = new System.Drawing.Point(34, 79);
            this.textBoxCode.MaxLength = 8;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(373, 23);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxConfirm_TextChanged);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCode.Location = new System.Drawing.Point(31, 55);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(372, 21);
            this.labelCode.TabIndex = 1;
            this.labelCode.Text = "Введите код отправленный на электронную почту";
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelConfirm.Location = new System.Drawing.Point(74, 17);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(293, 25);
            this.labelConfirm.TabIndex = 0;
            this.labelConfirm.Text = "Подтверждение учётной записи";
            // 
            // AccountConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelConfirm);
            this.Name = "AccountConfirmation";
            this.Size = new System.Drawing.Size(750, 400);
            this.SizeChanged += new System.EventHandler(this.AccountConfirmation_SizeChanged);
            this.Click += new System.EventHandler(this.ActiveControlNull);
            this.panelConfirm.ResumeLayout(false);
            this.panelConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfirm;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelErrorCode;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelConfirm;
    }
}
