namespace УспеваемостьСтудентов
{
    partial class fmTasks
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.laWelcome = new System.Windows.Forms.Label();
            this.buRefresh = new System.Windows.Forms.Button();
            this.buAbout = new System.Windows.Forms.Button();
            this.buNT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // laWelcome
            // 
            this.laWelcome.AutoSize = true;
            this.laWelcome.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laWelcome.Location = new System.Drawing.Point(23, 13);
            this.laWelcome.Name = "laWelcome";
            this.laWelcome.Size = new System.Drawing.Size(167, 35);
            this.laWelcome.TabIndex = 1;
            this.laWelcome.Text = "Здравствуй, ";
            // 
            // buRefresh
            // 
            this.buRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buRefresh.Location = new System.Drawing.Point(701, 12);
            this.buRefresh.Name = "buRefresh";
            this.buRefresh.Size = new System.Drawing.Size(87, 23);
            this.buRefresh.TabIndex = 2;
            this.buRefresh.Text = "Обновить";
            this.buRefresh.UseVisualStyleBackColor = true;
            this.buRefresh.Click += new System.EventHandler(this.buRefresh_Click);
            // 
            // buAbout
            // 
            this.buAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buAbout.Location = new System.Drawing.Point(608, 12);
            this.buAbout.Name = "buAbout";
            this.buAbout.Size = new System.Drawing.Size(87, 23);
            this.buAbout.TabIndex = 3;
            this.buAbout.Text = "Обо мне";
            this.buAbout.UseVisualStyleBackColor = true;
            this.buAbout.Click += new System.EventHandler(this.buAbout_Click);
            // 
            // buNT
            // 
            this.buNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buNT.Location = new System.Drawing.Point(471, 12);
            this.buNT.Name = "buNT";
            this.buNT.Size = new System.Drawing.Size(131, 23);
            this.buNT.TabIndex = 4;
            this.buNT.Text = "Новая задача";
            this.buNT.UseVisualStyleBackColor = true;
            this.buNT.Click += new System.EventHandler(this.buNT_Click);
            // 
            // fmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buNT);
            this.Controls.Add(this.buAbout);
            this.Controls.Add(this.buRefresh);
            this.Controls.Add(this.laWelcome);
            this.Controls.Add(this.listView1);
            this.Name = "fmTasks";
            this.Text = "Задачи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmTasks_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label laWelcome;
        private System.Windows.Forms.Button buRefresh;
        private System.Windows.Forms.Button buAbout;
        private System.Windows.Forms.Button buNT;
    }
}