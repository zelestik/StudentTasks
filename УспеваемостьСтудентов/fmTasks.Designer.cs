namespace StudentTasks
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.созданоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вРаботеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделаноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnGroupTasks = new System.Windows.Forms.Button();
            this.cboFilterByStatus = new System.Windows.Forms.ComboBox();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.cboFilterByType = new System.Windows.Forms.ComboBox();
            this.btnToWork = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Gilroy ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(199, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Здравствуй, ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(1051, 46);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAboutMe.BackColor = System.Drawing.Color.White;
            this.btnAboutMe.FlatAppearance.BorderSize = 0;
            this.btnAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutMe.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutMe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAboutMe.Location = new System.Drawing.Point(1051, 8);
            this.btnAboutMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(117, 34);
            this.btnAboutMe.TabIndex = 3;
            this.btnAboutMe.Text = "Обо мне";
            this.btnAboutMe.UseVisualStyleBackColor = false;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // btnNewTask
            // 
            this.btnNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTask.BackColor = System.Drawing.Color.White;
            this.btnNewTask.FlatAppearance.BorderSize = 0;
            this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTask.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewTask.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNewTask.Location = new System.Drawing.Point(837, 8);
            this.btnNewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(208, 34);
            this.btnNewTask.TabIndex = 4;
            this.btnNewTask.Text = "Новая задача";
            this.btnNewTask.UseVisualStyleBackColor = false;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnGroupTasks
            // 
            this.btnGroupTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupTasks.BackColor = System.Drawing.Color.White;
            this.btnGroupTasks.FlatAppearance.BorderSize = 0;
            this.btnGroupTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupTasks.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGroupTasks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGroupTasks.Location = new System.Drawing.Point(623, 8);
            this.btnGroupTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGroupTasks.Name = "btnGroupTasks";
            this.btnGroupTasks.Size = new System.Drawing.Size(208, 34);
            this.btnGroupTasks.TabIndex = 5;
            this.btnGroupTasks.Text = "Задачи группы";
            this.btnGroupTasks.UseVisualStyleBackColor = false;
            this.btnGroupTasks.Click += new System.EventHandler(this.btnGroupTasks_Click);
            // 
            // cboFilterByStatus
            // 
            this.cboFilterByStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterByStatus.BackColor = System.Drawing.Color.White;
            this.cboFilterByStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboFilterByStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterByStatus.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboFilterByStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cboFilterByStatus.FormattingEnabled = true;
            this.cboFilterByStatus.Location = new System.Drawing.Point(837, 50);
            this.cboFilterByStatus.Name = "cboFilterByStatus";
            this.cboFilterByStatus.Size = new System.Drawing.Size(208, 28);
            this.cboFilterByStatus.TabIndex = 6;
            this.cboFilterByStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lvTasks
            // 
            this.lvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTasks.BackColor = System.Drawing.Color.White;
            this.lvTasks.CheckBoxes = true;
            this.lvTasks.ContextMenuStrip = this.contextMenuStrip1;
            this.lvTasks.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTasks.ForeColor = System.Drawing.Color.Black;
            this.lvTasks.FullRowSelect = true;
            this.lvTasks.HideSelection = false;
            this.lvTasks.Location = new System.Drawing.Point(18, 85);
            this.lvTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvTasks.MultiSelect = false;
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(1150, 471);
            this.lvTasks.TabIndex = 0;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            this.lvTasks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTasks_ColumnClick);
            this.lvTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTasks_ItemChecked);
            this.lvTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTasks_Click);
            // 
            // cboFilterByType
            // 
            this.cboFilterByType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterByType.BackColor = System.Drawing.Color.White;
            this.cboFilterByType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboFilterByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterByType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterByType.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboFilterByType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cboFilterByType.FormattingEnabled = true;
            this.cboFilterByType.Location = new System.Drawing.Point(623, 50);
            this.cboFilterByType.Name = "cboFilterByType";
            this.cboFilterByType.Size = new System.Drawing.Size(208, 28);
            this.cboFilterByType.TabIndex = 7;
            this.cboFilterByType.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // btnToWork
            // 
            this.btnToWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToWork.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnToWork.FlatAppearance.BorderSize = 0;
            this.btnToWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToWork.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToWork.ForeColor = System.Drawing.Color.White;
            this.btnToWork.Location = new System.Drawing.Point(808, 512);
            this.btnToWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToWork.Name = "btnToWork";
            this.btnToWork.Size = new System.Drawing.Size(168, 34);
            this.btnToWork.TabIndex = 8;
            this.btnToWork.Text = "В работу";
            this.btnToWork.UseVisualStyleBackColor = false;
            this.btnToWork.Click += new System.EventHandler(this.btnToWork_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(991, 512);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(168, 34);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Сделано";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.Location = new System.Drawing.Point(91, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 27);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImport.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnImport.Location = new System.Drawing.Point(765, 46);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(280, 34);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Ипортировать пользователей";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // fmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 567);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnToWork);
            this.Controls.Add(this.cboFilterByType);
            this.Controls.Add(this.cboFilterByStatus);
            this.Controls.Add(this.btnGroupTasks);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lvTasks);
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
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem созданоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вРаботеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделаноToolStripMenuItem;
        private System.Windows.Forms.Button btnGroupTasks;
        private System.Windows.Forms.ComboBox cboFilterByStatus;
        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ComboBox cboFilterByType;
        private System.Windows.Forms.Button btnToWork;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImport;
    }
}