namespace StudentTasks
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.laWelcome = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIsOffline = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCapcha = new System.Windows.Forms.TextBox();
            this.buNewCapcha = new System.Windows.Forms.Button();
            this.btnCheckCAPCHA = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUser.Location = new System.Drawing.Point(110, 58);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(214, 31);
            this.txtUser.TabIndex = 0;
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
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass.Location = new System.Drawing.Point(110, 94);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(214, 31);
            this.txtPass.TabIndex = 2;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Gilroy ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Location = new System.Drawing.Point(0, 444);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(332, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // cbIsOffline
            // 
            this.cbIsOffline.AutoSize = true;
            this.cbIsOffline.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsOffline.Location = new System.Drawing.Point(6, 130);
            this.cbIsOffline.Name = "cbIsOffline";
            this.cbIsOffline.Size = new System.Drawing.Size(193, 29);
            this.cbIsOffline.TabIndex = 6;
            this.cbIsOffline.Text = "Оффлайн режим";
            this.cbIsOffline.UseVisualStyleBackColor = true;
            this.cbIsOffline.CheckedChanged += new System.EventHandler(this.cbOffline_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 165);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 50);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtCapcha
            // 
            this.txtCapcha.Font = new System.Drawing.Font("Gilroy ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapcha.Location = new System.Drawing.Point(110, 165);
            this.txtCapcha.Name = "txtCapcha";
            this.txtCapcha.Size = new System.Drawing.Size(100, 23);
            this.txtCapcha.TabIndex = 8;
            this.txtCapcha.Visible = false;
            // 
            // buNewCapcha
            // 
            this.buNewCapcha.BackColor = System.Drawing.Color.White;
            this.buNewCapcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buNewCapcha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buNewCapcha.Location = new System.Drawing.Point(110, 194);
            this.buNewCapcha.Name = "buNewCapcha";
            this.buNewCapcha.Size = new System.Drawing.Size(100, 23);
            this.buNewCapcha.TabIndex = 9;
            this.buNewCapcha.Text = "Обновить";
            this.buNewCapcha.UseVisualStyleBackColor = false;
            this.buNewCapcha.Visible = false;
            this.buNewCapcha.Click += new System.EventHandler(this.buNewCapcha_Click);
            // 
            // btnCheckCAPCHA
            // 
            this.btnCheckCAPCHA.BackColor = System.Drawing.Color.White;
            this.btnCheckCAPCHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCAPCHA.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckCAPCHA.Location = new System.Drawing.Point(216, 165);
            this.btnCheckCAPCHA.Name = "btnCheckCAPCHA";
            this.btnCheckCAPCHA.Size = new System.Drawing.Size(100, 23);
            this.btnCheckCAPCHA.TabIndex = 10;
            this.btnCheckCAPCHA.Text = "Проверить";
            this.btnCheckCAPCHA.UseVisualStyleBackColor = false;
            this.btnCheckCAPCHA.Visible = false;
            this.btnCheckCAPCHA.Click += new System.EventHandler(this.btnCheckCAPCHA_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.White;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReg.Location = new System.Drawing.Point(9, 221);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(315, 23);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(332, 493);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnCheckCAPCHA);
            this.Controls.Add(this.buNewCapcha);
            this.Controls.Add(this.txtCapcha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbIsOffline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.laWelcome);
            this.Controls.Add(this.txtUser);
            this.Font = new System.Drawing.Font("Gilroy ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(350, 540);
            this.MinimumSize = new System.Drawing.Size(350, 540);
            this.Name = "fmLogin";
            this.Opacity = 0.95D;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label laWelcome;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbIsOffline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCapcha;
        private System.Windows.Forms.Button buNewCapcha;
        private System.Windows.Forms.Button btnCheckCAPCHA;
        private System.Windows.Forms.Button btnReg;
    }
}

