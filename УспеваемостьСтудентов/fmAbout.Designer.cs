namespace УспеваемостьСтудентов
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
            this.laName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.laGroup = new System.Windows.Forms.Label();
            this.laRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(16, 16);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(90, 20);
            this.laName.TabIndex = 0;
            this.laName.Text = "Ваше имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(20, 41);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(379, 27);
            this.tbName.TabIndex = 1;
            // 
            // laGroup
            // 
            this.laGroup.AutoSize = true;
            this.laGroup.Location = new System.Drawing.Point(15, 78);
            this.laGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laGroup.Name = "laGroup";
            this.laGroup.Size = new System.Drawing.Size(123, 20);
            this.laGroup.TabIndex = 2;
            this.laGroup.Text = "Ваша группа:";
            // 
            // laRole
            // 
            this.laRole.AutoSize = true;
            this.laRole.Location = new System.Drawing.Point(16, 111);
            this.laRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laRole.Name = "laRole";
            this.laRole.Size = new System.Drawing.Size(109, 20);
            this.laRole.TabIndex = 3;
            this.laRole.Text = "Ваша роль: ";
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(415, 279);
            this.Controls.Add(this.laRole);
            this.Controls.Add(this.laGroup);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.laName);
            this.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(433, 326);
            this.MinimumSize = new System.Drawing.Size(433, 326);
            this.Name = "fmAbout";
            this.Text = "fmAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label laGroup;
        private System.Windows.Forms.Label laRole;
    }
}