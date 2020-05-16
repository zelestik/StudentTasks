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
            this.laName.Location = new System.Drawing.Point(13, 13);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(73, 17);
            this.laName.TabIndex = 0;
            this.laName.Text = "Ваше имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 33);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(304, 22);
            this.tbName.TabIndex = 1;
            // 
            // laGroup
            // 
            this.laGroup.AutoSize = true;
            this.laGroup.Location = new System.Drawing.Point(12, 62);
            this.laGroup.Name = "laGroup";
            this.laGroup.Size = new System.Drawing.Size(96, 17);
            this.laGroup.TabIndex = 2;
            this.laGroup.Text = "Ваша группа:";
            // 
            // laRole
            // 
            this.laRole.AutoSize = true;
            this.laRole.Location = new System.Drawing.Point(13, 89);
            this.laRole.Name = "laRole";
            this.laRole.Size = new System.Drawing.Size(87, 17);
            this.laRole.TabIndex = 3;
            this.laRole.Text = "Ваша роль: ";
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 223);
            this.Controls.Add(this.laRole);
            this.Controls.Add(this.laGroup);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.laName);
            this.MaximumSize = new System.Drawing.Size(350, 270);
            this.MinimumSize = new System.Drawing.Size(350, 270);
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