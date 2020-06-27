namespace StudentTasks
{
    partial class fmAbout
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLoginHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 16);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ваше имя";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(379, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(15, 78);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(123, 20);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Ваша группа:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(16, 111);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(109, 20);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Ваша роль: ";
            // 
            // btnLoginHistory
            // 
            this.btnLoginHistory.BackColor = System.Drawing.Color.White;
            this.btnLoginHistory.FlatAppearance.BorderSize = 0;
            this.btnLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginHistory.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginHistory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginHistory.Location = new System.Drawing.Point(227, 190);
            this.btnLoginHistory.Name = "btnLoginHistory";
            this.btnLoginHistory.Size = new System.Drawing.Size(176, 77);
            this.btnLoginHistory.TabIndex = 4;
            this.btnLoginHistory.Text = "История авторизаций";
            this.btnLoginHistory.UseVisualStyleBackColor = false;
            this.btnLoginHistory.Click += new System.EventHandler(this.btnLoginHistory_Click);
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(415, 279);
            this.Controls.Add(this.btnLoginHistory);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(433, 326);
            this.MinimumSize = new System.Drawing.Size(433, 326);
            this.Name = "fmAbout";
            this.Text = "О Вас";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLoginHistory;
    }
}