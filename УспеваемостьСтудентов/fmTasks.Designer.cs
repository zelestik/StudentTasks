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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.созданоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вРаботеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделаноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laWelcome = new System.Windows.Forms.Label();
            this.buRefresh = new System.Windows.Forms.Button();
            this.buAbout = new System.Windows.Forms.Button();
            this.buNT = new System.Windows.Forms.Button();
            this.buGroup = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.DarkOrange;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 53);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1150, 490);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданоToolStripMenuItem,
            this.вРаботеToolStripMenuItem,
            this.сделаноToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 24);
            this.toolStripMenuItem1.Text = "Сменить статус";
            // 
            // созданоToolStripMenuItem
            // 
            this.созданоToolStripMenuItem.Name = "созданоToolStripMenuItem";
            this.созданоToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.созданоToolStripMenuItem.Text = "Создано";
            // 
            // вРаботеToolStripMenuItem
            // 
            this.вРаботеToolStripMenuItem.Name = "вРаботеToolStripMenuItem";
            this.вРаботеToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.вРаботеToolStripMenuItem.Text = "В работе";
            // 
            // сделаноToolStripMenuItem
            // 
            this.сделаноToolStripMenuItem.Name = "сделаноToolStripMenuItem";
            this.сделаноToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.сделаноToolStripMenuItem.Text = "Сделано";
            // 
            // laWelcome
            // 
            this.laWelcome.AutoSize = true;
            this.laWelcome.Font = new System.Drawing.Font("Gilroy ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laWelcome.Location = new System.Drawing.Point(23, 14);
            this.laWelcome.Name = "laWelcome";
            this.laWelcome.Size = new System.Drawing.Size(199, 37);
            this.laWelcome.TabIndex = 1;
            this.laWelcome.Text = "Здравствуй, ";
            // 
            // buRefresh
            // 
            this.buRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buRefresh.BackColor = System.Drawing.Color.DarkOrange;
            this.buRefresh.FlatAppearance.BorderSize = 0;
            this.buRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buRefresh.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buRefresh.ForeColor = System.Drawing.Color.White;
            this.buRefresh.Location = new System.Drawing.Point(1051, 12);
            this.buRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buRefresh.Name = "buRefresh";
            this.buRefresh.Size = new System.Drawing.Size(117, 34);
            this.buRefresh.TabIndex = 2;
            this.buRefresh.Text = "Обновить";
            this.buRefresh.UseVisualStyleBackColor = false;
            this.buRefresh.Click += new System.EventHandler(this.buRefresh_Click);
            // 
            // buAbout
            // 
            this.buAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.buAbout.FlatAppearance.BorderSize = 0;
            this.buAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buAbout.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buAbout.ForeColor = System.Drawing.Color.White;
            this.buAbout.Location = new System.Drawing.Point(934, 12);
            this.buAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buAbout.Name = "buAbout";
            this.buAbout.Size = new System.Drawing.Size(112, 34);
            this.buAbout.TabIndex = 3;
            this.buAbout.Text = "Обо мне";
            this.buAbout.UseVisualStyleBackColor = false;
            this.buAbout.Click += new System.EventHandler(this.buAbout_Click);
            // 
            // buNT
            // 
            this.buNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buNT.BackColor = System.Drawing.Color.DarkOrange;
            this.buNT.FlatAppearance.BorderSize = 0;
            this.buNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buNT.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buNT.ForeColor = System.Drawing.Color.White;
            this.buNT.Location = new System.Drawing.Point(760, 12);
            this.buNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buNT.Name = "buNT";
            this.buNT.Size = new System.Drawing.Size(168, 34);
            this.buNT.TabIndex = 4;
            this.buNT.Text = "Новая задача";
            this.buNT.UseVisualStyleBackColor = false;
            this.buNT.Click += new System.EventHandler(this.buNT_Click);
            // 
            // buGroup
            // 
            this.buGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buGroup.BackColor = System.Drawing.Color.DarkOrange;
            this.buGroup.FlatAppearance.BorderSize = 0;
            this.buGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buGroup.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buGroup.ForeColor = System.Drawing.Color.White;
            this.buGroup.Location = new System.Drawing.Point(586, 11);
            this.buGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buGroup.Name = "buGroup";
            this.buGroup.Size = new System.Drawing.Size(168, 34);
            this.buGroup.TabIndex = 5;
            this.buGroup.Text = "Задачи группы";
            this.buGroup.UseVisualStyleBackColor = false;
            this.buGroup.Click += new System.EventHandler(this.buGroup_Click);
            // 
            // fmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1182, 567);
            this.Controls.Add(this.buGroup);
            this.Controls.Add(this.buNT);
            this.Controls.Add(this.buAbout);
            this.Controls.Add(this.buRefresh);
            this.Controls.Add(this.laWelcome);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "fmTasks";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Задачи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmTasks_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label laWelcome;
        private System.Windows.Forms.Button buRefresh;
        private System.Windows.Forms.Button buAbout;
        private System.Windows.Forms.Button buNT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem созданоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вРаботеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделаноToolStripMenuItem;
        private System.Windows.Forms.Button buGroup;
    }
}