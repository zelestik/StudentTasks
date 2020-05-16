namespace УспеваемостьСтудентов
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.Location = new System.Drawing.Point(75, 62);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(135, 22);
            this.tbUser.TabIndex = 0;
            // 
            // laWelcome
            // 
            this.laWelcome.AutoSize = true;
            this.laWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.laWelcome.Location = new System.Drawing.Point(0, 0);
            this.laWelcome.Name = "laWelcome";
            this.laWelcome.Size = new System.Drawing.Size(133, 17);
            this.laWelcome.TabIndex = 1;
            this.laWelcome.Text = "Добро пожаловать";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Location = new System.Drawing.Point(75, 90);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(135, 22);
            this.tbPass.TabIndex = 2;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // buLogin
            // 
            this.buLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buLogin.Location = new System.Drawing.Point(0, 170);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(222, 23);
            this.buLogin.TabIndex = 3;
            this.buLogin.Text = "Войти";
            this.buLogin.UseVisualStyleBackColor = true;
            this.buLogin.Click += new System.EventHandler(this.buLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.laWelcome);
            this.Controls.Add(this.tbUser);
            this.MaximumSize = new System.Drawing.Size(240, 240);
            this.MinimumSize = new System.Drawing.Size(240, 240);
            this.Name = "Form1";
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
    }
}

