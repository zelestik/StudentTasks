namespace УспеваемостьСтудентов
{
    partial class fmLoginHistory
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
            this.lvLoginHistory = new System.Windows.Forms.ListView();
            this.laWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLoginHistory
            // 
            this.lvLoginHistory.HideSelection = false;
            this.lvLoginHistory.Location = new System.Drawing.Point(12, 50);
            this.lvLoginHistory.Name = "lvLoginHistory";
            this.lvLoginHistory.Size = new System.Drawing.Size(776, 388);
            this.lvLoginHistory.TabIndex = 0;
            this.lvLoginHistory.UseCompatibleStateImageBehavior = false;
            // 
            // laWelcome
            // 
            this.laWelcome.AutoSize = true;
            this.laWelcome.BackColor = System.Drawing.Color.DodgerBlue;
            this.laWelcome.Font = new System.Drawing.Font("Gilroy ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laWelcome.ForeColor = System.Drawing.Color.White;
            this.laWelcome.Location = new System.Drawing.Point(12, 9);
            this.laWelcome.Name = "laWelcome";
            this.laWelcome.Size = new System.Drawing.Size(424, 37);
            this.laWelcome.TabIndex = 2;
            this.laWelcome.Text = "Ваша история авторизаций:";
            // 
            // fmLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laWelcome);
            this.Controls.Add(this.lvLoginHistory);
            this.Name = "fmLoginHistory";
            this.Text = "История авторизаций";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLoginHistory;
        private System.Windows.Forms.Label laWelcome;
    }
}