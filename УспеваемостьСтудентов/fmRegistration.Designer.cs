namespace УспеваемостьСтудентов
{
    partial class fmRegistration
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
            this.laFIO = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laFIO
            // 
            this.laFIO.AutoSize = true;
            this.laFIO.Location = new System.Drawing.Point(15, 123);
            this.laFIO.Name = "laFIO";
            this.laFIO.Size = new System.Drawing.Size(49, 20);
            this.laFIO.TabIndex = 0;
            this.laFIO.Text = "ФИО";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("Gilroy ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laName.Location = new System.Drawing.Point(13, 9);
            this.laName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(185, 34);
            this.laName.TabIndex = 1;
            this.laName.Text = "Регистрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // fmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laName);
            this.Controls.Add(this.laFIO);
            this.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmRegistration";
            this.Text = "fmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laFIO;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}