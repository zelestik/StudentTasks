namespace УспеваемостьСтудентов
{
    partial class fmLogin
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUser = new System.Windows.Forms.TextBox();
            this.laWelcome = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.buLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOffline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.Location = new System.Drawing.Point(86, 58);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(158, 31);
            this.tbUser.TabIndex = 0;
            // 
            // laWelcome
            // 
            this.laWelcome.AutoSize = true;
            this.laWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.laWelcome.Font = new System.Drawing.Font("Gilroy ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laWelcome.Location = new System.Drawing.Point(0, 0);
            this.laWelcome.Name = "laWelcome";
            this.laWelcome.Size = new System.Drawing.Size(244, 31);
            this.laWelcome.TabIndex = 1;
            this.laWelcome.Text = "Добро пожаловать";
            this.laWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(86, 94);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(158, 31);
            this.tbPass.TabIndex = 2;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // buLogin
            // 
            this.buLogin.BackColor = System.Drawing.Color.Indigo;
            this.buLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buLogin.FlatAppearance.BorderSize = 0;
            this.buLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buLogin.Font = new System.Drawing.Font("Gilroy ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buLogin.ForeColor = System.Drawing.Color.White;
            this.buLogin.Location = new System.Drawing.Point(0, 174);
            this.buLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(252, 49);
            this.buLogin.TabIndex = 3;
            this.buLogin.Text = "Войти";
            this.buLogin.UseVisualStyleBackColor = false;
            this.buLogin.Click += new System.EventHandler(this.buLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // cbOffline
            // 
            this.cbOffline.AutoSize = true;
            this.cbOffline.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOffline.Location = new System.Drawing.Point(6, 130);
            this.cbOffline.Name = "cbOffline";
            this.cbOffline.Size = new System.Drawing.Size(193, 29);
            this.cbOffline.TabIndex = 6;
            this.cbOffline.Text = "Оффлайн режим";
            this.cbOffline.UseVisualStyleBackColor = true;
            this.cbOffline.CheckedChanged += new System.EventHandler(this.cbOffline_CheckedChanged);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(252, 223);
            this.Controls.Add(this.cbOffline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.laWelcome);
            this.Controls.Add(this.tbUser);
            this.Font = new System.Drawing.Font("Gilroy ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(270, 270);
            this.MinimumSize = new System.Drawing.Size(270, 270);
            this.Name = "fmLogin";
            this.Opacity = 0.95D;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label laWelcome;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button buLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbOffline;
    }
}

